create or alter proc dbo.MealListGet(
    @Meassage varchar(500) = '' output
)
as
begin
    declare @return int = 0
        ;
        with x as(
            select 
                MealId = mc.MealId, 
                NumOfCalories = sum(r.NumOfCalories), 
                NumOfRecipes = count(*)
            from MealCourse mc
            join MealCourseRecipe mcr
            on mc.MealCourseId = mcr.MealCourseId
            join Recipe r
            on mcr.RecipeId = r.RecipeId
            group by mc.MealId
        )
        select 
            m.MealName, 
            u.UserName, 
            x.NumOfCalories, 
            NumOfCourses = count(*),
            x.NumOfRecipes
        from x
        join Meal m
        on x.MealId = m.MealId
        join MealCourse mc
        on m.MealId = mc.MealId
        join [User] u
        on m.UserId = u.UserId
        where m.MealActive = 1
        group by m.MealName, u.UserName, x.NumOfRecipes, x.NumOfCalories
        order by m.MealName

    return @return
end
go

exec MealListGet


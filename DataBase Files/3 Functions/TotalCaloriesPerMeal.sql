create or alter function dbo.TotalCaloriesPerMeal(@MealId int)
returns int
as
begin
    declare @value int = 0
        select @value = sum(r.NumOfCalories)
        from Meal m
        join MealCourse mc
        on m.MealId = mc.MealId
        join MealCourseRecipe mcr
        on mc.MealCourseId = mcr.MealCourseId
        join Recipe r
        on mcr.RecipeId = r.RecipeId
        where m.MealId = @MealId
        group by m.MealName
    return @value
end 
go

select MealName = m.MealName, TotalCalories = dbo.TotalCaloriesPerMeal(m.MealId)
from Meal m
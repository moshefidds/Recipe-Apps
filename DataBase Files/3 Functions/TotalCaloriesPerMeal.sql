create or alter function dbo.TotalCaloriesPerMeal(@MealId int)
returns int
as
begin
    declare @value int = 0
        select @value = sum(r.NumOfCalories)
        from MealCourse mc
        join MealCourseRecipe mcr
        on mc.MealCourseId = mcr.MealCourseId
        join Recipe r
        on mcr.RecipeId = r.RecipeId
        where mc.MealId = @MealId
    return @value
end 
go

select MealName = m.MealName, TotalCalories = dbo.TotalCaloriesPerMeal(m.MealId)
from Meal m
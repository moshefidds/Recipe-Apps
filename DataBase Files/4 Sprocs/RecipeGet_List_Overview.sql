create or alter proc dbo.RecipeGet_List_Overview(
    @Meassage varchar(500) = '' output
)
as
begin
    declare @return int = 0
        select r.RecipeId, r.RecipeName, Status = r.RecipeStatus, [User] = u.UserName, Calories = r.NumOfCalories, NumIngredients = count(ri.RecipeIngredientId)
        from Recipe r
        left join [User] u
        on r.UserId = u.UserId
        left join RecipeIngredient ri
        on r.RecipeId = ri.RecipeId
        group by r.RecipeId, r.RecipeName, r.RecipeStatus, u.UserName, r.NumOfCalories
        order by r.RecipeStatus desc
    return @return
end 
go

exec RecipeGet_List_Overview
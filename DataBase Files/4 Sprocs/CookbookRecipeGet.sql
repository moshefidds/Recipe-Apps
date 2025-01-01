create or alter proc dbo.CookbookRecipeGet(
    @CookbookId int = 0,
    @Message varchar(500) = ''
)
as 
begin
    select cbr.CookBookId, cbr.CookBookRecipeId, r.RecipeId, r.RecipeName, cbr.CookBookRecipeSequence
    from CookBookRecipe cbr
    join Recipe r
    on cbr.RecipeId = r.RecipeId
    where cbr.CookBookId = @CookbookId
    order by cbr.CookBookRecipeSequence
end
go
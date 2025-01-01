create or alter procedure dbo.CookbookRecipeDelete(
	@CookbookRecipeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0)

	delete CookBookRecipe
    where CookBookRecipeId = @CookbookRecipeId

	return @return
end
go



create or alter procedure dbo.RecipeStepsGet(
	@RecipeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0)

	select rd.RecipeDirectionsId,  rd.RecipeId, rd.RecipeDirection, rd.RecipeDirectionSequence
    from RecipeDirections rd
    where rd.RecipeId = @RecipeId
	
	return @return
end
go


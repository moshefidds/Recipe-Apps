create or alter procedure dbo.RecipeIngredientMeasurementGet(
    @RecipeId int = 0,
    @Message varchar(500) = '' output
)
as 
begin
    select ri.RecipeIngredientId, r.RecipeId, r.RecipeName, i.IngredientId ,i.IngredientName, m.MeasurementType, m.MeasurementId, ri.MeasurementAmount, ri.IngredientSequence
    from Recipe r
    join RecipeIngredient ri
    on r.RecipeId = ri.RecipeId
    join Ingredient i
    on ri.IngredientId = i.IngredientId
    join Measurement m
    on ri.MeasurementId = m.MeasurementId
    where r.RecipeId = @RecipeId
    order by ri.IngredientSequence
end
go

--exec RecipeIngredientMeasurementGet @RecipeId = 23
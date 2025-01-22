Use RecipeDB
go 
create or alter proc dbo.CloneARecipe(
    @RecipeId int = null output,
    @SourceRecipeId int,
    @Message varchar(500) = '' output
)
as 
    begin
        declare @return int = 0

            insert Recipe(UserId, CuisineId, RecipeName, NumOfCalories, DateDrafted, DatePublished, DateArchived)
            select r.UserId, r.CuisineId, concat(r.RecipeName, ' - clone'), r.NumOfCalories, getdate(), null, null
            from Recipe r
            where r.RecipeId = @SourceRecipeId

            select @RecipeId = SCOPE_IDENTITY()

            insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmount, IngredientSequence)
            select @RecipeId, ri.IngredientId, ri.MeasurementId, ri.MeasurementAmount, ri.IngredientSequence
            from RecipeIngredient ri
            where ri.RecipeId = @SourceRecipeId

            insert RecipeDirections(RecipeId, RecipeDirection, RecipeDirectionSequence)
            select @RecipeId, rd.RecipeDirection, rd.RecipeDirectionSequence
            from RecipeDirections rd
            where rd.RecipeId = @SourceRecipeId

        return @return
    end
go

--exec CloneARecipe @SourceRecipeId = 29

--select * from Recipe 
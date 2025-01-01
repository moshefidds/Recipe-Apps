Use RecipeDB
go 
create or alter proc dbo.CloneARecipe(
    @RecipeId int
)
as 
begin

    select @RecipeId = isnull(@RecipeId, 0)

    insert Recipe(UserId, CuisineId, RecipeName, NumOfCalories, DateDrafted, DatePublished, DateArchived)
    select r.UserId, r.CuisineId, concat(r.RecipeName, ' - clone'), r.NumOfCalories, getdate(), null, null
    from Recipe r
    where r.RecipeId = @RecipeId
    
    ;
    with x as(
        select RecipeName = concat(r.RecipeName, ' - clone'), IngredientId = ri.IngredientId, MeasurementId = ri.MeasurementId, MeasurementAmount = ri.MeasurementAmount, IngredientSequence = ri.IngredientSequence
        from Recipe r
        join RecipeIngredient ri
        on r.RecipeId = ri.RecipeId
        where r.RecipeId = @RecipeId
    )
    insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmount, IngredientSequence)
    select r.RecipeId, x.IngredientId, x.MeasurementId, x.MeasurementAmount, x.IngredientSequence
    from x
    join Recipe r
    on x.RecipeName = r.RecipeName
    
    ;
    with x as(
        select RecipeName = concat(r.RecipeName, ' - clone'), RecipeDirection = rd.RecipeDirection , RecipeDirectionSequence = rd.RecipeDirectionSequence
        from Recipe r
        join RecipeDirections rd
        on r.RecipeId = rd.RecipeId
        where r.RecipeId = @RecipeId
    )
    insert RecipeDirections(RecipeId, RecipeDirection, RecipeDirectionSequence)
    select r.RecipeId, x.RecipeDirection, x.RecipeDirectionSequence
    from x
    join Recipe r
    on x.RecipeName = r.RecipeName
end
go 

exec CloneARecipe @RecipeId = 24

select * from Recipe
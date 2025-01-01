create or alter proc dbo.RecipeIngredientUpdate(
    @RecipeIngredientId int output,
    @RecipeId int output,
    @IngredientId int output,
    @MeasurementId int output,
    @MeasurementAmount int output,
    @IngredientSequence int output,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

    if @RecipeIngredientId = 0
        begin
            declare @NewIngredientSequence int = (
                    select top 1 NewIngredientSequence = ri.IngredientSequence + 1
                    from RecipeIngredient ri
                    where ri.RecipeId = @RecipeId
                    order by ri.IngredientSequence desc
                )
            insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmount, IngredientSequence)
            values(@RecipeId, @IngredientId, @MeasurementId, @MeasurementAmount, isnull(@NewIngredientSequence, 1))                
        end

    else
        begin
            Update RecipeIngredient
            set
                IngredientId = @IngredientId,
                MeasurementId = @MeasurementId,
                MeasurementAmount = @MeasurementAmount,
                IngredientSequence = @IngredientSequence
            where RecipeIngredientId = @RecipeIngredientId
        end

    select @RecipeIngredientId = SCOPE_IDENTITY()
    
    return @return
end

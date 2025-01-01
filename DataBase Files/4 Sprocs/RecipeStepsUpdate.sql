create or alter proc dbo.RecipeStepsUpdate(
    @RecipeDirectionsId int output,
    @RecipeId int output,
    @RecipeDirection varchar(100),
    @RecipeDirectionSequence int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @RecipeDirectionsId = isnull(@RecipeDirectionsId, 0)

    if @RecipeDirectionsId = 0
        begin
            declare @NewRecipeDirectionSequence int = (
                    select top 1 NewRecipeDirectionSequence = rd.RecipeDirectionSequence + 1
                    from RecipeDirections rd
                    where rd.RecipeId = @RecipeId
                    order by rd.RecipeDirectionSequence desc
                )
            insert RecipeDirections(RecipeId, RecipeDirection, RecipeDirectionSequence)
            values(@RecipeId, @RecipeDirection, isnull(@NewRecipeDirectionSequence, 1))                
        end

    else
        begin
            Update RecipeDirections
            set
                RecipeDirection = @RecipeDirection,
                RecipeDirectionSequence = @RecipeDirectionSequence
            where RecipeDirectionsId = @RecipeDirectionsId
        end

    select @RecipeDirectionsId = SCOPE_IDENTITY()
    
    return @return
end



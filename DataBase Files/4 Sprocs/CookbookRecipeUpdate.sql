create or alter proc dbo.CookbookRecipeUpdate(
    @CookBookRecipeId int = 0 output,
    @CookBookId int output,
    @RecipeId int output,
    @CookBookRecipeSequence int output,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @CookBookRecipeId = isnull(@CookBookRecipeId, 0)

    if @CookBookRecipeId = 0
        begin
            declare @NewCookBookRecipeSequence int = (
                    select top 1 NewCookBookRecipeSequence = cbr.CookBookRecipeSequence + 1
                    from CookBookRecipe cbr
                    where cbr.CookBookId = @CookBookId
                    order by cbr.CookBookRecipeSequence desc
                )
            insert CookBookRecipe(CookBookId, RecipeId, CookBookRecipeSequence)
            values(@CookBookId, @RecipeId, isnull(@NewCookBookRecipeSequence, 1))   

            select @CookBookRecipeId = SCOPE_IDENTITY()             
        end

    else
        begin
            Update CookBookRecipe
            set
                CookBookId = @CookBookId,
                RecipeId = @RecipeId,
                CookBookRecipeSequence = @CookBookRecipeSequence
            where CookBookRecipeId = @CookBookRecipeId
        end
    
    return @return
end
go

create or alter function dbo.DetermineRecipeIngredientExists(
    @RecipeId int ,
    @IngredientId int
)
returns bit
as 
begin
    declare @exists bit = 0
        if exists(
            select *
            from RecipeIngredient ri
            where ri.RecipeId = @RecipeId
            and ri.IngredientId = @IngredientId
        )
        begin
            select @exists = 1
        end
    return @exists
end
go


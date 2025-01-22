create or alter proc dbo.IngredientUpdate(
    @IngredientId int = 0 output,
    @IngredientName varchar(75),
    @Message varchar(500) = ''
)
as 
begin
    declare @return int = 0

    select @IngredientId = isnull(@IngredientId, 0)

    if @IngredientId = 0
        begin
            insert Ingredient(IngredientName)
            values(@IngredientName)

            select @IngredientId = SCOPE_IDENTITY()
        end
    else 
        begin
            update Ingredient
            set
            IngredientName = @IngredientName
        where IngredientId = @IngredientId
    end
    return @return
end
go
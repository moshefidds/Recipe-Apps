create or alter proc dbo.IngredientUpdate(
    @IngredientId int output,
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
        end
    else 
        begin
            update Ingredient
            set
            IngredientName = @IngredientName
        where IngredientId = @IngredientId
    end
    select @IngredientId = SCOPE_IDENTITY()
end
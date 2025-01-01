use RecipeDB
go
create or alter procedure dbo.IngredientGet(
    @IngredientId int = 0, 
    @IngredientName varchar(100) = '', 
    @All bit = 0, @includeblank bit = 0)
as 
begin
    select @IngredientName = nullif(@IngredientName, ''), @includeblank = isnull(@includeblank, 0)
    select i.IngredientId, i.IngredientName
    from Ingredient i
    where i.IngredientId = @IngredientId
    or i.IngredientName like '%' + @IngredientName + '%'
    or @All = 1
    union select 0, ' '
    where @includeblank = 1
    order by i.IngredientName
end
go

exec IngredientGet

exec IngredientGet @All = 1, @IncludeBlank = 1
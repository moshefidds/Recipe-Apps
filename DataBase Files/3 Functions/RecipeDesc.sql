create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(200)
as
begin
    declare @value varchar(200) = ''
    select @value = concat(
        r.RecipeName,
        case
            when c.CuisineId is not null then concat(' (', c.CuisineType, ') ')
            else ''
        end,
        'has ',
        count(distinct ri.RecipeIngredientId),
        ' ingredients and ',
        count(distinct rd.RecipeDirectionsId),
        ' steps.'
    )
    from Recipe r
    left join Cuisine c
    on r.CuisineId = c.CuisineId
    left join RecipeIngredient ri
    on r.RecipeId = ri.RecipeId
    left join RecipeDirections rd
    on r.RecipeId = rd.RecipeId
    where r.RecipeId = @RecipeId
    group by r.RecipeName, c.CuisineId, c.CuisineType
    return @value
end
go

select RecipeDesc = dbo.RecipeDesc(r.RecipeId), r.*
from Recipe r
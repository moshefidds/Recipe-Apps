use RecipeDB
go
create or alter procedure dbo.RecipeGet(
    @RecipeId int = 0, 
    @RecipeName varchar(100) = '', 
    @All bit = 0, 
    @includeblank bit = 0
)
as
begin
    select @RecipeName = nullif(@RecipeName, '')
    select 
        r.RecipeId, 
        r.UserId, 
        r.CuisineId, 
        r.RecipeName, 
        r.NumOfCalories, 
        r.DateDrafted, 
        r.DatePublished, 
        r.DateArchived, 
        r.RecipeStatus,
        RecipeDesc = dbo.RecipeDesc(r.RecipeId)
    from Recipe r
    where r.RecipeId = @RecipeId
    or r.RecipeName like '%' + @RecipeName + '%'
    or @All = 1
    union select 0, 0, 0, '', 0,'', '', '', '', ''
    where @includeblank = 1
    order by r.RecipeName
end
go

--exec RecipeGet

exec RecipeGet @All = 1, @includeblank = 1

--exec RecipeGet @RecipeName = ''

--exec RecipeGet @RecipeName = 'th'

/*
declare @id int
select top 1 @id = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @id
*/
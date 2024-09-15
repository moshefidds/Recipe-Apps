use RecipeDB
go
create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @RecipeName varchar(100) = '', @All bit = 0)
as
begin
    --select @RecipeName = nullif(@RecipeName, '')
    select r.RecipeId, r.UserId, r.CuisineId, r.RecipeName, r.NumOfCalories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus
    from Recipe r
    where r.RecipeId = @RecipeId
    or r.RecipeName like '%' + @RecipeName + '%'
    or @All = 1
end
go

--exec RecipeGet

--exec RecipeGet @All = 1

--exec RecipeGet @RecipeName = ''

--exec RecipeGet @RecipeName = 'ku'

/*
declare @id int
select top 1 @id = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @id
*/
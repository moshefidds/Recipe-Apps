use RecipeDB
go
create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @CuisineType varchar(100) = '', @All bit = 0)
as 
begin
    select @CuisineType = nullif(@CuisineType, '')
    select *
    from Cuisine c
    where c.CuisineId = @CuisineId
    or c.CuisineType like '%' + @CuisineType + '%'
    or @All = 1
end
go

--exec CuisineGet

--exec CuisineGet @All = 1

--exec CuisineGet @CuisineType = ''

--exec CuisineGet @CuisineType = 'med'

/*
declare @id int
select top 1 @id = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @id
*/
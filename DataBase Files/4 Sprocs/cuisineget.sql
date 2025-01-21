create or alter procedure dbo.CuisineGet(
    @CuisineId int = 0, 
    @CuisineType varchar(100) = '', 
    @All bit = 0, 
    @includeblank bit = 0,
    @Message varchar(500) = '' output
)
as 
begin
    select @CuisineType = nullif(@CuisineType, ''), @includeblank = isnull(@includeblank, 0)
    select c.CuisineId, c.CuisineType
    from Cuisine c
    where c.CuisineId = @CuisineId
    or c.CuisineType like '%' + @CuisineType + '%'
    or @All = 1
    union select '', ''
    where @includeblank = 1
    order by c.CuisineType
end
go

--exec CuisineGet

--exec CuisineGet @All = 1

--exec CuisineGet @All = 1, @IncludeBlank = 1

--exec CuisineGet @CuisineType = ''

--exec CuisineGet @CuisineType = 'med'

/*
declare @id int
select top 1 @id = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @id
*/
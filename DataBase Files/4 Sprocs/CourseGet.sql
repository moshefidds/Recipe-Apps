create or alter procedure dbo.CourseGet(
    @CourseId int = 0, 
    @CourseType varchar(100) = '', 
    @CourseSequence int = 0,
    @All bit = 0, 
    @includeblank bit = 0,
    @Message varchar(500) = '' output
    )
as 
begin
    select @CourseId = nullif(@CourseId, 0), @CourseType = nullif(@CourseType, ''), @CourseSequence = nullif(@CourseSequence, ''),  @includeblank = isnull(@includeblank, 0)

    select c.CourseId, c.CourseType, c.CourseSequence
    from Course c
    where c.CourseId = @CourseId
    or c.CourseType like '%' + @CourseType + '%'
    or @All = 1
    union select 0, '', 0
    where @includeblank = 1
    order by c.CourseType
end
go

--exec CourseGet

--exec CourseGet @All = 1



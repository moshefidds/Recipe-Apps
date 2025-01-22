create or alter proc dbo.CourseUpdate(
    @CourseId int = 0 output,
    @CourseType varchar(50),
    @CourseSequence int,
    @Message varchar(500) = ''
)
as 
begin
    declare @return int = 0

    select @CourseId = isnull(@CourseId, 0)

    if @CourseId = 0
        begin
            insert Course(CourseType, CourseSequence)
            values(@CourseType, @CourseSequence)

            select @CourseId = SCOPE_IDENTITY()
        end
    else 
        begin
            update Course
            set
            CourseType = @CourseType,
            CourseSequence = @CourseSequence
        where CourseId = @CourseId
    end
    return @return
end
go
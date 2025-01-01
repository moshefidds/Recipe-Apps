create or alter proc dbo.CourseUpdate(
    @CourseId int output,
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
        end
    else 
        begin
            update Course
            set
            CourseType = @CourseType,
            CourseSequence = @CourseSequence
        where CourseId = @CourseId
    end
    select @CourseId = SCOPE_IDENTITY()
end
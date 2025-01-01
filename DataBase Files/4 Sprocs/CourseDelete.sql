create or alter proc dbo.CourseDelete(
    @CourseId int
)
as 
begin
    declare @return int = 0

    select @CourseId = isnull(@CourseId, 0)

        begin try
            begin tran
                delete mcr
                from MealCourseRecipe mcr
                join MealCourse mc
                on mcr.MealCourseId = mc.MealCourseId
                where mc.CourseId = @CourseId

                delete mc
                from MealCourse mc
                where mc.CourseId = @CourseId

                delete c
                from Course c
                where c.CourseId = @CourseId
            commit
        end try
    
        begin catch
            rollback;
            throw
        end catch

    return @return
end
go
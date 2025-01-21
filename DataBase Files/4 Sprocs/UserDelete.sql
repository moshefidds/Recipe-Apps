create or alter proc dbo.UserDelete(
    @UserId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @UserId = isnull(@UserId, 0)

        begin try
            begin tran
                delete cbr
                from Recipe r
                join CookBookRecipe cbr
                on r.RecipeId = cbr.RecipeId
                join CookBook cb
                on cbr.CookBookId = cb.CookBookId
                join [User] u
                on cb.UserId = u.UserId
                or r.UserId = u.UserId
                where u.UserId = @UserId
    
                delete cb
                from CookBook cb
                join [User] u
                on cb.UserId = u.UserId
                where u.UserId = @UserId
    
                delete mcr
                from MealCourseRecipe mcr
                join Recipe r
                on mcr.RecipeId = r.RecipeId
                join MealCourse mc
                on mcr.MealCourseId = mc.MealCourseId
                join Meal m
                on mc.MealId = m.MealId
                join [User] u
                on r.UserId = u.UserId
                or m.UserId = u.UserId
                where u.UserId = @UserId

                delete mc
                from MealCourse mc
                join Meal m
                on mc.MealId = m.MealId
                join [User] u
                on m.UserId = u.UserId
                where u.UserId = @UserId
     
                delete m
                from Meal m
                join [User] u
                on m.UserId = u.UserId
                where u.UserId = @UserId
    
                delete ri
                from RecipeIngredient ri
                join Recipe r
                on ri.RecipeId = r.RecipeId
                join [User] u
                on r.UserId = u.UserId
                where u.UserId = @UserId
    
                delete rd
                from RecipeDirections rd
                join Recipe r
                on rd.RecipeId = r.RecipeId
                join [User] u
                on r.UserId = u.UserId
                where u.UserId = @UserId
    
                delete r
                from Recipe r
                join [User] u
                on r.UserId = u.UserId
                where u.UserId = @UserId
    
                delete u
                from [User] u
                where u.UserId = @UserId
            commit
        end try
    
        begin catch
            rollback;
            throw
        end catch

    return @return
end
go
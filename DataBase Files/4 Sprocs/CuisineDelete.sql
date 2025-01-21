create or alter proc dbo.CuisineDelete(
    @CuisineId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0
    
    select @CuisineId = isnull(@CuisineId, 0)

        begin try
            begin tran
                delete cbr
                from Recipe r
                join CookBookRecipe cbr
                on r.RecipeId = cbr.RecipeId
                where r.CuisineId = @CuisineId
    
                delete mcr
                from MealCourseRecipe mcr
                join Recipe r
                on mcr.RecipeId = r.RecipeId
                where r.CuisineId = @CuisineId
    
                delete ri
                from RecipeIngredient ri
                join Recipe r
                on ri.RecipeId = r.RecipeId
                where r.CuisineId = @CuisineId
    
                delete rd
                from RecipeDirections rd
                join Recipe r
                on rd.RecipeId = r.RecipeId
                where r.CuisineId = @CuisineId
    
                delete r
                from Recipe r
                where r.CuisineId = @CuisineId
    
                delete c
                from Cuisine c
                where c.CuisineId = @CuisineId
            commit
        end try
    
        begin catch
            rollback;
            throw
        end catch

    return @return
end
go

create or alter procedure RecipeDelete(
    @RecipeId int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    if exists(
        select * 
        from Recipe r 
        where r.RecipeId = @RecipeId 
        and 
        (
            r.RecipeStatus = 'Published'
            or 
            (
                r.RecipeStatus = 'Archived' 
                and 
                datediff(day, r.DateArchived, GetDate()) <= 30
            )
        )
    )
    begin
        select @return = 1, @Message = 'Cannot delete a Recipe when in ''Published'' or ''Archived'' for less then 30 days.'
        goto finished
    end

    begin try
        begin tran
        delete RecipeDirections where RecipeId = @RecipeId
        delete RecipeIngredient where RecipeId = @RecipeId
        delete Recipe where RecipeId = @RecipeId
        commit
    end try
    begin catch
        rollback;
        throw
    end catch

    finished:
    return @return 
end
go
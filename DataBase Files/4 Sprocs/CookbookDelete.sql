create or alter procedure CookbookDelete(
    @CookBookId int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

        begin try
            begin tran
            delete CookBookRecipe where CookBookId = @CookBookId
            delete CookBook where CookBookId = @CookBookId
            commit
        end try
        begin catch
            rollback;
            throw
        end catch

    return @return 
end
go
create or alter proc dbo.CookbookGet(
    @CookbookId int = 0,
    @Message varchar(500) = ''
)
as 
begin
    select @CookbookId = isnull(@CookbookId, 0)

    select cb.CookBookId, cb.CookBookName, u.UserId, u.UserName, cb.DateRecorded, cb.CookBookPrice, cb.CookBookActive
    from CookBook cb
    join [User] u
    on cb.UserId = u.UserId
    where cb.CookBookId = @CookbookId
end
go

--exec CookbookGet @CookbookId = 5
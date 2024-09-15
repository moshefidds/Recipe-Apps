use RecipeDB
go
create or alter procedure dbo.UserGet(@UserId int = 0, @UserName varchar(100) = '', @All bit = 0)
as 
begin
    select @UserName = nullif(@UserName, '')
    select *
    from [User] u
    where u.UserId = @UserId
    or u.UserName like '%' + @UserName + '%'
    or @All = 1
end
go

--exec UserGet

--exec UserGet @All = 1

--exec UserGet @UserName = ''

--exec UserGet @UserName = 'vo'

/*
declare @id int
select top 1 @id = u.UserId from [User] u
exec UserGet @UserId = @id
*/

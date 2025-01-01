create or alter proc dbo.UserUpdate(
    @UserId int output,
    @UserFirstName varchar(50),
    @UserLastName varchar(50),
    @UserName varchar(75),
    @Message varchar(500) = ''
)
as 
begin
    declare @return int = 0

    select @UserId = isnull(@UserId, 0)

    if @UserId = 0
        begin
            insert [User](UserFirstName, UserLastName, UserName)
            values(@UserFirstName, @UserLastName, @UserName)
        end
    else 
        begin
            update [User]
            set
            UserFirstName = @UserFirstName,
            UserLastName = @UserLastName,
            UserName = @UserName
        where UserId = @UserId
    end
    select @UserId = SCOPE_IDENTITY()
end
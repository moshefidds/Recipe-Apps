create or alter proc dbo.CookbookUpdate(
    @CookBookId int = 0 output,
    @UserId int output,
    @CookBookName varchar (100) output,
    @CookBookPrice decimal(5,2) output,
    @CookBookActive bit output,
    @DateRecorded datetime output,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @CookBookId = isnull(@CookBookId, 0), @DateRecorded = nullif(@DateRecorded, 0)

    if @CookBookId = 0
        begin
            if @DateRecorded is null
                begin
                    select @DateRecorded = getdate()
                end
            insert CookBook(UserId, CookBookName, CookBookPrice, CookBookActive, DateRecorded)
            values(@UserId, @CookBookName, @CookBookPrice, @CookBookActive, @DateRecorded)

            select @CookBookId = SCOPE_IDENTITY()
        end
    else 
        begin
            update CookBook
            set
                UserId = @UserId,
                CookBookName = @CookBookName,
                CookBookPrice = @CookBookPrice,
                CookBookActive = @CookBookActive,
                DateRecorded = @DateRecorded
            where CookBookId = @CookBookId
        end
end


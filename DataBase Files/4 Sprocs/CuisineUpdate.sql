create or alter proc dbo.CuisineUpdate(
    @CuisineId int output,
    @CuisineType varchar(75),
    @Message varchar(500) = ''
)
as 
begin
    declare @return int = 0

    select @CuisineId = isnull(@CuisineId, 0)

    if @CuisineId = 0
        begin
            insert Cuisine(CuisineType)
            values(@CuisineType)
        end
    else 
        begin
            update Cuisine
            set
            CuisineType = @CuisineType
        where CuisineId = @CuisineId
    end
    select @CuisineId = SCOPE_IDENTITY()
end
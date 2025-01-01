create or alter proc dbo.RecipeStatusUpdate(
    @RecipeId int output,
    @DateDrafted datetime output,
    @DatePublished datetime output,
    @DateArchived datetime output,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @RecipeId = isnull(@RecipeId, 0)

    if @RecipeId != 0
    begin
        update Recipe 
        set 
            DateDrafted = @DateDrafted, 
            DatePublished = @DatePublished, 
            DateArchived = @DateArchived
        where RecipeId = @RecipeId
    end

    return @return
end
go
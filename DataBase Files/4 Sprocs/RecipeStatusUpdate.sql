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

    select @RecipeId = isnull(@RecipeId, 0)--, @DateArchived = nullif(@DateArchived, ''), @DatePublished = nullif(@DatePublished, '')

    if @RecipeId != 0
    begin
        update Recipe 
        set 
            DateArchived = @DateArchived,
            DatePublished = @DatePublished, 
            DateDrafted = @DateDrafted          
        where RecipeId = @RecipeId
    end

    return @return
end
go
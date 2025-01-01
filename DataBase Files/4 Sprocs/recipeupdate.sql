create or alter proc dbo.RecipeUpdate(
    @RecipeId int output,
    @UserId int,
    @CuisineId int,
    @RecipeName varchar (100),
    @NumOfCalories int,
    @DateDrafted datetime output,
    @DatePublished datetime output,
    @DateArchived datetime output,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @RecipeId = isnull(@RecipeId, 0), @DateDrafted = nullif(@DateDrafted, 0)

    if @RecipeId = 0
    begin
        if @DateDrafted is null
            begin
                select @DateDrafted = getdate()
            end
        insert Recipe(UserId, CuisineId, RecipeName, NumOfCalories, DateDrafted, DatePublished, DateArchived)
        values(@UserId, @CuisineId, @RecipeName, @NumOfCalories, @DateDrafted, @DatePublished, @DateArchived)
        select @RecipeId = SCOPE_IDENTITY()
    end
    else 
    begin
        update Recipe
        set
        UserId = @UserId,
        CuisineId = @CuisineId,
        RecipeName = @RecipeName,
        NumOfCalories = @NumOfCalories,
        DateDrafted = @DateDrafted,
        DatePublished = @DatePublished,
        DateArchived = @DateArchived
    where RecipeId = @RecipeId
    end
end
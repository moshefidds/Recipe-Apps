create or alter proc dbo.RecipeUpdate(
    @RecipeId int  output,
    @UserId int,
    @CuisineId int,
    @RecipeName varchar (100),
    @NumOfCalories int,
    @DateDrafted datetime,
    @DatePublished datetime,
    @DateArchived datetime,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @RecipeId = isnull(@RecipeId, 0)

    if @RecipeId = 0
    begin
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
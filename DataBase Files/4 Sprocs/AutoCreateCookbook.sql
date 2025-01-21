create or alter proc dbo.AutoCreateCookbook(
    @UserId int output,
    @Message varchar(500) = '' output
)
as begin 
    declare @return int = 0
        ;
        with x as(
            select UserName = u.UserName, NumOfRecipes = count(*)
            from Recipe r
            join [User] u
            on r.UserId = u.UserId
            where u.UserId = @UserId
            group by u.UserName
        )
        insert CookBook(UserId, CookBookName, CookBookPrice, CookBookActive, DateRecorded)
        select u.UserId, concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName), x.NumOfRecipes * 1.33, 1, getdate()
        from [User] u
        join x
        on u.UserName = x.UserName

        ;
        with x as(
            select CookBookName = concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName), RecipeId = r.RecipeId, CookBookRecipeSequence = row_number() over (order by RecipeName)
            from [User] u
            join Recipe r
            on u.UserId = r.UserId
            where u.UserId = @UserId
        )
        insert CookBookRecipe(CookBookId, RecipeId, CookBookRecipeSequence)
        select cb.CookBookId, x.RecipeId, x.CookBookRecipeSequence
        from x
        join CookBook cb
        on x.CookBookName = cb.CookBookName

    return @return
end
go 

--exec AutoCreateCookbook @UserId = 6
--select * from CookBook cb where cb.UserId = 6
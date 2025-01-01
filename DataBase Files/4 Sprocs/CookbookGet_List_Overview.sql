create or alter proc dbo.CookbookGet_List_Overview(
    @Meassage varchar(500) = '' output
)
as
begin
    declare @return int = 0
        select cb.CookBookId, cb.CookBookName, u.UserName, NumOfRecipes = count(*), cb.CookBookPrice
        from CookBook cb
        join [User] u
        on cb.UserId = u.UserId
        left join CookBookRecipe cbr
        on cb.CookBookId = cbr.CookBookId
        group by cb.CookBookId, cb.CookBookName, u.UserName, cb.CookBookPrice
        order by cb.CookBookName
return @return
end 
go

exec CookbookGet_List_Overview

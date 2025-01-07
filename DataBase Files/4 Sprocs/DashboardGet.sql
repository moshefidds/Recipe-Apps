create or alter proc dbo.DashboardGet(
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
        select Type = 'Recipes', [Number] = count(*) from Recipe r
        union select 'Meals', count(*) from Meal m
        union select 'Cookbooks', count(*) from CookBook c
        order by Type desc
    return @return
end 
go

--exec DashboardGet
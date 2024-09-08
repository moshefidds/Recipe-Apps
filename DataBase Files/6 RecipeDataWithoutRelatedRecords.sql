use RecipeDB
go

drop table if exists CookBookRecipe
drop table if exists CookBook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Course
drop table if exists Meal
drop table if exists RecipeDirections
drop table if exists RecipeIngredient
drop table if exists Measurement
drop table if exists Ingredient
drop table if exists Recipe
drop table if exists Cuisine
drop table if exists [User]
go

create table dbo.[User](
    UserId int not null identity primary key,
    UserFirstName varchar(50) not null 
        constraint c_User_UserFirstName_cannot_be_blank check(UserFirstName <> ''), 
    UserLastName varchar(50) not null
        constraint c_User_UserLastName_cannot_be_blank check(UserLastName <> ''), 
    UserName varchar(75) not null
        constraint c_User_UserName_cannot_be_blank check(UserName <> '')
        constraint u_User_UserName unique
)
go

create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineType varchar(50) not null
        constraint c_Cuisine_CuisineType_cannot_be_blank check(CuisineType <> '')
        constraint u_Cuisine_CuisineType unique
)
go

create table dbo.Recipe(
    RecipeId int not null identity primary key,
    UserId int not null constraint f_User_Recipe foreign key references [User](UserId),
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    RecipeName varchar(100) not null
        constraint c_Recipe_RecipeName_cannot_be_blank check(RecipeName <> '')
        constraint u_Recipe_RecipeName unique,
    NumOfCalories int not null
        constraint c_Recipe_NumOfCalories_cannot_be_negative_or_zero check(NumOfCalories > 0),
    DateDrafted	datetime not null 
        constraint d_Recipe_DateDrafted default getdate(),
    DatePublished datetime null,
    DateArchived datetime null
        constraint C_Recipe_DateArchived_cannot_be_after_the_current_date check(DateArchived <= getdate()),
    RecipeStatus as case 
                        when DatePublished is null and DateArchived is null then 'Drafted'
                        when DateArchived is not null then 'Archived'
                        else 'Published'
                    end persisted,
    constraint C_Recipe_DateDrafted_cannot_be_after_DatePublished_or_DateArchived_or_the_current_date check(DateDrafted <= isnull(DatePublished, getdate()) and DateDrafted <= isnull(DateArchived, getdate())),
    constraint C_Recipe_DatePublished_cannot_be_after_DateArchived_or_the_current_date check(DatePublished <= isnull(DateArchived, getdate())),
)
go

insert [User](UserFirstName, UserLastName, UserName)
select UserFirstName = 'Art', UserLastName = 'Smith', UserName = 'ASmith1234;-)'
union select 'Bobby', 'Flay', 'BFlay4321((*))'
union select 'Guy', 'Fieri', 'GuyFieri987654321.|.'
union select 'Rachel', 'Voice', 'Voice.com'
go


insert Cuisine(CuisineType)
select CuisineType = 'Chinese'
union select 'Thai'
union select 'Italian'
union select 'American'
union select 'Mediterranean'
union select 'French'
union select 'English'   
go


;
with x as(
   select UserName = 'ASmith1234;-)', CuisineType = 'American', RecipeName = 'Chocolate Chip Cookies', NumOfCalories = 230, DateDrafted = '2020-03-17 12:41:21.113' , DatePublished = '2023-03-17 12:41:21.113' , DateArchived = null 
   union select 'ASmith1234;-)', 'French', 'Apple Yogurt Smoothie', 15, '2002-01-17 12:41:21.113', null, null
   union select 'BFlay4321((*))', 'English', 'Cheese Bread', 140, '2001-03-17 12:41:21.113', null, null
   union select 'BFlay4321((*))', 'American', 'Butter Muffins', 60, '2010-03-17 12:41:21.113', '2012-03-17 12:41:21.113', null
   union select 'BFlay4321((*))', 'Thai', 'Fish The Thai', 200, '1986-03-17 12:41:21.113', '2000-03-17 12:41:21.113', null
   union select 'Voice.com', 'Italian', 'Rustic Italian Pizza Wraps', 90, '2024-03-17 01:41:21.113', '2024-03-17 03:25:21.113', null
   union select 'Voice.com', 'Italian', '3D Italian Pizza', 1060, '2017-03-17 12:41:21.113', null, '2020-05-17 12:41:21.113'
   union select 'Voice.com', 'Mediterranean', 'Roasted Beef Taccos', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'
)
insert Recipe(UserId, CuisineId, RecipeName, NumOfCalories, DateDrafted, DatePublished, DateArchived)
select u.UserId, c.CuisineId, x.RecipeName, x.NumOfCalories, x.DateDrafted, x.DatePublished, x.DateArchived
from [User] u
join x
on u.UserName = x.UserName
join Cuisine c
on x.CuisineType = c.CuisineType
go

select CuisineId, CuisineType from Cuisine

select *
from Recipe
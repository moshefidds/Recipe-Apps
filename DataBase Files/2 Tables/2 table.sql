--AS Amazing job! 100%
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
        constraint ck_User_UserFirstName_cannot_be_blank check(UserFirstName <> ''), 
    UserLastName varchar(50) not null
        constraint ck_User_UserLastName_cannot_be_blank check(UserLastName <> ''), 
    UserName varchar(75) not null
        constraint ck_User_UserName_cannot_be_blank check(UserName <> '')
        constraint u_User_UserName unique
)
go

create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineType varchar(50) not null
        constraint ck_Cuisine_CuisineType_cannot_be_blank check(CuisineType <> '')
        constraint u_Cuisine_CuisineType unique
)
go

create table dbo.Recipe(
    RecipeId int not null identity primary key,
    UserId int not null constraint f_User_Recipe foreign key references [User](UserId),
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    RecipeName varchar(100) not null
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> '')
        constraint u_Recipe_RecipeName unique,
    NumOfCalories int not null
        constraint ck_Recipe_NumOfCalories_cannot_be_negative_or_zero check(NumOfCalories > 0),
    DateDrafted	datetime not null 
        constraint d_Recipe_DateDrafted default getdate(),
    DatePublished datetime null,
    DateArchived datetime null
        constraint ck_Recipe_DateArchived_cannot_be_after_the_current_date check(DateArchived <= getdate()),
    RecipeStatus as case 
                        when DatePublished is null and DateArchived is null then 'Drafted'
                        when DateArchived is not null then 'Archived'
                        else 'Published'
                    end persisted,
    RecipePictureFile as concat('Recipe_', replace(RecipeName, ' ', '_'), '.jpg'),
    constraint ck_Recipe_DateDrafted_cannot_be_after_DatePublished_or_DateArchived_or_the_current_date check(DateDrafted <= isnull(DatePublished, getdate()) and DateDrafted <= isnull(DateArchived, getdate())),
    constraint ck_Recipe_DatePublished_cannot_be_after_DateArchived_or_the_current_date check(DatePublished <= isnull(DateArchived, getdate())),

    --constraint ck_Recipe_DateDrafted_cannot_be_after_DatePublished_or_DateArchived check(DateDrafted <= DatePublished and DateDrafted <= DateArchived),
    --constraint ck_Recipe_DatePublished_cannot_be_after_DateArchived check(DatePublished <= DateArchived),
)
go

create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(30) not null
        constraint ck_Ingredient_IngredientName_cannot_be_blank check(IngredientName <> '')
        constraint u_Ingredient_IngredientName unique,
    IngredientPictureFile as concat('Ingredient_', replace(IngredientName, ' ', '_'), '.jpg')
)
go

create table dbo.Measurement(
    MeasurementId int not null identity primary key,
    MeasurementType varchar(10) not null
        constraint u_Measurement_MeasurementType unique
)
go

create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    MeasurementId int not null constraint f_Measurement_RecipeIngredient foreign key references Measurement(measurementId),
    MeasurementAmount decimal(3,1) not null
        constraint ck_RecipeIngredient_MeasurementAmount_cannot_be_negative_or_zero check(MeasurementAmount > 0),
    IngredientSequence int not null
        constraint ck_RecipeIngredient_IngredientSequence_cannot_be_negative_or_zero check(IngredientSequence > 0),
    constraint u_RecipeIngredient_RecipeId_IngredientId unique(RecipeId, IngredientId),
    constraint u_RecipeIngredient_RecipeId_IngredientSequence unique(RecipeId, IngredientSequence)
)
go

create table dbo.RecipeDirections(
    RecipeDirectionsId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeDirections foreign key references Recipe(RecipeId),
    RecipeDirection varchar(100) not null
        constraint ck_RecipeDirections_RecipeDirection_cannot_be_blank check(RecipeDirection <> ''),
    RecipeDirectionSequence int not null
        constraint ck_RecipeDirections_RecipeDirectionSequence_cannnot_be_negative_or_zero check(RecipeDirectionSequence > 0),
    constraint u_RecipeDirections_RecipeId_RecipeDirectionSequence unique(RecipeId, RecipeDirectionSequence)
)
go

create table dbo.Meal(
    MealId int not null identity primary key,
    UserId int not null constraint f_User_Meal foreign key references [User](UserId),
    MealName varchar(100) not null
        constraint ck_Meal_MealName_cannot_be_blank check(MealName <> '')
        constraint u_Meal_MealName unique,
    MealActive bit not null, 
    DateRecorded datetime not null 
        constraint d_Meal_DateRecorded default getdate()
        constraint ck_Meal_DateRecorded_cannot_be_recorded_in_the_future check(DateRecorded between '1990-03-17 01:00:00.000' and getdate()),
    MealPictureFile as concat('Meal_', replace(MealName, ' ', '_'), '.jpg')
)
go

create table dbo.Course(
    CourseId	int not null identity primary key,
    CourseType varchar(50) not null
        constraint ck_Course_CourseType_cannot_be_blank check(CourseType <> '')
        constraint u_Course_CourseType unique,
    CourseSequence int not null
        constraint ck_Course_CourseSequence_cannot_be_negative_or_zero check(CourseSequence > 0)
        constraint u_Course_CourseSequence unique
)
go

create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),
    constraint u_MealCourse_MealId_CourseId unique(MealId, CourseId)
)
go

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse (MealCourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    RecipeDish bit not null 
        constraint d_MealCourseRecipe_RecipeDish default 0,
    constraint u_MealCourseRecipe_MealCourseId_RecipeId unique(MealCourseId, RecipeId)
)
go

create table dbo.CookBook(
    CookBookId int not null identity primary key,
    UserId int not null constraint f_User_CookBook foreign key references [User](UserId),
    CookBookName varchar(50) not null 
        constraint ck_CookBook_CookBookName_canot_be_blank check(CookBookName <> '')
        constraint u_CookBook_CookBookName unique,
    CookBookPrice decimal(5,2) not null
        constraint ck_CookBook_CookBookPrice_cannot_negative_or_zero check(CookBookPrice > 0),
    CookBookActive bit not null,
    DateRecorded datetime not null 
        constraint d_CookBook_DateRecorded default getdate()
        constraint ck_CookBook_DateRecorded_cannot_be_recorded_in_the_future check(DateRecorded between '1990-03-17 01:00:00.000' and getdate()),
    CookBookPictureFile as concat('CookBook_', replace(CookBookName, ' ', '_'), '.jpg')
)
go

create table dbo.CookBookRecipe(
    CookBookRecipeId int not null identity primary key,
    CookBookId int not null constraint f_CookBook_CookBookRecipe foreign key references CookBook(CookBookId),
    RecipeId int not null constraint f_Recipe_CookBookRecipe foreign key references Recipe(RecipeId),
    CookBookRecipeSequence int not null
        constraint ck_CookBookRecipe_CookBookRecipeSequence_cannot_be_negative_or_zero check(CookBookRecipeSequence > 0),
    constraint u_CookBookRecipe_CookBookId_RecipeId unique (CookBookId, RecipeId),
    constraint u_CookBookRecipe_cookBookId_CookBookRecipeSequence unique(cookBookId, CookBookRecipeSequence)
) 
go
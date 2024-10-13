/*
[User]
    UserId  pk
    UserFirstName 	varchar(50) not null, not Blank 
    UserLastName 	varchar(50) not null, not Blank 
    UserName 	varchar(75) not null, not Blank, unique


Cuisine
    CuisineId   pk
    CuisineType     varchar(50) not null, not blank, unique


Recipe
    RecipeId 	pk
    UserId 	fk [User](UserId)
    CuisineId 	fk Cuisine(CusineId)
    RecipeName 	varchar(100) not null, not blank, unique
    NumOfCalories 	int not null, not negative or zero
    DateDrafted	datetime not null default getdate()
    DatePublished 	datetime null
    DateArchived 	datetime null
    RecipeStatus	 as case when greater Date then Status
    RecipePictureFile as concat(Recipe_r.Recipe_Name.jpeg)
        c_ DateDrafted <= isnull(DatePublished, getdate()) and DateDrafted <= isnull(DateArchived, getdate())
        c_ DatePublished <= isnull(DateArchived, getdate())
        c_ DateArchived <= getdate()

Ingredient
    IngredientId    pk
    IngredientName	 varchar(30) nut null, not blank,  unique
    IngredientPictureFile as concat(Ingredient_i.Ingredient_Name.jpeg)

Measurement
    MeasurementId   pk
    MeasurementType varchar(10) not null, (allows blank),    unique


RecipeIngredient
    RecipeIngredientId 	pk
    RecipeId 	fk Recipe(RecipeId)
    IngredientId 	fk Ingredient(IngredientId)
    MeasurementId	fk Measurement(MeasurementId)
    MeasurementAmount 	decimal(3,1) not null, not negative or zero 
    IngredientSequence 	 int not null, not negative or zero
        Unique(RecipeId, IngredientId)
        Unique(RecipeId, IngredientSequence)


RecipeDirections
    RecipeDirectionsId 	pk
    RecipeId 	fk Recipe(RecipeId)
    RecipeDirection 	varchar(100) not null, not blank 
    RecipeDirectionSequence 	int not null, not negative or zero
        Unique(RecipeId, RecipeDirectionSteps)


Meal
    MealId      pk
    UserId	fk  [User](UserId)
    MealName 	varchar(100) not null, not blank, unique
    MealActive 	bit not null 
    DateRecorded  	datetime not null default getdate()
        c_ <= getdate()
    MealPictureFile as concat(Meal_m.Meal_Name.jpeg)


Course 
    CourseId	pk
    CourseType varchar(50) not null, not blank, unique
    CourseSequence int not null, not negative or zero, unique


MealCourse
    MealCourseId    pk
    MealId  fk Meal(MealId)
    CourseId    fk Course(CourseId)
        Unique(MealId, CourseId)


MealCourseRecipe
    MealCourseRecipeId  pk
    MealCourseId    fk MealCourse (MealCourseId)
    RecipeId    fk Recipe(RecipeId)
    RecipeDish bit not null, default 0,
        Unique (MealCourseId, RecipeId)


CookBook
    CookBookId 	pk
    UserId	fk  [User](UserId)
    CookBookName 	varchar(50) not null not blank, unique
    CookBookPrice  	decimal(5,2) not null, not negative or zero
    CookBookActive 	bit not null
    DateRecorded  		datetime not null default getdate()
        c_ <= getdate()
    CookBookPictureFile as concat(Cook Book_c.Cook_Book_Name.jpeg)


CookBookRecipe
    CookBookRecipeId 	pk
    CookBookId 	fk CookBook(CookBookId)
    RecipeId 	fk Recipe(RecipeId)
    CookBookRecipeSequence	 int not null, not negative or zero
        Unique (CookBookId, RecipeId)
        Unique(cookBookId, CookBookRecipeSequence)
*/
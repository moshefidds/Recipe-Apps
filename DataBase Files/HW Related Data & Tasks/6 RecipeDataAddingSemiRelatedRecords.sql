use RecipeDB
go


;
with x as(
   select UserName = 'ASmith1234;-)', CuisineType = 'American', RecipeName = 'No Related Records # 1', NumOfCalories = 230, DateDrafted = '2020-03-17 12:41:21.113' , DatePublished = '2023-03-17 12:41:21.113' , DateArchived = null
   union select 'Voice.com', 'Mediterranean', 'No Related Records # 2', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'
   union select 'Voice.com', 'Mediterranean', 'No Related Records # 3', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'
   union select 'Voice.com', 'Mediterranean', 'No Related Records # 4', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'

   union select 'Voice.com', 'Mediterranean', 'No Related MealCourseRecipe #1', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'
   union select 'Voice.com', 'Mediterranean', 'No Related MealCourseRecipe #2', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'

   union select 'Voice.com', 'Mediterranean', 'No Related CookBookRecipe #1', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'
   union select 'Voice.com', 'Mediterranean', 'No Related CookBookRecipe #2', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113' 

   union select 'Voice.com', 'Mediterranean', 'Only Related to RecipeIngredient', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113' 

   union select 'Voice.com', 'Mediterranean', 'Only Related to RecipeDirections', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113' 

   union select 'Voice.com', 'Mediterranean', 'Only Related to MealCourseRecipe', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113' 

    union select 'Voice.com', 'Mediterranean', 'Only Related to CookBookRecipe', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113' 

    union select 'Voice.com', 'Mediterranean', 'Archived Less then 30 days from today ;-)', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2024-09-25 12:41:21.113' 

    union select 'Voice.com', 'Mediterranean', 'Archived More then 30 days from today ;-)', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2024-08-25 12:41:21.113' 

    union select 'Voice.com', 'Mediterranean', 'Still In Drafted', 280, '2016-03-17 01:01:00.113', null, null 

)
insert Recipe(UserId, CuisineId, RecipeName, NumOfCalories, DateDrafted, DatePublished, DateArchived)
select u.UserId, c.CuisineId, x.RecipeName, x.NumOfCalories, x.DateDrafted, x.DatePublished, x.DateArchived
from [User] u
join x
on u.UserName = x.UserName
join Cuisine c
on x.CuisineType = c.CuisineType
go


;
with x as(
   select RecipeName = 'Only Related to RecipeIngredient', IngredientName = 'sugar', MeasurementType = 'cup', MeasurementAmount = 1, IngredientSequence = 1
)
insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmount, IngredientSequence)
select r.RecipeId, i.IngredientId, m.MeasurementId, x.MeasurementAmount, x.IngredientSequence
from Recipe r
join x
on r.RecipeName = x.RecipeName
join Ingredient i
on x.IngredientName = i.IngredientName
join Measurement m
on x.MeasurementType = m.MeasurementType
go

;
with x as(
   select RecipeName = 'Only Related to RecipeDirections', RecipeDirection = 'First combine sugar, oil and eggs in a bowl', RecipeDirectionSequence = 1
   )
insert RecipeDirections(RecipeId, RecipeDirection, RecipeDirectionSequence)
select r.RecipeId, x.RecipeDirection, x.RecipeDirectionSequence
from Recipe r
join x 
on r.RecipeName = x.RecipeName
order by r.RecipeName, x.RecipeDirectionSequence
go
;
with x as(
    select MealName = 'The AI experience', CourseType = 'Main Course', RecipeName = 'No Related CookBookRecipe #1', RecipeDish = 0
    union select 'The AI experience', 'Main Course', 'No Related CookBookRecipe #2', 0
    union select 'The AI experience', 'Main Course', 'Only Related to MealCourseRecipe', 7
    )
insert MealCourseRecipe(MealCourseId, RecipeId, RecipeDish)
select mc.MealCourseId, r.RecipeId, x.RecipeDish
from Meal m
join MealCourse mc
on m.MealId = mc.MealId
join Course c
on mc.CourseId = c.CourseId
join x 
on x.MealName = m.MealName
and x.CourseType = c.CourseType
join Recipe r
on x.RecipeName = r.RecipeName
go

;
with x as(
    select CookBookName = 'Treats for two', RecipeName = 'No Related MealCourseRecipe #1', CookBookRecipeSequence = 5
    union select 'Mrs. Kitchen Mom', 'No Related MealCourseRecipe #2', 5
    union select 'Mrs. Kitchen Mom', 'Only Related to CookBookRecipe', 12
    )
insert CookBookRecipe(CookBookId, RecipeId, CookBookRecipeSequence)
select cb.CookBookId, r.RecipeId, x.CookBookRecipeSequence
from CookBook cb
join x
on cb.CookBookName = x.CookBookName
join Recipe r
on x.RecipeName = r.RecipeName
go
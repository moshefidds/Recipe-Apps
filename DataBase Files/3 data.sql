--AS Great job! 100% 
use RecipeDB
go


delete CookBookRecipe
delete CookBook
delete MealCourseRecipe
delete MealCourse
delete Course
delete Meal
delete RecipeDirections
delete RecipeIngredient
delete Measurement
delete Ingredient
delete Recipe
delete Cuisine
delete [User]
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

   union select 'Voice.com', 'Mediterranean', 'No Related Records # 1', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'
   union select 'Voice.com', 'Mediterranean', 'No Related Records # 2', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'
   union select 'Voice.com', 'Mediterranean', 'No Related Records # 3', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'
   union select 'Voice.com', 'Mediterranean', 'No Related Records # 4', 280, '2016-03-17 01:01:00.113', '2016-03-17 01:01:00.113', '2016-03-17 12:41:21.113'
)
insert Recipe(UserId, CuisineId, RecipeName, NumOfCalories, DateDrafted, DatePublished, DateArchived)
select u.UserId, c.CuisineId, x.RecipeName, x.NumOfCalories, x.DateDrafted, x.DatePublished, x.DateArchived
from [User] u
join x
on u.UserName = x.UserName
join Cuisine c
on x.CuisineType = c.CuisineType
go


insert Ingredient(IngredientName)
select 'sugar'
union select 'egg'
union select 'eggs'
union select 'flour'
union select 'vanilla sugar'
union select 'baking powder'
union select 'baking soda'
union select 'chocolate chips'
union select 'granny smith apples'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'club bread'
union select 'butter'
union select 'shredded cheese'
union select 'garlic (crushed)'
union select 'black pepper'
union select 'salt'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream cheese'
union select 'baby salmon'
union select 'lime'
union select 'spicy chilly souce'
union select 'palm sugar'
union select 'oregano'
union select 'whole mozzarella'
union select 'Onion'
union select 'edible ink'
union select 'sweet sauce'
union select 'oil'
union select 'margarine'
union select 'milk'
union select 'salsa'
union select 'whole weat wraps'
union select 'avocado'
union select 'taccos'
union select 'beef'
go


insert Measurement(MeasurementType)
select 'cup'
union select 'cups'
union select 'tsp'
union select 'tbsp'
union select 'oz'
union select 'cloves'
union select 'pinch'
union select 'stick'
union select 'sticks'
union select 'whole'
union select 'pack'
union select 'block'
union select 'bottles'
union select ''
go


;
with x as(
   select RecipeName = 'Chocolate Chip Cookies', IngredientName = 'sugar', MeasurementType = 'cup', MeasurementAmount = 1, IngredientSequence = 1
   union select 'Chocolate Chip Cookies', 'oil', 'cup', 0.5, 2
   union select 'Chocolate Chip Cookies', 'eggs', '', 3, 3
   union select 'Chocolate Chip Cookies', 'flour', 'cups', 2, 4  
   union select 'Chocolate Chip Cookies', 'vanilla sugar', 'tsp', 1, 5
   union select 'Chocolate Chip Cookies', 'baking powder', 'tsp', 2, 6
   union select 'Chocolate Chip Cookies', 'baking soda', 'tsp', 0.5, 7
   union select 'Chocolate Chip Cookies', 'chocolate chips', 'cup', 1, 8

   union select 'Apple Yogurt Smoothie', 'granny smith apples', '', 3, 1
   union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 'cups', 2, 2
   union select 'Apple Yogurt Smoothie', 'sugar', 'tsp', 2, 3
   union select 'Apple Yogurt Smoothie', 'orange juice', 'cup', 0.5, 4
   union select 'Apple Yogurt Smoothie', 'honey', 'tbsp', 2, 5
   union select 'Apple Yogurt Smoothie', 'ice cubes', '', 5, 6

   union select 'Cheese Bread', 'club bread', '', 1, 1
   union select 'Cheese Bread', 'butter', 'oz', 4, 2
   union select 'Cheese Bread', 'shredded cheese', 'oz', 8, 3
   union select 'Cheese Bread', 'garlic (crushed)', 'cloves', 2, 4
   union select 'Cheese Bread', 'black pepper', 'tsp', 0.5, 5
   union select 'Cheese Bread', 'salt', 'pinch', 1, 6

   union select 'Butter Muffins', 'butter', 'stick', 1, 1
   union select 'Butter Muffins', 'sugar', 'cups', 3, 2
   union select 'Butter Muffins', 'vanilla pudding', 'tbsp', 2, 3
   union select 'Butter Muffins', 'eggs', '', 4, 4
   union select 'Butter Muffins', 'whipped cream cheese', 'oz', 8, 5
   union select 'Butter Muffins', 'sour cream cheese', 'oz', 8, 6
   union select 'Butter Muffins', 'flour', 'cup', 1, 7
   union select 'Butter Muffins', 'baking powder', 'tsp', 2, 8

   union select 'Fish The Thai', 'baby salmon', 'whole', 1, 1
   union select 'Fish The Thai', 'lime', '', 3, 2
   union select 'Fish The Thai', 'spicy chilly souce', 'cup', 1.5, 3
   union select 'Fish The Thai', 'palm sugar', 'tbsp', 3, 4

   union select 'Rustic Italian Pizza Wraps', 'whole weat wraps', 'pack', 1, 1
   union select 'Rustic Italian Pizza Wraps', 'avocado', '', 1, 2
   union select 'Rustic Italian Pizza Wraps', 'whole mozzarella', 'block', 1, 3
   union select 'Rustic Italian Pizza Wraps', 'oregano', 'tbsp', 6, 4
   union select 'Rustic Italian Pizza Wraps', 'salsa', 'cups', 1.5, 5
   union select 'Rustic Italian Pizza Wraps', 'milk', 'cup', 1, 6

   union select '3D Italian Pizza', 'palm sugar', 'cups', 2, 1
   union select '3D Italian Pizza', 'oregano', 'tsp', 7, 2
   union select '3D Italian Pizza', 'whole mozzarella', 'cups', 9, 3
   union select '3D Italian Pizza', 'milk', 'block', 1, 4
   union select '3D Italian Pizza', 'edible ink', 'bottles', 56, 5
   union select '3D Italian Pizza', 'sweet sauce', 'tbsp', 2, 6
   union select '3D Italian Pizza', 'margarine', 'sticks', 10, 7  
   union select '3D Italian Pizza', 'salsa', 'pinch', 1, 8
   union select '3D Italian Pizza', 'oil', 'cups', 99.9, 9

   union select 'Roasted Beef Taccos', 'beef', 'pack', 1, 1
   union select 'Roasted Beef Taccos', 'taccos', 'pack', 0.5, 2
   union select 'Roasted Beef Taccos', 'salsa', 'cups', 2, 3
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
   select RecipeName = 'Chocolate Chip Cookies', RecipeDirection = 'First combine sugar, oil and eggs in a bowl', RecipeDirectionSequence = 1
   union select 'Chocolate Chip Cookies', 'mix well', 2
   union select 'Chocolate Chip Cookies', 'add flour, vanilla sugar, baking powder and baking soda', 3
   union select 'Chocolate Chip Cookies', 'beat for 5 minutes', 4
   union select 'Chocolate Chip Cookies', 'add chocolate chips', 5
   union select 'Chocolate Chip Cookies', 'freeze for 1-2 hours', 6
   union select 'Chocolate Chip Cookies', 'roll into balls and place spread out on a cookie sheet', 7
   union select 'Chocolate Chip Cookies', 'bake on 350 for 10 min.', 8  

   union select 'Apple Yogurt Smoothie', 'Peel the apples and dice', 1
   union select 'Apple Yogurt Smoothie', 'Combine all ingredients in bowl except for apples and ice cubes', 2
   union select 'Apple Yogurt Smoothie', 'mix until smooth', 3
   union select 'Apple Yogurt Smoothie', 'add apples and ice cubes', 4
   union select 'Apple Yogurt Smoothie', 'pour into glasses.', 5

   union select 'Cheese Bread', 'Slit bread every 3/4 inch', 1
   union select 'Cheese Bread', 'Combine all ingredients in bowl', 2
   union select 'Cheese Bread', 'fill slits with cheese mixture', 3
   union select 'Cheese Bread', 'wrap bread into a foil and bake for 30 minutes.', 4
                 
   union select 'Butter Muffins', 'Cream butter with sugars', 1
   union select 'Butter Muffins', 'Add eggs and mix well', 2
   union select 'Butter Muffins', 'Slowly add rest of ingredients and mix well', 3
   union select 'Butter Muffins', 'fill muffin pans 3/4 full and bake for 30 minutes.', 4

   union select 'Fish The Thai', 'skin & de-bone the fish', 1
   union select 'Fish The Thai', 'Marinate with diced lime and palm sugar for three weeks', 2
   union select 'Fish The Thai', 'Fry the fish on one side for 10 min.', 3
   union select 'Fish The Thai', 'drizzle the chilly sauce on the raw side', 4    
   union select 'Fish The Thai', 'Enjoy!!!', 5
      
   union select 'Rustic Italian Pizza Wraps', 'mix the salsa, milk & oregano in a bowl', 1
   union select 'Rustic Italian Pizza Wraps', 'cook for 15 min.', 2
   union select 'Rustic Italian Pizza Wraps', 'spread sauce on wraps and add the remaining ingredients', 3
   union select 'Rustic Italian Pizza Wraps', 'bake on 450 for 8 min.', 4                        
                          
   union select 'Roasted Beef Taccos', 'damp the taccos and let sit for 5 min.', 1
   union select 'Roasted Beef Taccos', 'add the Beef', 2
   union select 'Roasted Beef Taccos', 'sprinkle the salsa', 3
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
   select UserName = 'GuyFieri987654321.|.', MealName = 'Breakfast bash', MealActive = 1, DateRecrded = '2000-03-17 12:41:21.313'
   union select 'Voice.com', 'Monday Night', 1, '2018-03-17 12:41:21.113'
   union select 'GuyFieri987654321.|.', 'Coolest Eat_a_Meal', 1, '2022-03-17 13:41:21.113'
   union select 'GuyFieri987654321.|.', 'The AI experience', 0, '2024-03-31 12:41:21.113'
)
insert Meal(UserId, MealName, MealActive, DateRecorded)
select u.UserId, x.MealName, x.MealActive, x.DateRecrded
from [User] u
join x
on u.UserName = x.UserName
go


insert Course(CourseType, CourseSequence)
select 'Appetizer', 1
union select 'Entree', 2
union select 'Main Course', 3
union select 'Palate Quencher', 4
union select 'Desert', 5
go


;
with x as(
   select MealName = 'Breakfast bash', CourseType = 'Appetizer'
   union select 'Breakfast bash', 'Main Course'
   
   union select 'Monday Night', 'Appetizer'
   union select 'Monday Night', 'Entree'
   union select 'Monday Night', 'Main Course'
   union select 'Monday Night', 'Palate Quencher'
   union select 'Monday Night', 'Desert'

   union select 'Coolest Eat_a_Meal', 'Main Course'
   union select 'Coolest Eat_a_Meal', 'Desert'

   union select 'The AI experience', 'Main Course'
   union select 'The AI experience', 'Palate Quencher'
)
insert MealCourse(MealId, CourseId)
select m.MealId, c.CourseId
from Meal m
join x
on m.MealName = x.MealName
join Course c
on x.CourseType = c.CourseType
go


;
with x as(
   select MealName = 'Breakfast bash', CourseType = 'Appetizer', RecipeName = 'Apple Yogurt Smoothie', RecipeDish = 0
   union select 'Breakfast bash', 'Main Course', 'Cheese Bread', 1
   union select 'Breakfast bash', 'Main Course', 'Butter Muffins', 0

   union select 'Monday Night', 'Appetizer', 'Roasted Beef Taccos', 1
   union select 'Monday Night', 'Appetizer', 'Cheese Bread', 0
   union select 'Monday Night', 'Entree', 'Rustic Italian Pizza Wraps', 0
   union select 'Monday Night', 'Main Course', 'Apple Yogurt Smoothie', 0
   union select 'Monday Night', 'Main Course', 'Butter Muffins', 0
   union select 'Monday Night', 'Main Course', 'Fish The Thai', 1
   union select 'Monday Night', 'Palate Quencher', 'Chocolate Chip Cookies', 0

   union select 'Coolest Eat_a_Meal', 'Main Course', 'Fish The Thai', 1
   union select 'Coolest Eat_a_Meal', 'Main Course', 'Rustic Italian Pizza Wraps', 0
   union select 'Coolest Eat_a_Meal', 'Desert', 'Butter Muffins', 0

   union select 'The AI experience', 'Main Course', '3D Italian Pizza', 1
   union select 'The AI experience', 'Main Course', 'Chocolate Chip Cookies', 0
   union select 'The AI experience', 'Palate Quencher', 'Chocolate Chip Cookies', 0
   union select 'The AI experience', 'Palate Quencher', 'Cheese Bread', 0
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
   select UserName = 'ASmith1234;-)', CookBookName = 'Treats for two', Price = 32.69, CookBookActive = 1, DateRecorded = '2024-03-31 12:41:21.113'
   union select 'BFlay4321((*))', 'Chef''s Secrets', 100.99, 1, '2014-03-31 12:41:21.113'
   union select 'BFlay4321((*))', 'Gandma''s Dream', 2.99, 1, '1995-03-31 12:41:21.113'
   union select 'BFlay4321((*))', 'Mrs. Kitchen Mom', 56.32, 0, '2016-03-31 12:41:21.113'
)
insert CookBook(UserId, CookBookName, CookBookPrice, CookBookActive, DateRecorded)
select u.UserId, x.CookBookName, x.Price, x.CookBookActive, x.DateRecorded
from [User] u
join x
on u.UserName = x.UserName
go


;
with x as(
   select CookBookName = 'Treats for two', RecipeName = 'Chocolate Chip Cookies', CookBookRecipeSequence = 1
   union select 'Treats for two', 'Apple Yogurt Smoothie', 2
   union select 'Treats for two', 'Cheese Bread', 3
   union select 'Treats for two', 'Butter Muffins', 4

   union select 'Chef''s Secrets', '3D Italian Pizza', 1
   union select 'Chef''s Secrets', 'Fish The Thai', 2
   union select 'Chef''s Secrets', 'Roasted Beef Taccos', 3
   union select 'Chef''s Secrets', 'Rustic Italian Pizza Wraps', 4

   union select 'Gandma''s Dream', 'Chocolate Chip Cookies', 1
   union select 'Gandma''s Dream', 'Apple Yogurt Smoothie', 2
   union select 'Gandma''s Dream', 'Fish The Thai', 3

   union select 'Mrs. Kitchen Mom', 'Fish The Thai', 1
   union select 'Mrs. Kitchen Mom', 'Cheese Bread', 2
)
insert CookBookRecipe(CookBookId, RecipeId, CookBookRecipeSequence)
select cb.CookBookId, r.RecipeId, x.CookBookRecipeSequence
from CookBook cb
join x
on cb.CookBookName = x.CookBookName
join Recipe r
on x.RecipeName = r.RecipeName
go
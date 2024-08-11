use RecipeDB
go

delete rd
from RecipeDirections rd
join Recipe r
on rd.RecipeId = r.RecipeId
where r.RecipeName = 'Penne a la Vodka'
go

delete ri
from RecipeIngredient ri
join Recipe r 
on ri.RecipeId = r.RecipeId
where r.RecipeName = 'Penne a la Vodka'
go

delete i
from Ingredient i
where i.IngredientName in ('Vodka Sauce', 'Vegetable cream cheese')
go

delete r
from Recipe r
where r.RecipeName = 'Penne a la Vodka'
go


-- Recipe
;
with x as(
    select UserName = 'ASmith1234;-)', CuisineType = 'American', RecipeName = 'Penne a la Vodka', NumOfCalories = 29, DateDrafted = getdate() , DatePublished = null, DateArchived = null 
)
insert Recipe(UserId, CuisineId, RecipeName, NumOfCalories, DateDrafted, DatePublished, DateArchived)
select u.UserId, c.CuisineId, x.RecipeName, x.NumOfCalories, x.DateDrafted, x.DatePublished, x.DateArchived
from [User] u
join x
on u.UserName = x.UserName
join Cuisine c
on x.CuisineType = c.CuisineType
go


-- Additional ingredients
insert Ingredient(IngredientName)
select 'Vodka Sauce'
union select 'Vegetable cream cheese'
go


-- RecipeIngredient
;
with x as(
    select RecipeName = 'Penne a la Vodka', IngredientName = 'Onion', MeasurementType = '', MeasurementAmount = 1, IngredientSequence = 1
    union select 'Penne a la Vodka', 'Vodka Sauce', 'cup', 1, 2
    union select 'Penne a la Vodka', 'Vegetable cream cheese', '', 1, 3
    union select 'Penne a la Vodka', 'milk','cup', 1, 4
    union select 'Penne a la Vodka', 'salt', 'tsp', 3, 5
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


-- RecipeDirection
;
with x as(
   select RecipeName = 'Penne a la Vodka', RecipeDirection = 'Saute onion on a low flame for 35 min', RecipeDirectionSequence = 1
union select 'Penne a la Vodka', 'Add rest of ingredients and bring to a boil', 2
union select 'Penne a la Vodka', 'mix well with pasta', 3
union select 'Penne a la Vodka', 'enjoy ;)', 4
)
insert RecipeDirections(RecipeId, RecipeDirection, RecipeDirectionSequence)
select r.RecipeId, x.RecipeDirection, x.RecipeDirectionSequence
from Recipe r
join x 
on r.RecipeName = x.RecipeName
order by r.RecipeName, x.RecipeDirectionSequence
go


-- select RecipeIngredient
select r.RecipeName, RecipeIngredient = replace(concat(ri.MeasurementAmount, ' ', m.MeasurementType, ' ', i.IngredientName), '.0', '')
from Ingredient i
join RecipeIngredient ri
on i.IngredientId = ri.IngredientId
join Measurement m
on ri.MeasurementId = m.MeasurementId
join Recipe r
on ri.RecipeId = r.RecipeId
where r.RecipeName = 'Penne a la Vodka'
go


-- select RecipeDirection
select r.RecipeName, rd.RecipeDirection
from Recipe r
join RecipeDirections rd
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Penne a la Vodka'
order by rd.RecipeDirectionSequence
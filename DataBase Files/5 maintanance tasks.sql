--AS Fantastic job! 100%
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
delete cbr
--select *
from Recipe r
join CookBookRecipe cbr
on r.RecipeId = cbr.RecipeId
join CookBook cb
on cbr.CookBookId = cb.CookBookId
join [User] u
on cb.UserId = u.UserId
or r.UserId = u.UserId
where u.UserName = 'ASmith1234;-)'
go
delete cb
--select *
from CookBook cb
join [User] u
on cb.UserId = u.UserId
where u.UserName = 'ASmith1234;-)'
go
delete mcr
--select *
from MealCourseRecipe mcr
join Recipe r
on mcr.RecipeId = r.RecipeId
join [User] u
on r.UserId = u.UserId
where u.UserName = 'ASmith1234;-)'
go
delete m
--select *
from Meal m
join [User] u
on m.UserId = u.UserId
where u.UserName = 'ASmith1234;-)'
go
delete ri
--select *
from RecipeIngredient ri
join Recipe r
on ri.RecipeId = r.RecipeId
join [User] u
on r.UserId = u.UserId
where u.UserName = 'ASmith1234;-)'
go
delete rd
--select *
from RecipeDirections rd
join Recipe r
on rd.RecipeId = r.RecipeId
join [User] u
on r.UserId = u.UserId
where u.UserName = 'ASmith1234;-)'
go
delete r
--select *
from Recipe r
join [User] u
on r.UserId = u.UserId
where u.UserName = 'ASmith1234;-)'
go
delete u
--select *
from [User] u
where u.UserName = 'ASmith1234;-)'
go

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(UserId, CuisineId, RecipeName, NumOfCalories, DateDrafted, DatePublished, DateArchived)
select r.UserId, r.CuisineId, concat(r.RecipeName, ' - clone'), r.NumOfCalories, getdate(), null, null
from Recipe r
where r.RecipeName = 'Rustic Italian Pizza Wraps'
go
;
with x as(
    select RecipeName = concat(r.RecipeName, ' - clone'), IngredientId = ri.IngredientId, MeasurementId = ri.MeasurementId, MeasurementAmount = ri.MeasurementAmount, IngredientSequence = ri.IngredientSequence
    from Recipe r
    join RecipeIngredient ri
    on r.RecipeId = ri.RecipeId
    where r.RecipeName = 'Rustic Italian Pizza Wraps'
)
insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmount, IngredientSequence)
select r.RecipeId, x.IngredientId, x.MeasurementId, x.MeasurementAmount, x.IngredientSequence
from x
join Recipe r
on x.RecipeName = r.RecipeName
go
;
with x as(
    select RecipeName = concat(r.RecipeName, ' - clone'), RecipeDirection = rd.RecipeDirection , RecipeDirectionSequence = rd.RecipeDirectionSequence
    from Recipe r
    join RecipeDirections rd
    on r.RecipeId = rd.RecipeId
    where r.RecipeName = 'Rustic Italian Pizza Wraps'
)
insert RecipeDirections(RecipeId, RecipeDirection, RecipeDirectionSequence)
select r.RecipeId, x.RecipeDirection, x.RecipeDirectionSequence
from x
join Recipe r
on x.RecipeName = r.RecipeName
go


/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
;
with x as(
    select UserName = u.UserName, NumOfRecipes = count(*)
    from Recipe r
    join [User] u
    on r.UserId = u.UserId
    where u.UserName = 'ASmith1234;-)'
    group by u.UserName
)
insert CookBook(UserId, CookBookName, CookBookPrice, CookBookActive, DateRecorded)
select u.UserId, concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName), x.NumOfRecipes * 1.33, 1, getdate()
from [User] u
join x
on u.UserName = x.UserName
go

;
with x as(
    select CookBookName = concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName), RecipeId = r.RecipeId, CookBookRecipeSequence = row_number() over (order by RecipeName)
    from [User] u
    join Recipe r
    on u.UserId = r.UserId
    where u.UserName = 'ASmith1234;-)'
)
insert CookBookRecipe(CookBookId, RecipeId, CookBookRecipeSequence)
select cb.CookBookId, x.RecipeId, x.CookBookRecipeSequence
from x
join CookBook cb
on x.CookBookName = cb.CookBookName
go

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r
set r.NumOfCalories = case m.MeasurementType
                        when 'cups' then r.NumOfCalories - (60 * ri.MeasurementAmount)
                        when 'tbsp' then r.NumOfCalories - (15 * ri.MeasurementAmount)
                      end
--select *
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Ingredient i
on ri.IngredientId = i.IngredientId
join Measurement m
on ri.MeasurementId = m.MeasurementId
where i.IngredientName = 'palm sugar'


/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as(
    select AvgHoursToPublish = avg(datediff(hour, r.DateDrafted, r.DatePublished))
    from Recipe r
)
select u.UserFirstName, 
        u.UserLastName, 
        EmailAdress = concat(substring(u.UserFirstName,1,1), u.UserLastName, '@heartyhearth.com'), 
        Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', datediff(hour, r.DateDrafted, getdate()), ' hours. That is ', datediff(hour, r.DateDrafted, getdate()) - x.AvgHoursToPublish, ' hours more than the average ', x.AvgHoursToPublish, ' hours all other recipes took to be published.')
from x
join Recipe r
on datediff(hour, r.DateDrafted, getdate()) > x.AvgHoursToPublish
join [User] u
on r.UserId = u.UserId
where  r.RecipeStatus = 'Drafted'
go


/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select 'Email Body:' =
concat('Order cookbooks from HeartyHearth.com! We have ', count(*), ' books for sale, average price is $', convert(money, avg(cb.CookBookPrice)), '. You can order them all and receive a 25% discount, for a total of ', sum(cb.CookBookPrice) - (sum(cb.CookBookPrice) * .25), '. Click <a href = "www.heartyhearth.com/order/', newid(), '">here</a> to order.')
from CookBook cb
go

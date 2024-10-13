--AS Amazing job! 100%
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select Recipes = count(distinct r.RecipeId), Meals = count(distinct m.MealId), CookBooks = count(distinct cb.CookBookId)
from Recipe r
cross join Meal m
cross join CookBook cb
go

-- old way with union select
select Item = 'Recipes', NumOfItem = count(*)
from Recipe r
union select 'Meals', count(*)
from Meal m
union select 'CookBooks', count(*)
from CookBook cb
go


/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select 
    RecipeName = 
        case r.RecipeStatus
            when 'Published' then r.RecipeName
            when 'Archived' then concat('<span style="color:gray">', r.RecipeName, '</span>')
        end,
    r.RecipeStatus,
    DatePublished = isnull(convert(varchar, r.DatePublished, 101), ''),
    DateArchived = isnull(convert(varchar, r.DateArchived, 101), ''),
    u.UserName,
    r.NumOfCalories,
    NumOfIngredients = count(*)
from Recipe r
join [User] u
on r.UserId = u.UserId
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
where r.RecipeStatus in ('Published', 'Archived')
group by r.RecipeName, r.RecipeStatus, r.DatePublished, r.DateArchived, u.UserName, r.NumOfCalories 
order by r.RecipeStatus desc
go


/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
-- a)
select r.RecipeName, r.NumOfCalories, NumOfIngredients = count(distinct ri.IngredientId), NumOfDirections =  count(distinct rd.RecipeDirectionsId), r.RecipePictureFile
from RecipeIngredient ri
join Recipe r
on ri.RecipeId = r.RecipeId
join RecipeDirections rd
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Fish The Thai'
group by r.RecipeName, r.NumOfCalories, r.RecipePictureFile
go


-- b)
select Ingredients = replace(concat(ri.MeasurementAmount, ' ', m.MeasurementType, ' ', i.IngredientName), '.0','')
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Ingredient i
on ri.IngredientId = i.IngredientId
join Measurement m
on ri.MeasurementId = m.MeasurementId
where r.RecipeName = 'Fish The Thai'
go

-- c)
select RecipeDirections = rd.RecipeDirection
from Recipe r
join RecipeDirections rd
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Fish The Thai'
order by rd.RecipeDirectionSequence
go


/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
;
with x as(
    select 
        MealId = mc.MealId, 
        NumOfCalories = sum(r.NumOfCalories), 
        NumOfRecipes = count(*)
    from MealCourse mc
    join MealCourseRecipe mcr
    on mc.MealCourseId = mcr.MealCourseId
    join Recipe r
    on mcr.RecipeId = r.RecipeId
    group by mc.MealId
)
select 
    m.MealName, 
    u.UserName, 
    x.NumOfCalories, 
    NumOfCourses = count(*),
    x.NumOfRecipes
from x
join Meal m
on x.MealId = m.MealId
join MealCourse mc
on m.MealId = mc.MealId
join [User] u
on m.UserId = u.UserId
where m.MealActive = 1
group by m.MealName, u.UserName, x.NumOfRecipes, x.NumOfCalories
order by m.MealName
go

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
-- a)
select m.MealName, u.UserName, m.DateRecorded, m.MealPictureFile
from meal m
join [User] u
on m.UserId = u.UserId
where m.MealName = 'Monday Night'
go

-- b)
select Recipes = 
                case c.CourseType
                    when 'Main Course' then
                                            case mcr.RecipeDish 
                                                when 1 then concat('<b>', c.CourseType, ': Main dish - ', r.RecipeName, '</b>')
                                                when 0 then concat(c.CourseType, ': Side dish - ', r.RecipeName)
                                            end
                    else concat(c.CourseType, ': ', r.RecipeName)
                end
from Meal m
join MealCourse mc
on m.MealId =mc.MealId
join Course c
on mc.CourseId = c.CourseId
join MealCourseRecipe mcr
on mc.MealCourseId = mcr.MealCourseId
join Recipe r
on mcr.RecipeId = r.RecipeId
where m.MealName = 'Monday Night'
go


/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select cb.CookBookName, u.UserName, NumOfRecipes = count(*)
from CookBook cb
join [User] u
on cb.UserId = u.UserId
join CookBookRecipe cbr
on cb.CookBookId = cbr.CookBookId
where cb.CookBookActive = 1
group by cb.CookBookName, u.UserName
order by cb.CookBookName
go


/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
-- a)
select cb.CookBookName, u.UserName, cb.DateRecorded, cb.CookBookPrice, NumOfRecipes = count(*), cb.CookBookPictureFile
from CookBook cb
join [User] u
on cb.UserId = u.UserId
join CookBookRecipe cbr
on cb.CookBookId = cbr.CookBookId
where cb.CookBookName = 'Chef''s Secrets'
group by cb.CookBookName, u.UserName, cb.DateRecorded, cb.CookBookPrice, cb.CookBookPictureFile
order by cb.CookBookName
go

-- b)
;
with x as(
    select RecipeId = rd.RecipeId, NumOfDirections = count(*)
    from RecipeDirections rd
    group by rd.RecipeId
)
select r.RecipeName, c.CuisineType, NumOfIngredients = count(*), x.NumOfDirections
from CookBook cb
join CookBookRecipe cbr
on cb.CookBookId = cbr.CookBookId
join Recipe r
on cbr.RecipeId = r.RecipeId
join Cuisine c
on r.CuisineId = c.CuisineId
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join x
on r.RecipeId = x.RecipeId
where cb.CookBookName = 'Chef''s Secrets'
group by r.RecipeName, c.CuisineType, cbr.CookBookRecipeSequence, x.NumOfDirections
order by cbr.CookBookRecipeSequence
go


/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
-- a)
select distinct 
    Recipes = concat(upper(left(reverse(r.RecipeName), 1)), lower(substring(reverse(r.RecipeName), 2, len(r.RecipeName) - 1))),
    RecipePictureFile = replace(concat('Recipe_', concat(upper(left(reverse(r.RecipeName), 1)), lower(substring(reverse(r.RecipeName), 2, len(r.RecipeName) - 1))), '.jpg'), ' ', '_')
from CookBook cb 
join CookBookRecipe cbr
on cb.CookBookId = cbr.CookBookId
join Recipe r
on cbr.RecipeId = r.RecipeId
go

-- b)
;
with x as(
    select RecipeId = dr.RecipeId, LastRecipeStep = max(dr.RecipeDirectionSequence)
    from RecipeDirections dr
    group by dr.RecipeId
)
select rd.RecipeDirection
from x
join RecipeDirections rd
on x.RecipeId = rd.RecipeId
and x.LastRecipeStep = rd.RecipeDirectionSequence
go


/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
-- a)
select u.UserName, RecipeStatus = isnull(r.RecipeStatus, ''), NumOfRecipes = count(r.RecipeId)
from [User] u
left join Recipe r
on u.UserId = r.UserId
group by u.UserName, r.RecipeStatus
order by u.UserName
go

-- b)
select u.UserName, NumOfRecipes = count(r.RecipeId), AvgDaysToPublish = isnull(avg(datediff(day, r.DateDrafted, r.DatePublished)), 0)
from [User] u
left join Recipe r
on u.UserId = r.UserId
group by u.UserName
order by u.UserName
go

-- c)For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
      --  Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
select 
    u.UserName, 
    NumOfMeals = count(m.MealId), 
    NumOfActiveMeals =  isnull(sum(convert(int, m.MealActive)), 0),
    NumOfInactiveMeals = count(m.MealId) - isnull(sum(convert(int, m.MealActive)), 0)
from [User] u
left join Meal m
on u.UserId = m.UserId
group by u.UserName
go

-- d)For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
      --  Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
select 
    u.UserName, 
    NumOfCookBooks = count(cb.CookBookId), 
    NumOfActiveCookBooks = isnull(sum(convert(int, cb.CookBookActive)), 0),
    NumOfInactiveCookBooks = count(cb.CookBookId) - isnull(sum(convert(int, cb.CookBookActive)), 0)
from [User] u
left join CookBook cb
on u.UserId = cb.UserId
group by u.UserName
go

-- e)List of archived recipes that were never published, and how long it took for them to be archived.
select r.RecipeName, DaysToArchive = datediff(day, r.DateDrafted, r.DateArchived)
from Recipe r
where r.DatePublished is null
and r.RecipeStatus = 'Archived'
go


/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
-- a)
select Item = 'Recipes', Num = count(r.RecipeId)
from [User] u
left join Recipe r
on u.UserId = r.UserId
where u.UserName = 'Voice.com'
group by u.UserName
union select 'Meals', count(m.MealId)
from [User] u
left join Meal m
on u.UserId = m.UserId
where u.UserName = 'Voice.com'
group by u.UserName
union select 'CookBooks', count(cb.CookBookId)
from [User] u
left join CookBook cb
on u.UserId = cb.UserId
where u.UserName = 'Voice.com'
group by u.UserName
go

-- b)
select 
    r.RecipeName, 
    r.RecipeStatus, 
    HoursInPreviousStatus = case r.RecipeStatus
                                when 'Archived' then datediff(hour, isnull(r.DatePublished, r.DateDrafted), r.DateArchived)
                                when 'Published' then datediff(hour, r.DateDrafted, r.DatePublished)
                            end,
    r.RecipePictureFile
from [User] u
left join Recipe r
on u.UserId = r.UserId
where u.UserName = 'Voice.com'
and r.RecipeStatus <> 'Drafted'
go
/*
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
;
with x as(
        select RecipeId = r.RecipeId, CuisineType = c.CuisineType
    from [User] u
    join Recipe r
    on u.UserId = r.UserId
    join Cuisine c
    on r.CuisineId = c.CuisineId
    where u.UserName = 'Voice.com'
)
select c.CuisineType, NumOfRecipes = count(r.RecipeId)
from Cuisine c
left join x
on c.CuisineType = x.CuisineType
left join Recipe r
on x.RecipeId = r.RecipeId
group by c.CuisineType
go
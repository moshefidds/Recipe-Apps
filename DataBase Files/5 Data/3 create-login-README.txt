script to create login and user is excluded from this repo.
create a file called create-login.sql (this file is ignored by git ignore in this repo)
add the follwing to that file -

-- Create Login in MASTER
create login [login_name] with password = '[password]'

-- switch RecipeDB
create user [user_name] from login [login_name]
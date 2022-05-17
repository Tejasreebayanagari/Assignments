create database cd3
use cd3
Declare @dateofbirth datetime
Declare @presentdatetime datetime
Declare @years varchar(4)
set @dateofbirth = '2000-03-15' --Birthdate
set @presentdatetime = getdate() 
select @years = datediff(year,@dateofbirth,@presentdatetime)
select @years + ' years,' as years
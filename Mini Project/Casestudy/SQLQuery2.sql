create database casestudy
use casestudy
create table Courses
(CId int primary key,CName varchar(20),Cduration int, Cfees float)

insert into Courses values

(100,'Java',35,1000),
(101,'Csharp',60,2000),
(102,'Python',25,3000),
(103,'Azure',28,28000),
(104,'HTML+CSS+JAVA',30,5000),
(105,'DELL BOMMI',30,25000),
(106,'Angular',28,6000),
(107,'AWS',30,22222),
(108,'AI',55,59999),
(109,'c,c++',65,4999)

select * from Courses

create table Students
(StudentId int primary key,SName varchar(20),DOB date)

select * from Students

create table EnrollDetails
(Cid int foreign key references Courses(CId),
 StudId int foreign key references Students(StudentId),Paidfees float,
 EnrollDate date)

 insert into EnrollDetails values(102,3,5000,'5-May-2020'),(102,2,15000,'28-Aug-2019')

 select * from EnrollDetails
create database sqlExam2;
use sqlExam2;
create table Emptble(
Empid int not null,
Name varchar(55),
Salary int,
Deptno int);
insert into Emptble values(1,'teja',5000,10);
insert into Emptble values(2,'sathya',12000,20);
insert into Emptble values(3,'leela',50000,30);
select * from Emptble;

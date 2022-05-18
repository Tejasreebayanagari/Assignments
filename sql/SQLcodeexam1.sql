create database sqlexam1
use sqlexam1
create  table employees
(
empid int not null,
name varchar (222),
salary int,
deptno int identity(10,10),

constrant chk_sal check (salary >= 5000 and salary <=50000)
)
select * from employees

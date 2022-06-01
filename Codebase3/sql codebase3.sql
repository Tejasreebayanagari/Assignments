create database codebaseexam3
use codebaseexam3
create table Code_Emp
 ( 
 eno int primary key, 
ename varchar(50) not null, 
esal numeric(10,2) check(esal >= 25000) , 
etype varchar(1) check(etype in('C','P'))
 ) 

insert into Code_Emp
values(1,'Teja',38500,'P'),
(2,'Sree', 29880,'C'),
(3,'sathya',27232,'C'),
(4,'Purahar',35121,'P')
(5,'Leela',32323,'p')

Select * from Code_Emp

create or alter proc AddEmployee( @empname varchar(50),@empsal numeric(10,2),@emptype varchar(1))
as
begin
declare @empid int =(select max(eno) from Code_Emp)
begin
declare @eid int = @empid + 1;
insert into Code_Emp values(@empid,@empname,@empsal,@emptype)
end
end

execute AddEmployee @empname='Teja',@empsal=38500,@emptype='p'

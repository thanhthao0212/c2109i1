use master
go

drop database if exists c2109i1wf
create database c2109i1wf
go

use c2109i1wf
go

drop table if exists Student
create table Student 
(
	Id int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender bit,
	Dob date
)
go

insert into Student 
(FirstName,LastName,Gender,Dob)
values 
(N'Hồ',N'Thảo',1,'2022/02/12')
go 10 
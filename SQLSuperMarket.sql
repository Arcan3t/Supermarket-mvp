use Supermarker
create table PayMode
(
Pay_Mode_Id int identity (100000,1) primary key,
Pay_Mode_Name nvarchar (50) not null,
Pay_Mode_Observation nvarchar (50) not null,
)
go
insert into PayMode values ('Cash', 'Cash mode')
insert into PayMode values ('Credit Card', 'Credit card mode')

create table Categories
(
Category_Id int identity (100000,1) primary key,
Category_Name nvarchar (50) not null,
Category_Observation nvarchar (50) not null,
)
go
insert into Categories values ('Fruit', 'Fruits')
insert into Categories values ('Meat', 'Meats')
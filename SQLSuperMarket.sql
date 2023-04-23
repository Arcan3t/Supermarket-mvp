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

create table Customers
(
Customer_Id int identity (100000,1) primary key,
Document_Number int not null,
First_Name nvarchar (50) not null,
Last_Name nvarchar (50) not null,
Customer_Address nvarchar (50) not null,
Birthday date,
Phone_Number bigint not null,
Email nvarchar (100) not null,
)
go
insert into Customers values ('1005830812', 'Juan', 'Acosta', 'Cra 46 # 8b - 95', '2001-11-13', '3161993960', 'pabloacosta_999@hotmail.com')
insert into Customers values ('1005830813', 'Pablo', 'Cuero', 'Clle 45 # 7a - 96', '2000-12-12', '3108296322', 'juanpacost@gmail.com')

create table Products
(
Product_Id int identity (100000,1) primary key,
Product_Name nvarchar (50) not null,
Product_Price int not null,
Product_Stock int not null,
Category_Id int not null,
CONSTRAINT fk_Category FOREIGN KEY (Category_Id) REFERENCES Categories (Category_Id)
)
go
insert into Products values ('Apple', '2000', '5', 100000)
insert into Products values ('Cow', '20000', '2', 100001)

create table Providers
(
Provider_Id int identity (100000,1) primary key,
Provider_Name nvarchar (50) not null,
)
go
insert into Providers values ('Fresh Fruits')
insert into Providers values ('ColMeats')
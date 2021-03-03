create Table Brands(
BrandId int identity(1,1) primary key,
Name varchar(255)
)

create Table Colors(
ColorId int identity(1,1) primary key,
Name varchar(255)
)

CREATE TABLE Cars (
CarId int identity(1,1) primary key,
BrandId int,
ColorId int,
ModelYear varchar(255),
DailyPrice money,
Description varchar(255),

Foreign key (BrandId) REFERENCES Brands(BrandId),
Foreign key (ColorId) REFERENCES Colors(ColorId)
)
create table Users (
UserId int identity(1,1) primary key,
FirstName varchar(255),
LastName varchar(255),
Email varchar(255),
Password varchar(255)
)

create table Customers (
CustomerId int identity(1,1) primary key,
UserId int ,
CompanyName varchar(255),

Foreign key (UserId) REFERENCES Users(UserId),
)

create table Rentals (
RentalId int identity(1,1) primary key,
CarId int,
CustomerId int,
RentDate Date,
ReturnDate Date,

Foreign key (CarId) References Cars(CarId),
Foreign key (CustomerId) References Customers(CustomerId)
)

Create table CarImages(
CarImageId int identity(1,1) primary key,
CarId int not null,
ImagePath varchar(255) null,
Date Date null,
Foreign Key (CarId) References Cars(CarId))
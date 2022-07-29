CREATE DATABASE MyShop
GO

USE MyShop

CREATE TABLE Categories
(
    CategoryID INT IDENTITY(1,1),
    CategoryName NVARCHAR(50),
    Description NVARCHAR(MAX),
    
	PRIMARY KEY (CategoryID)
)

CREATE TABLE Suppliers 
(
    SupplierID INT IDENTITY(1,1),
    SupplierName NVARCHAR(50),
    City NVARCHAR(50),
    Country NVARCHAR(50),

	PRIMARY KEY (SupplierID)
)

CREATE TABLE Products
(
    ProductID INT IDENTITY(1,1),
    ProductName NVARCHAR(50),
    SupplierID INT,
    CategoryID INT,
    Price Decimal(9,2),
	
	PRIMARY KEY (ProductID),
	FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID),
	FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryID)
)
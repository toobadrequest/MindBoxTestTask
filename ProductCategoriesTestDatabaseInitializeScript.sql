CREATE TABLE Products (
	Id int IDENTITY(1, 1) PRIMARY KEY, 
	Name nvarchar(50)
)

CREATE TABLE Categories (
	Id int IDENTITY(1, 1) PRIMARY KEY, 
	Name nvarchar(50)
)
GO

CREATE TABLE ProductCategories (
	ProductId int FOREIGN KEY REFERENCES Products(Id),
	CategoryId int FOREIGN KEY REFERENCES Categories(Id),
)
GO 

INSERT INTO Products VALUES 
	('Yogurt'),
	('Bread sticks'),
	('Cucumber');

INSERT INTO Categories VALUES 
	('Milk products'),
	('Sweets'),
	('Grocery');
GO

INSERT INTO ProductCategories VALUES 
	(1, 1),
	(1, 2),
	(2, 2),
	(2, 3)
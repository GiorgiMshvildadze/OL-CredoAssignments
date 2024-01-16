CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(30),
	Price DECIMAL(6,2),
	Stock INT,
	CategoryId INT FOREIGN KEY REFERENCES dbo.Categories(Id)
)

CREATE TABLE Sales(
	Id INT PRIMARY KEY IDENTITY,
	ProductId INT FOREIGN KEY references dbo.Products(Id),
	Quantity INT,
	SaleDate DATETIME
)

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY, 
	Name VARCHAR(20),
	Description VARCHAR(150)
)



SELECT * FROM Categories
SELECT * FROM Products
SELECT * FROM Sales
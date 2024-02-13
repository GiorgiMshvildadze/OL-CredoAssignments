CREATE DATABASE CustomersSql;

CREATE TABLE Customers
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50),
	City VARCHAR(30),
	Country VARCHAR(30)
);

INSERT INTO Customers(Name, City, Country) VALUES ('Alice', 'London','UK'),
												  ('Bob', 'NewYork','USA'),
												  ('Eve', 'Paris','France'),
												  ('Frank', 'Berlin','Germany'),
												  ('Grace', 'Mumbai','India')

SELECT Name FROM Customers WHERE City = 'London' or City = 'Paris'
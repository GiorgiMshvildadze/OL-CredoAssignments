Create Database EmployeesSQL

Create Table Employees
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(40),
	Salary INT,
	Department VARCHAR(30)
);
DROP TABLE Employees




SELECT Department, AVG(Salary) as [Average Salary] FROM dbo.Employees
GROUP BY Department;

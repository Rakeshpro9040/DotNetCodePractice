USE EmployeeDB
GO

SELECT * FROM Employees;
SELECT * FROM [dbo].[__EFMigrationsHistory];

DELETE FROM Employees where Id = 2;
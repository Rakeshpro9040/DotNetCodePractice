/** Create DB **/
/*
CREATE DATABASE Sample;
*/

/** Drop DB **/
/*
USE master
GO

DROP DATABASE Sample
GO
*/

/** Create Tables **/
/*
USE Sample
GO

USE master
GO

Create table Departments
(
     ID int primary key identity,
     Name nvarchar(50),
     Location nvarchar(50)
)

Create table Employees
(
     ID int primary key identity,
     FirstName nvarchar(50),
     LastName nvarchar(50),
     Gender nvarchar(50),
     Salary int,
     DepartmentId int foreign key references Departments(Id)
)
GO

Create table Employees
(
     ID int primary key identity,
     Name nvarchar(50),
     Gender nvarchar(50),
     Salary int
)
GO

Create table Employees
(
EmployeeID int primary key identity,
FirstName nvarchar(50),
LastName nvarchar(50),
Gender nvarchar(50)
)
GO

Create table EmployeeContactDetails
(
EmployeeID int primary key,
foreign key (EmployeeID) references Employees (EmployeeID),
Email nvarchar(50),
Mobile nvarchar(50),
LandLine nvarchar(50)
)
GO

Create table Employees
(
     EmployeeID int primary key identity,
     FirstName nvarchar(50),
     LastName nvarchar(50),
     Gender nvarchar(50),
     Email nvarchar(50),
     Mobile nvarchar(50),
     LandLine nvarchar(50)
)
GO

Create table Employees
(
     EmployeeID int primary key identity,
     FirstName nvarchar(50),
     LastName nvarchar(50),
     Gender nvarchar(50),
     IsTerminated bit not null
)
GO

Create table Employees
(
     EmployeeID int primary key identity,
     EmployeeName nvarchar(50),
     ManagerID int foreign key references Employees(EmployeeID)
)
GO

Create Table Employees
(
     ID int primary key identity,
     FirstName nvarchar(50),
     LastName nvarchar(50),
     Gender nvarchar(50),
     AnuualSalary int,
     HourlyPay int,
     HoursWorked int,
     Discriminator nvarchar(50)
)
GO

Create Table Employees
(
     EmployeeID int primary key identity,
     FirstName nvarchar(50),
     LastName nvarchar(50),
     Gender nvarchar(50),
)
GO

Create Table PermanentEmployees
(
     EmployeeID int foreign key references
     Employees(EmployeeID) not null,
     AnnualSalary int
)
GO

Create Table ContractEmployees
(
     EmployeeID int foreign key references
     Employees(EmployeeID) not null,
     HourlyPay int,
     HoursWorked int
)
GO
*/

/** Drop Tables **/
/*
USE Sample
GO

DROP TABLE Sample.dbo.Employees
DROP TABLE Sample.dbo.Departments
GO

DROP TABLE Sample.dbo.Employees
DROP TABLE Sample.dbo.EmployeeContactDetails
GO
*/


/** Insert Statements **/
/*
USE Sample
GO

Insert into Departments values ('IT', 'New York')
Insert into Departments values ('HR', 'London')
Insert into Departments values ('Payroll', 'Sydney')

Insert into tblEmployees values ('Mark', 'Hastings', 'Male', 60000, 1)
Insert into tblEmployees values ('Steve', 'Pound', 'Male', 45000, 3)
Insert into tblEmployees values ('Ben', 'Hoskins', 'Male', 70000, 1)
Insert into tblEmployees values ('Philip', 'Hastings', 'Male', 45000, 2)
Insert into tblEmployees values ('Mary', 'Lambeth', 'Female', 30000, 2)
Insert into tblEmployees values ('Valarie', 'Vikings', 'Female', 35000, 3)
Insert into tblEmployees values ('John', 'Stanmore', 'Male', 80000, 1)
GO

Insert into tblEmployees values ('Mark', 'Hastings', 'Male', 60000, 1, 'Developer')
Insert into tblEmployees values ('Steve', 'Pound', 'Male', 45000, 3, 'Manager')
Insert into tblEmployees values ('Ben', 'Hoskins', 'Male', 70000, 1, 'Developer')
Insert into tblEmployees values ('Philip', 'Hastings', 'Male', 45000, 2, 'Recruiter')
Insert into tblEmployees values ('Mary', 'Lambeth', 'Female', 30000, 2, 'Recruiter')
Insert into tblEmployees values ('Valarie', 'Vikings', 'Female', 35000, 3, 'Manager')
Insert into tblEmployees values ('John', 'Stanmore', 'Male', 80000, 1, 'Developer')
GO

Insert into Employees values ('Mark', 'Male', 60000)
Insert into Employees values ('Steve', 'Male', 45000)
Insert into Employees values ('Philip', 'Male', 45000)
Insert into Employees values ('Mary', 'Female', 30000)
Insert into Employees values ('Valarie', 'Female', 35000)
Insert into Employees values ('John', 'Male', 80000)
GO

Insert into Employees values ('Mark', 'Hastings', 'Male')
Insert into Employees values ('Steve', 'Pound', 'Male')
Insert into Employees values ('Philip', 'Hastings', 'Male')
Insert into Employees values ('Mary', 'Lambeth', 'Female')
GO

Insert into EmployeeContactDetails values
(1, 'Mark@pragimtech.com', '111111111', '111111111')
Insert into EmployeeContactDetails values
(2, 'Steve@pragimtech.com', '2222222222', '2222222222')
Insert into EmployeeContactDetails values
(3, 'Ben@pragimtech.com', '3333333333', '3333333333')
Insert into EmployeeContactDetails values
(4, 'Philip@pragimtech.com', '44444444444', '44444444444')
GO

Insert into Employees values ('Mark', 'Hastings', 'Male', 'x@x.com', 'XXX', 'XXX')
Insert into Employees values ('Steve', 'Pound', 'Male', 'y@y.com', 'YYY', 'YYY')
Insert into Employees values ('Ben', 'Hoskins', 'Male', 'z@z.com', 'ZZZ', 'ZZZ')
Insert into Employees values ('Philip', 'Hastings', 'Male', 'a@a.com', 'AAA', 'AAA')
Insert into Employees values ('Mary', 'Lambeth', 'Female', 'b@b.com', 'BBB', 'BBB')
GO

Insert into Employees values ('Mark', 'Hastings', 'Male', 0)
Insert into Employees values ('Steve', 'Pound', 'Male', 0)
Insert into Employees values ('Ben', 'Hoskins', 'Male', 0)
Insert into Employees values ('Philip', 'Hastings', 'Male', 1)
Insert into Employees values ('Mary', 'Lambeth', 'Female', 0)
Insert into Employees values ('Valarie', 'Vikings', 'Female', 0)
Insert into Employees values ('John', 'Stanmore', 'Male', 1)
GO

Insert into Employees values ('John', NULL)
Insert into Employees values ('Mark', NULL)
Insert into Employees values ('Steve', NULL)
Insert into Employees values ('Tom', NULL)
Insert into Employees values ('Lara', NULL)
Insert into Employees values ('Simon', NULL)
Insert into Employees values ('David', NULL)
Insert into Employees values ('Ben', NULL)
Insert into Employees values ('Stacy', NULL)
Insert into Employees values ('Sam', NULL)
GO

Update Employees Set ManagerID = 8 Where EmployeeName IN ('Mark', 'Steve', 'Lara')
Update Employees Set ManagerID = 2 Where EmployeeName IN ('Stacy', 'Simon')
Update Employees Set ManagerID = 3 Where EmployeeName IN ('Tom')
Update Employees Set ManagerID = 5 Where EmployeeName IN ('John', 'Sam')
Update Employees Set ManagerID = 4 Where EmployeeName IN ('David')
GO

Insert into Employees values
('Mark', 'Hastings', 'Male', 60000, NULL, NULL, 'PermanentEmployee')
Insert into Employees values
('Steve', 'Pound', 'Male', NULL, 50, 160, 'ContractEmployee')
Insert into Employees values
('Ben', 'Hoskins', 'Male', NULL, 40, 120, 'ContractEmployee')
Insert into Employees values
('Philip', 'Hastings', 'Male', 45000, NULL, NULL, 'PermanentEmployee')
Insert into Employees values
('Mary', 'Lambeth', 'Female', 30000, NULL, NULL, 'PermanentEmployee')
Insert into Employees values
('Valarie', 'Vikings', 'Female', NULL, 30, 140, 'ContractEmployee')
Insert into Employees values
('John', 'Stanmore', 'Male', 80000, NULL, NULL, 'PermanentEmployee')
GO

-- Employees Table Insert
Insert into Employees values ('Mark', 'Hastings', 'Male')
Insert into Employees values ('Steve', 'Pound', 'Male')
Insert into Employees values ('Ben', 'Hoskins', 'Male')
Insert into Employees values ('Philip', 'Hastings', 'Male')
Insert into Employees values ('Mary', 'Lambeth', 'Female')
Insert into Employees values ('Valarie', 'Vikings', 'Female')
Insert into Employees values ('John', 'Stanmore', 'Male')
GO

-- PermanentEmployees Table Insert
Insert into PermanentEmployees values (1, 60000)
Insert into PermanentEmployees values (3, 45000)
Insert into PermanentEmployees values (4, 30000)
Insert into PermanentEmployees values (7, 80000)
GO

-- ContractEmployees Table Insert
Insert into ContractEmployees values (2, 50, 160)
Insert into ContractEmployees values (5, 40, 120)
Insert into ContractEmployees values (6, 30, 140)
GO
*/

/** Query Tables **/
USE tempdb
GO

USE Sample
GO

SELECT * FROM Employees;
SELECT * FROM PermanentEmployees;
SELECT * FROM ContractEmployees;
SELECT * FROM Employees;
SELECT * FROM EmployeeContactDetails;
SELECT * FROM Departments;

-- EF Model Check
SELECT * FROM dbo.__MigrationHistory;

SELECT IDENT_CURRENT('Employees')
SELECT @@IDENTITY

/** SP **/
-- To view sp bodt text
USE Students
GO

sp_helptext Employee_Update;

-- Create Insert, Update and Delete stored procedures for Employees
USE Sample
Go 

Create or alter procedure InsertEmployee
@Name nvarchar(50),
@Gender nvarchar(50),
@Salary int
as
Begin
     Insert into Employees values (@Name, @Gender, @Salary)   
End
Go

Create procedure UpdateEmployee
@ID int,
@Name nvarchar(50),
@Gender nvarchar(50),
@Salary int
as
Begin
     Update Employees Set Name = @Name, Gender = @Gender,
     Salary = @Salary
     where ID = @ID
End
Go

Create procedure DeleteEmployee
@ID int
as
Begin
     Delete from Employees where ID = @ID
End
Go

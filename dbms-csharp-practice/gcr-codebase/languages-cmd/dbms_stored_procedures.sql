
CREATE DATABASE CompanyDB;
GO

USE CompanyDB;
GO

CREATE TABLE Departments (
    DepartmentID INT IDENTITY PRIMARY KEY,
    DepartmentName VARCHAR(50)
);

CREATE TABLE Employees (
    EmployeeID INT IDENTITY PRIMARY KEY,
    Name VARCHAR(100),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    Email VARCHAR(100),
    CONSTRAINT FK_Dept FOREIGN KEY (DepartmentID)
        REFERENCES Departments(DepartmentID)
);

INSERT INTO Departments VALUES ('IT'),('HR'),('Sales');

INSERT INTO Employees VALUES
('Alice',1,50000,'alice@mail.com'),
('Bob',2,40000,'bob@mail.com'),
('Carol',1,60000,'carol@mail.com');

CREATE PROCEDURE sp_AddEmployee
    @Name VARCHAR(100),
    @DeptId INT,
    @Salary DECIMAL(10,2),
    @Email VARCHAR(100)
AS
BEGIN
    INSERT INTO Employees(Name,DepartmentID,Salary,Email)
    VALUES (@Name,@DeptId,@Salary,@Email);
END;
GO

CREATE PROCEDURE sp_UpdateSalary
    @EmpId INT,
    @NewSalary DECIMAL(10,2)
AS
BEGIN
    UPDATE Employees SET Salary=@NewSalary WHERE EmployeeID=@EmpId;
END;
GO

CREATE PROCEDURE sp_DeleteEmployee
    @EmpId INT
AS
BEGIN
    DELETE FROM Employees WHERE EmployeeID=@EmpId;
END;
GO

CREATE PROCEDURE sp_GetEmployeeById
    @EmpId INT
AS
BEGIN
    SELECT e.EmployeeID,e.Name,d.DepartmentName,e.Salary,e.Email
    FROM Employees e
    JOIN Departments d ON e.DepartmentID=d.DepartmentID
    WHERE e.EmployeeID=@EmpId;
END;
GO

CREATE PROCEDURE sp_GetAllEmployees
AS
BEGIN
    SELECT e.EmployeeID,e.Name,d.DepartmentName,e.Salary
    FROM Employees e
    JOIN Departments d ON e.DepartmentID=d.DepartmentID;
END;
GO

CREATE PROCEDURE sp_DepartmentSalarySummary
AS
BEGIN
    SELECT d.DepartmentName,
           COUNT(*) AS TotalEmployees,
           SUM(e.Salary) AS TotalSalary,
           AVG(e.Salary) AS AverageSalary
    FROM Employees e
    JOIN Departments d ON e.DepartmentID=d.DepartmentID
    GROUP BY d.DepartmentName;
END;
GO

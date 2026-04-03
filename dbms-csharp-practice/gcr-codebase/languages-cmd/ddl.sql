
-- DATABASE
CREATE DATABASE TrainingDB;
GO
ALTER DATABASE TrainingDB SET RECOVERY SIMPLE;
GO
USE TrainingDB;
GO

-- TABLES
CREATE TABLE Departments (
    DepartmentID INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName VARCHAR(50) NOT NULL,
    Location VARCHAR(50)
);

CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    DepartmentID INT,
    Salary DECIMAL(10,2) CHECK (Salary > 0),
    Email VARCHAR(100) UNIQUE,
    Phone VARCHAR(10),
    CreatedAt DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Department FOREIGN KEY (DepartmentID)
        REFERENCES Departments(DepartmentID)
);

-- ALTER
ALTER TABLE Employees ADD Gender CHAR(1);
ALTER TABLE Employees ALTER COLUMN Name VARCHAR(150);

-- INDEX
CREATE INDEX IDX_Employees_Department ON Employees(DepartmentID);

-- VIEW
CREATE VIEW View_EmployeeDetails AS
SELECT e.EmployeeID, e.Name, d.DepartmentName, e.Salary
FROM Employees e
JOIN Departments d ON e.DepartmentID = d.DepartmentID;

-- DROP
DROP VIEW View_EmployeeDetails;

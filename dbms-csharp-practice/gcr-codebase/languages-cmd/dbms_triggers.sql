
CREATE DATABASE TriggerDB;
GO
USE TriggerDB;
GO

-- MAIN TABLE
CREATE TABLE Employees (
    EmployeeID INT IDENTITY PRIMARY KEY,
    Name VARCHAR(100),
    Department VARCHAR(50),
    Salary DECIMAL(10,2),
    Status VARCHAR(20) DEFAULT 'ACTIVE'
);

-- AUDIT TABLE
CREATE TABLE EmployeeAudit (
    AuditID INT IDENTITY PRIMARY KEY,
    EmployeeID INT,
    ActionType VARCHAR(30),
    OldSalary DECIMAL(10,2),
    NewSalary DECIMAL(10,2),
    OldDepartment VARCHAR(50),
    NewDepartment VARCHAR(50),
    ActionDate DATETIME DEFAULT GETDATE(),
    ActionUser VARCHAR(100)
);

-------------------------------------------------
-- INSERT TRIGGER
-------------------------------------------------
CREATE TRIGGER trg_Employee_Insert
ON Employees
AFTER INSERT
AS
BEGIN
    INSERT INTO EmployeeAudit
    (EmployeeID, ActionType, NewSalary, NewDepartment, ActionUser)
    SELECT EmployeeID, 'INSERT', Salary, Department, SYSTEM_USER
    FROM inserted;
END;
GO

-------------------------------------------------
-- UPDATE TRIGGER (SALARY OR DEPARTMENT)
-------------------------------------------------
CREATE TRIGGER trg_Employee_Update
ON Employees
AFTER UPDATE
AS
BEGIN
    INSERT INTO EmployeeAudit
    (EmployeeID, ActionType, OldSalary, NewSalary, OldDepartment, NewDepartment, ActionUser)
    SELECT i.EmployeeID,
           'UPDATE',
           d.Salary,
           i.Salary,
           d.Department,
           i.Department,
           SYSTEM_USER
    FROM inserted i
    JOIN deleted d ON i.EmployeeID = d.EmployeeID;
END;
GO

-------------------------------------------------
-- DELETE TRIGGER
-------------------------------------------------
CREATE TRIGGER trg_Employee_Delete
ON Employees
AFTER DELETE
AS
BEGIN
    INSERT INTO EmployeeAudit
    (EmployeeID, ActionType, OldSalary, OldDepartment, ActionUser)
    SELECT EmployeeID, 'DELETE', Salary, Department, SYSTEM_USER
    FROM deleted;
END;
GO

-------------------------------------------------
-- BUSINESS RULE TRIGGER (PREVENT NEGATIVE SALARY)
-------------------------------------------------
CREATE TRIGGER trg_Prevent_Negative_Salary
ON Employees
AFTER UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted WHERE Salary < 0)
    BEGIN
        ROLLBACK;
        RAISERROR ('Salary cannot be negative', 16, 1);
    END
END;
GO

-------------------------------------------------
-- SOFT DELETE TRIGGER (INSTEAD OF DELETE)
-------------------------------------------------
CREATE TRIGGER trg_Soft_Delete_Employee
ON Employees
INSTEAD OF DELETE
AS
BEGIN
    UPDATE Employees
    SET Status = 'INACTIVE'
    WHERE EmployeeID IN (SELECT EmployeeID FROM deleted);
END;
GO

-------------------------------------------------
-- TRIGGER USING IF UPDATE
-------------------------------------------------
CREATE TRIGGER trg_Update_Check
ON Employees
AFTER UPDATE
AS
BEGIN
    IF UPDATE(Salary)
        PRINT 'Salary column updated';
    IF UPDATE(Department)
        PRINT 'Department column updated';
END;
GO

-------------------------------------------------
-- TEST QUERIES
-------------------------------------------------
INSERT INTO Employees (Name, Department, Salary)
VALUES ('Alice','IT',50000), ('Bob','HR',40000);

UPDATE Employees SET Salary = 55000 WHERE Name = 'Alice';
UPDATE Employees SET Department = 'Sales' WHERE Name = 'Alice';

DELETE FROM Employees WHERE Name = 'Bob';

SELECT * FROM Employees;
SELECT * FROM EmployeeAudit;

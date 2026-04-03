
-- INSERT
INSERT INTO Departments (DepartmentName, Location)
VALUES ('IT','Bangalore'), ('HR','Mumbai'), ('Sales','Delhi');

INSERT INTO Employees (Name, DepartmentID, Salary, Email, Phone, Gender)
VALUES 
('Alice',1,50000,'alice@mail.com','9876543210','F'),
('Bob',2,40000,'bob@mail.com','9123456789','M'),
('Carol',1,60000,'carol@mail.com','9988776655','F');

-- SELECT
SELECT * FROM Employees;
SELECT Name, Salary FROM Employees WHERE Salary > 45000;

-- JOIN
SELECT e.Name, d.DepartmentName
FROM Employees e
INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID;

-- UPDATE
UPDATE Employees SET Salary = Salary + 5000 WHERE DepartmentID = 1;

-- DELETE
DELETE FROM Employees WHERE Name = 'Bob';

-- MERGE
MERGE Employees AS target
USING (SELECT 4 AS DepartmentID, 'David' AS Name, 45000 AS Salary) AS source
ON target.Name = source.Name
WHEN NOT MATCHED THEN
INSERT (Name, DepartmentID, Salary)
VALUES (source.Name, source.DepartmentID, source.Salary);

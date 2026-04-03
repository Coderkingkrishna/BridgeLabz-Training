using System;
using System.Collections.Generic;

/* ================= INTERFACE ================= */
interface IDepartment
{
    void AssignDepartment(string deptName);
    string GetDepartmentDetails();
}

/* ================= ABSTRACT CLASS ================= */
abstract class Employee : IDepartment
{
    // Encapsulation
    private int employeeId;
    private string name;
    private double baseSalary;
    protected string department;

    // Properties
    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    // Constructor
    public Employee(int id, string name, double baseSalary)
    {
        this.employeeId = id;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    // Abstract method
    public abstract double CalculateSalary();

    // Concrete method
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID : " + EmployeeId);
        Console.WriteLine("Name        : " + Name);
        Console.WriteLine("Department  : " + department);
        Console.WriteLine("Salary      : " + CalculateSalary());
        Console.WriteLine("----------------------------");
    }

    // Interface implementation
    public void AssignDepartment(string deptName)
    {
        department = deptName;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}

/* ================= FULL TIME EMPLOYEE ================= */
class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary)
    {
    }

    public override double CalculateSalary()
    {
        return BaseSalary; // Fixed salary
    }
}

/* ================= PART TIME EMPLOYEE ================= */
class PartTimeEmployee : Employee
{
    private int workHours;
    private double hourlyRate;

    public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name, 0)
    {
        workHours = hours;
        hourlyRate = rate;
    }

    public override double CalculateSalary()
    {
        return workHours * hourlyRate;
    }
}

/* ================= MAIN CLASS ================= */
class Program
{
    static void Main()
    {
        // Polymorphism
        List<Employee> employees = new List<Employee>();

        Employee emp1 = new FullTimeEmployee(101, "Rahul", 50000);
        emp1.AssignDepartment("IT");

        Employee emp2 = new PartTimeEmployee(102, "Anita", 120, 300);
        emp2.AssignDepartment("HR");

        employees.Add(emp1);
        employees.Add(emp2);

        // Processing using Employee reference
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }

        Console.ReadLine();
    }
}

using System;

class EmployeeUtilityImpl : IEmployee{

    Employee[] employees = new Employee[20];
    int count = 0;

    private Employee FindEmployee(int empId){
        for(int i = 0; i < count; i++){
            if(employees[i].GetEmpId() == empId){
                return employees[i];
            }
        }
        return null;
    }

    public void AddEmployee(){
        if(count >= 20){
            Console.WriteLine("Employee limit reached");
            return;
        }

        Console.WriteLine("Enter Employee Id");
        int id = int.Parse(Console.ReadLine());

        if(FindEmployee(id) != null){
            Console.WriteLine("Employee ID already exists. Try another ID.");
            return;
        }

        Employee emp = new Employee();
        emp.SetEmpId(id);

        Console.WriteLine("Enter Wage Per Hour");
        emp.SetWagePerHour(int.Parse(Console.ReadLine()));

        Console.WriteLine("Enter Employee Type 1 Full Time 2 Part Time");
        emp.SetEmpType(int.Parse(Console.ReadLine()));

        employees[count] = emp;
        count++;

        Console.WriteLine("Employee added successfully");
    }

    public void CheckAttendance(int empId){
        Employee emp = FindEmployee(empId);
        if(emp == null){
            Console.WriteLine("Employee not found");
            return;
        }

        Random random = new Random();
        int attendance = random.Next(0,2);

        Console.WriteLine(attendance == 1 ? "Employee Present" : "Employee Absent");
    }

    public void CalculateDailyWage(int empId){
        Employee emp = FindEmployee(empId);
        if(emp == null){
            Console.WriteLine("Employee not found");
            return;
        }

        int hours = emp.GetEmpType() == 1 ? 8 : 4;
        int wage = hours * emp.GetWagePerHour();
        Console.WriteLine("Daily Wage: " + wage);
    }

    public void CalculateMonthlyWage(int empId){
        Employee emp = FindEmployee(empId);
        if(emp == null){
            Console.WriteLine("Employee not found");
            return;
        }

        int hours = emp.GetEmpType() == 1 ? 8 : 4;
        int monthlyWage = hours * emp.GetWagePerHour() * 20;
        Console.WriteLine("Monthly Wage: " + monthlyWage);
    }

}

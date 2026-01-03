using System;
class Employee{
    public int employeeID;
    protected string department;
    private double salary;
    public void SetSalary(double s){salary=s;}
    public double GetSalary(){return salary;}
}
class Manager:Employee{
    public void SetDetails(int i,string d){
        employeeID=i;department=d;
    }
    public void Display(){
        Console.WriteLine(employeeID+" "+department);
    }
}
class Test{
    static void Main(){
        Manager m=new Manager();
        Console.Write("Employee ID: "); // input id
        int i=int.Parse(Console.ReadLine());
        Console.Write("Department: "); // input department
        string d=Console.ReadLine();
        Console.Write("Salary: "); // input salary
        double s=double.Parse(Console.ReadLine());
        m.SetDetails(i,d);
        m.SetSalary(s);
        m.Display();
        Console.WriteLine("Salary:"+m.GetSalary());
    }
}

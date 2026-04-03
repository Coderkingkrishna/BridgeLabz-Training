using System;
class Employee{
    public static string CompanyName="TechCorp";
    static int total=0;
    public string Name,Designation;
    public readonly int Id;

    public Employee(string Name,int Id,string Designation){
        this.Name=Name;
        this.Id=Id;
        this.Designation=Designation;
        total++;
    }

    public static void DisplayTotalEmployees(){
        Console.WriteLine("Total Employees:"+total);
    }

    public void Display(object obj){
        if(obj is Employee)
            Console.WriteLine(Name+" "+Id+" "+Designation);
    }

    static void Main(){
        Console.Write("Enter Name: "); // input name
        string n=Console.ReadLine();
        Console.Write("Enter ID: "); // input id
        int i=int.Parse(Console.ReadLine());
        Console.Write("Enter Designation: "); // input designation
        string d=Console.ReadLine();
        Employee e=new Employee(n,i,d);
        Console.WriteLine(CompanyName);
        e.Display(e);
        DisplayTotalEmployees();
    }
}

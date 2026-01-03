using System;
class Student{
    public static string UniversityName="GLAUniversity";
    static int total=0;
    public string Name,Grade;
    public readonly int RollNumber;

    public Student(string Name,int RollNumber,string Grade){
        this.Name=Name;
        this.RollNumber=RollNumber;
        this.Grade=Grade;
        total++;
    }

    public static void DisplayTotalStudents(){
        Console.WriteLine("Total Students:"+total);
    }

    public void Display(object obj){
        if(obj is Student)
            Console.WriteLine(Name+" "+RollNumber+" "+Grade);
    }

    static void Main(){
        Console.Write("Enter Name: "); // input name
        string n=Console.ReadLine();
        Console.Write("Enter Roll Number: "); // input roll number
        int r=int.Parse(Console.ReadLine());
        Console.Write("Enter Grade: "); // input grade
        string g=Console.ReadLine();
        Student s=new Student(n,r,g);
        Console.WriteLine(UniversityName);
        s.Display(s);
        DisplayTotalStudents();
    }
}

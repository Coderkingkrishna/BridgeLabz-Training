using System;
class Person{
    protected string Name;
    protected int Age;
}
class Teacher:Person{
    string Subject;
    public Teacher(string n,int a,string s){
        Name=n;Age=a;Subject=s;
    }
    public void DisplayRole(){
        Console.WriteLine("Teacher "+Subject);
    }
}
class Student:Person{
    string Grade;
    public Student(string n,int a,string g){
        Name=n;Age=a;Grade=g;
    }
    public void DisplayRole(){
        Console.WriteLine("Student "+Grade);
    }
}
class Staff:Person{
    string Department;
    public Staff(string n,int a,string d){
        Name=n;Age=a;Department=d;
    }
    public void DisplayRole(){
        Console.WriteLine("Staff "+Department);
    }
}
class Test{
    static void Main(){
        Teacher t=new Teacher("Amit",40,"Math");
        Student s=new Student("Ravi",18,"A");
        Staff st=new Staff("Kiran",35,"Office");
        t.DisplayRole();
        s.DisplayRole();
        st.DisplayRole();
    }
}

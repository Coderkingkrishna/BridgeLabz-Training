using System;
class Course{
    protected string CourseName;
    protected int Duration;
    public Course(string n,int d){
        CourseName=n;Duration=d;
    }
}
class OnlineCourse:Course{
    protected string Platform;
    protected bool IsRecorded;
    public OnlineCourse(string n,int d,string p,bool r):base(n,d){
        Platform=p;IsRecorded=r;
    }
}
class PaidOnlineCourse:OnlineCourse{
    double Fee,Discount;
    public PaidOnlineCourse(string n,int d,string p,bool r,double f,double dis):base(n,d,p,r){
        Fee=f;Discount=dis;
    }
    public void Display(){
        Console.WriteLine(CourseName+" "+Platform+" "+(Fee-Discount));
    }
}
class Test{
    static void Main(){
        Console.Write("Course Name: "); // input name
        string n=Console.ReadLine();
        Console.Write("Duration: "); // input duration
        int d=int.Parse(Console.ReadLine());
        Console.Write("Platform: "); // input platform
        string p=Console.ReadLine();
        Console.Write("Recorded(true/false): "); // input recorded
        bool r=bool.Parse(Console.ReadLine());
        Console.Write("Fee: "); // input fee
        double f=double.Parse(Console.ReadLine());
        Console.Write("Discount: "); // input discount
        double dis=double.Parse(Console.ReadLine());
        PaidOnlineCourse c=new PaidOnlineCourse(n,d,p,r,f,dis);
        c.Display();
    }
}

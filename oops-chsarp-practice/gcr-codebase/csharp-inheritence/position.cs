using System;
class position{
    protected string Name;
    protected int Id;
    public position(string n,int i){
        Name=n;Id=i;
    }
    public virtual void PerformDuties(){
        Console.WriteLine("General Work");
    }
}
class Chef:position{
    public Chef(string n,int i):base(n,i){}
    public override void PerformDuties(){
        Console.WriteLine("Chef is Cooking Food");
    }
}
class Waiter:position{
    public Waiter(string n,int i):base(n,i){}
    public override void PerformDuties(){
        Console.WriteLine("Waiter is Serving Food");
    }
}
class Test{
    static void Main(){
        Console.Write("Chef Name: "); // input chef name
        string cn=Console.ReadLine();
        Console.Write("Chef ID: "); // input chef id
        int ci=int.Parse(Console.ReadLine());
        Console.Write("Waiter Name: "); // input waiter name
        string wn=Console.ReadLine();
        Console.Write("Waiter ID: "); // input waiter id
        int wi=int.Parse(Console.ReadLine());
        position p1=new Chef(cn,ci);
        position p2=new Waiter(wn,wi);
        p1.PerformDuties();
        p2.PerformDuties();
    }
}

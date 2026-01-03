using System;
class CarRental{
    string customerName,carModel;
    int rentalDays;
    int cost=1000;
    public CarRental(string c,string m,int d){
        customerName=c;carModel=m;rentalDays=d;
    }
    public void Display(){
        Console.WriteLine(customerName+" "+carModel+" "+(rentalDays*cost));
    }
}
class Test{
    static void Main(){
        Console.Write("Customer Name: "); // input customer
        string c=Console.ReadLine();
        Console.Write("Car Model: "); // input car model
        string m=Console.ReadLine();
        Console.Write("Days: "); // input days
        int d=int.Parse(Console.ReadLine());
        CarRental r=new CarRental(c,m,d);
        r.Display();
    }
}

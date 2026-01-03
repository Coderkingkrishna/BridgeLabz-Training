using System;
class Product{
    public static double Discount=10;
    public string ProductName;
    public double Price;
    public int Quantity;
    public readonly int ProductID;

    public Product(string ProductName,double Price,int Quantity,int ProductID){
        this.ProductName=ProductName;
        this.Price=Price;
        this.Quantity=Quantity;
        this.ProductID=ProductID;
    }

    public static void UpdateDiscount(double d){
        Discount=d;
    }

    public void Display(object obj){
        if(obj is Product)
            Console.WriteLine(ProductName+" "+ProductID+" "+Price+" "+Quantity);
    }

    static void Main(){
        Console.Write("Enter Product Name: "); // input product name
        string n=Console.ReadLine();
        Console.Write("Enter Price: "); // input price
        double p=double.Parse(Console.ReadLine());
        Console.Write("Enter Quantity: "); // input quantity
        int q=int.Parse(Console.ReadLine());
        Console.Write("Enter Product ID: "); // input product id
        int id=int.Parse(Console.ReadLine());
        Product pr=new Product(n,p,q,id);
        pr.Display(pr);
        UpdateDiscount(15);
        Console.WriteLine("Discount:"+Discount);
    }
}

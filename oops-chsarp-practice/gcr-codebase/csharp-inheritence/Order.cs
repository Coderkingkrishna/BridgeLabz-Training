using System;
class Order{
    protected int orderId;
    protected string orderDate;
    public Order(int i,string d){
        orderId=i;orderDate=d;
    }
}
class ShippedOrder:Order{
    protected string trackingNumber;
    public ShippedOrder(int i,string d,string t):base(i,d){
        trackingNumber=t;
    }
}
class DeliveredOrder:ShippedOrder{
    string deliveryDate;
    public DeliveredOrder(int i,string d,string t,string dd):base(i,d,t){
        deliveryDate=dd;
    }
    public void GetOrderStatus(){
        Console.WriteLine("Delivered "+deliveryDate);
    }
}
class Test{
    static void Main(){
        Console.Write("Order ID: "); // input id
        int i=int.Parse(Console.ReadLine());
        Console.Write("Order Date: "); // input date
        string d=Console.ReadLine();
        Console.Write("Tracking No: "); // input tracking
        string t=Console.ReadLine();
        Console.Write("Delivery Date: "); // input delivery date
        string dd=Console.ReadLine();
        DeliveredOrder o=new DeliveredOrder(i,d,t,dd);
        o.GetOrderStatus();
    }
}

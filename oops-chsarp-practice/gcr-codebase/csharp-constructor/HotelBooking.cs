using System;
class HotelBooking{
    string guestName,roomType;
    int nights;
    public HotelBooking(){
        guestName="NA";roomType="NA";nights=0;
    }
    public HotelBooking(string g,string r,int n){
        guestName=g;roomType=r;nights=n;
    }
    public HotelBooking(HotelBooking h){
        guestName=h.guestName;roomType=h.roomType;nights=h.nights;
    }
    public void Display(){
        Console.WriteLine(guestName+" "+roomType+" "+nights);
    }
}
class Test{
    static void Main(){
        Console.Write("Guest Name: "); // input guest name
        string g=Console.ReadLine();
        Console.Write("Room Type: "); // input room type
        string r=Console.ReadLine();
        Console.Write("Nights: "); // input nights
        int n=int.Parse(Console.ReadLine());
        HotelBooking h1=new HotelBooking(g,r,n);
        HotelBooking h2=new HotelBooking(h1);
        h2.Display();
    }
}

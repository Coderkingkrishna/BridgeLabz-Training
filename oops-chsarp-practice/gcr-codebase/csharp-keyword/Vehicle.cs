using System;
class Vehicle{
    public static double RegistrationFee=5000;
    public string OwnerName,VehicleType;
    public readonly string RegistrationNumber;

    public Vehicle(string OwnerName,string VehicleType,string RegistrationNumber){
        this.OwnerName=OwnerName;
        this.VehicleType=VehicleType;
        this.RegistrationNumber=RegistrationNumber;
    }

    public static void UpdateRegistrationFee(double f){
        RegistrationFee=f;
    }

    public void Display(object obj){
        if(obj is Vehicle)
            Console.WriteLine(OwnerName+" "+VehicleType+" "+RegistrationNumber);
    }

    static void Main(){
        Console.Write("Enter Owner Name: "); // input owner name
        string o=Console.ReadLine();
        Console.Write("Enter Vehicle Type: "); // input vehicle type
        string t=Console.ReadLine();
        Console.Write("Enter Registration Number: "); // input registration number
        string r=Console.ReadLine();
        Vehicle v=new Vehicle(o,t,r);
        v.Display(v);
        UpdateRegistrationFee(6000);
        Console.WriteLine("Fee:"+RegistrationFee);
    }
}

using System;
class Device{
    protected int DeviceId;
    protected string Status;
    public Device(int id,string s){
        DeviceId=id;Status=s;
    }
}
class Thermostat:Device{
    int TemperatureSetting;
    public Thermostat(int id,string s,int t):base(id,s){
        TemperatureSetting=t;
    }
    public void DisplayStatus(){
        Console.WriteLine(DeviceId+" "+Status+" "+TemperatureSetting);
    }
}
class Test{
    static void Main(){
        Console.Write("Device ID: "); // input id
        int id=int.Parse(Console.ReadLine());
        Console.Write("Status: "); // input status
        string s=Console.ReadLine();
        Console.Write("Temperature: "); // input temperature
        int t=int.Parse(Console.ReadLine());
        Thermostat th=new Thermostat(id,s,t);
        th.DisplayStatus();
    }
}

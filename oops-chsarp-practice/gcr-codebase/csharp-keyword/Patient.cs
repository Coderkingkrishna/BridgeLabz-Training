using System;
class Patient{
    public static string HospitalName="CityHospital";
    static int total=0;
    public string Name,Ailment;
    public int Age;
    public readonly int PatientID;

    public Patient(string Name,int Age,string Ailment,int PatientID){
        this.Name=Name;
        this.Age=Age;
        this.Ailment=Ailment;
        this.PatientID=PatientID;
        total++;
    }

    public static void GetTotalPatients(){
        Console.WriteLine("Total Patients:"+total);
    }

    public void Display(object obj){
        if(obj is Patient)
            Console.WriteLine(Name+" "+Age+" "+Ailment+" "+PatientID);
    }

    static void Main(){
        Console.Write("Enter Name: "); // input name
        string n=Console.ReadLine();
        Console.Write("Enter Age: "); // input age
        int a=int.Parse(Console.ReadLine());
        Console.Write("Enter Ailment: "); // input ailment
        string al=Console.ReadLine();
        Console.Write("Enter Patient ID: "); // input patient id
        int id=int.Parse(Console.ReadLine());
        Patient p=new Patient(n,a,al,id);
        Console.WriteLine(HospitalName);
        p.Display(p);
        GetTotalPatients();
    }
}

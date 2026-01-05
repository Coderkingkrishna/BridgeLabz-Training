using System;
public class InPatient : Patient, IPayable
{
    public int DaysAdmitted { get; set; }
    public double DailyCharge { get; set; }

    public InPatient(int id, string name, int age, int days, double charge)
        : base(id, name, age)
    {
        DaysAdmitted = days;
        DailyCharge = charge;
    }

    public double CalculateBill()
    {
        return DaysAdmitted * DailyCharge;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("\nPatient Type: In-Patient");
        Console.WriteLine("ID: " + PatientId + ", Name: " + Name + ", Age: " + Age);
        Console.WriteLine("Days Admitted: " + DaysAdmitted);
        Console.WriteLine("Daily Charge: " + DailyCharge);
    }
}

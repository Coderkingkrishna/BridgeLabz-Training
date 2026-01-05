using System;
public class OutPatient : Patient, IPayable
{
    public double ConsultationFee { get; set; }

    public OutPatient(int id, string name, int age, double fee)
        : base(id, name, age)
    {
        ConsultationFee = fee;
    }

    public double CalculateBill()
    {
        return ConsultationFee;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("\nPatient Type: Out-Patient");
        Console.WriteLine("ID: " + PatientId + ", Name: " + Name + ", Age: " + Age);
        Console.WriteLine("Consultation Fee: " + ConsultationFee);
    }
}

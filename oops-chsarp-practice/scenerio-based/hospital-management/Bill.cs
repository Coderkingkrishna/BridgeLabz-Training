using System;
public class Bill
{
    private Patient patient;
    private Doctor doctor;
    private IPayable payable;

    public Bill(Patient patient, Doctor doctor, IPayable payable)
    {
        this.patient = patient;
        this.doctor = doctor;
        this.payable = payable;
    }

    public void GenerateBill()
    {
        Console.WriteLine("\n=========== BILL ===========");
        patient.DisplayInfo();
        doctor.DisplayDoctor();
        Console.WriteLine("Total Amount: ₹ "+payable.CalculateBill());
        Console.WriteLine("============================\n");
    }
}

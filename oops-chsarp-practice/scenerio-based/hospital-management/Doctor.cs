using System;
public class Doctor
{
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }

    public Doctor(int id, string name, string specialization)
    {
        DoctorId = id;
        Name = name;
        Specialization = specialization;
    }

    public void DisplayDoctor()
    {
        Console.WriteLine("\nDoctor Details:");
        Console.WriteLine("ID: " + DoctorId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Specialization: " + Specialization);
    }
}

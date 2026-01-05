using System;
using System.Collections.Generic;

class Program
{
    static List<Doctor> doctors = new List<Doctor>();
    static List<Patient> patients = new List<Patient>();

    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== HOSPITAL MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Doctor");
            Console.WriteLine("2. Add In-Patient");
            Console.WriteLine("3. Add Out-Patient");
            Console.WriteLine("4. Generate Bill");
            Console.WriteLine("5. Exit");
            Console.Write("Enter Choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddDoctor();
                    break;
                case 2:
                    AddInPatient();
                    break;
                case 3:
                    AddOutPatient();
                    break;
                case 4:
                    GenerateBill();
                    break;
                case 5:
                    Console.WriteLine("Thank You!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        } while (choice != 5);
    }

    // ================= ADD DOCTOR =================
    static void AddDoctor()
    {
        Console.Write("Doctor ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Doctor Name: ");
        string name = Console.ReadLine();

        Console.Write("Specialization: ");
        string spec = Console.ReadLine();

        doctors.Add(new Doctor(id, name, spec));
        Console.WriteLine("Doctor Added Successfully!");
    }

    // ================= ADD IN-PATIENT =================
    static void AddInPatient()
    {
        Console.Write("Patient ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Patient Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Days Admitted: ");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.Write("Daily Charge: ");
        double charge = Convert.ToDouble(Console.ReadLine());

        patients.Add(new InPatient(id, name, age, days, charge));
        Console.WriteLine("In-Patient Added Successfully!");
    }

    // ================= ADD OUT-PATIENT =================
    static void AddOutPatient()
    {
        Console.Write("Patient ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Patient Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Consultation Fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());

        patients.Add(new OutPatient(id, name, age, fee));
        Console.WriteLine("Out-Patient Added Successfully!");
    }

    // ================= GENERATE BILL =================
    static void GenerateBill()
    {
        if (doctors.Count == 0 || patients.Count == 0)
        {
            Console.WriteLine("Please add Doctor and Patient first!");
            return;
        }

        Console.WriteLine("\nSelect Doctor:");
        for (int i = 0; i < doctors.Count; i++)
            Console.WriteLine((i + 1) + ". " + doctors[i].Name);

        int docIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("\nSelect Patient:");
        for (int i = 0; i < patients.Count; i++)
            Console.WriteLine((i + 1) + ". " + patients[i].Name);

        int patIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        Patient p = patients[patIndex];
        Doctor d = doctors[docIndex];

        Bill bill = new Bill(p, d, (IPayable)p);
        bill.GenerateBill();
    }
}

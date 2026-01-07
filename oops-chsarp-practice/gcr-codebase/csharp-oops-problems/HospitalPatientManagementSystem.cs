using System;

interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

abstract class Patient
{
    private int patientId;
    private string name;
    private int age;
    private string diagnosis;
    private string medicalHistory;

    public void SetPatientId(int id)
    {
        patientId = id;
    }

    public void SetName(string patientName)
    {
        name = patientName;
    }

    public void SetAge(int patientAge)
    {
        if (patientAge > 0)
        {
            age = patientAge;
        }
    }

    protected void SetDiagnosis(string diag)
    {
        diagnosis = diag;
    }

    protected void SetMedicalHistory(string history)
    {
        medicalHistory = history;
    }

    public int GetPatientId()
    {
        return patientId;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID : " + patientId);
        Console.WriteLine("Name       : " + name);
        Console.WriteLine("Age        : " + age);
    }
}

class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;
    private double dailyCharge;

    public void SetAdmissionDetails(int days, double charge)
    {
        daysAdmitted = days;
        dailyCharge = charge;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * dailyCharge;
    }

    public void AddRecord(string record)
    {
        SetDiagnosis(record);
        SetMedicalHistory("InPatient Treatment Record");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Record : InPatient");
    }
}

class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public void SetConsultationFee(double fee)
    {
        consultationFee = fee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string record)
    {
        SetDiagnosis(record);
        SetMedicalHistory("OutPatient Consultation Record");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Record : OutPatient");
    }
}

class Program
{
    static void ProcessPatients(Patient[] patients)
    {
        for (int i = 0; i < patients.Length; i++)
        {
            Patient p = patients[i];

            p.GetPatientDetails();
            Console.WriteLine("Bill Amount : " + p.CalculateBill());

            if (p is IMedicalRecord)
            {
                IMedicalRecord m = (IMedicalRecord)p;
                m.ViewRecords();
            }

            Console.WriteLine("---------------");
        }
    }

    static void Main()
    {
        Patient[] patients = new Patient[2];

        InPatient inPatient = new InPatient();
        inPatient.SetPatientId(1);
        inPatient.SetName("Rahul");
        inPatient.SetAge(45);
        inPatient.SetAdmissionDetails(5, 3000);
        inPatient.AddRecord("Pneumonia");

        OutPatient outPatient = new OutPatient();
        outPatient.SetPatientId(2);
        outPatient.SetName("Anita");
        outPatient.SetAge(30);
        outPatient.SetConsultationFee(800);
        outPatient.AddRecord("General Checkup");

        patients[0] = inPatient;
        patients[1] = outPatient;

        ProcessPatients(patients);

        Console.ReadLine();
    }
}

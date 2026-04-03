using System;

interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

abstract class Vehicle
{
    private string vehicleNumber;
    private string type;
    private double rentalRate;
    private string insurancePolicyNumber;

    public void SetVehicleNumber(string number)
    {
        vehicleNumber = number;
    }

    public void SetType(string vehicleType)
    {
        type = vehicleType;
    }

    public void SetRentalRate(double rate)
    {
        if (rate > 0)
        {
            rentalRate = rate;
        }
    }

    protected void SetInsurancePolicyNumber(string policyNumber)
    {
        insurancePolicyNumber = policyNumber;
    }

    public string GetVehicleNumber()
    {
        return vehicleNumber;
    }

    public string GetType()
    {
        return type;
    }

    public double GetRentalRate()
    {
        return rentalRate;
    }

    protected string GetInsurancePolicyNumber()
    {
        return insurancePolicyNumber;
    }

    public abstract double CalculateRentalCost(int days);
}

class Car : Vehicle, IInsurable
{
    public Car()
    {
        SetInsurancePolicyNumber("CAR-INS-001");
    }

    public override double CalculateRentalCost(int days)
    {
        return GetRentalRate() * days;
    }

    public double CalculateInsurance()
    {
        return 500;
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance Policy: " + GetInsurancePolicyNumber();
    }
}

class Bike : Vehicle, IInsurable
{
    public Bike()
    {
        SetInsurancePolicyNumber("BIKE-INS-002");
    }

    public override double CalculateRentalCost(int days)
    {
        return GetRentalRate() * days * 0.9;
    }

    public double CalculateInsurance()
    {
        return 200;
    }

    public string GetInsuranceDetails()
    {
        return "Bike Insurance Policy: " + GetInsurancePolicyNumber();
    }
}

class Truck : Vehicle, IInsurable
{
    public Truck()
    {
        SetInsurancePolicyNumber("TRUCK-INS-003");
    }

    public override double CalculateRentalCost(int days)
    {
        return GetRentalRate() * days * 1.5;
    }

    public double CalculateInsurance()
    {
        return 1000;
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance Policy: " + GetInsurancePolicyNumber();
    }
}

class Program
{
    static void ProcessVehicles(Vehicle[] vehicles, int days)
    {
        for (int i = 0; i < vehicles.Length; i++)
        {
            Vehicle v = vehicles[i];

            Console.WriteLine("Vehicle Number : " + v.GetVehicleNumber());
            Console.WriteLine("Type           : " + v.GetType());
            Console.WriteLine("Rental Cost    : " + v.CalculateRentalCost(days));

            if (v is IInsurable)
            {
                IInsurable ins = (IInsurable)v;
                Console.WriteLine(ins.GetInsuranceDetails());
                Console.WriteLine("Insurance Cost : " + ins.CalculateInsurance());
            }

            Console.WriteLine("----------");
        }
    }

    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];

        Vehicle car = new Car();
        car.SetVehicleNumber("UP14-CAR-101");
        car.SetType("Car");
        car.SetRentalRate(2000);

        Vehicle bike = new Bike();
        bike.SetVehicleNumber("UP14-BIKE-202");
        bike.SetType("Bike");
        bike.SetRentalRate(800);

        Vehicle truck = new Truck();
        truck.SetVehicleNumber("UP14-TRUCK-303");
        truck.SetType("Truck");
        truck.SetRentalRate(5000);

        vehicles[0] = car;
        vehicles[1] = bike;
        vehicles[2] = truck;

        ProcessVehicles(vehicles, 3);

        Console.ReadLine();
    }
}

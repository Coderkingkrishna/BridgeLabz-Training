using System;
class Salary{
    public static void Main(string[] args){
        double[ ,] Data = new double[10, 5];
        for (int i = 0; i < 10; i++){
            double SalaryAmount = double.Parse(Console.ReadLine());
            double Year = double.Parse(Console.ReadLine());
            Data[i, 0] = SalaryAmount;
            Data[i, 1] = Year;
            double Bonus = Year < 5? (SalaryAmount * 2) / 100 : (SalaryAmount * 5) / 100;
            Data[i, 2] = Bonus;
            double OldSalary = SalaryAmount * Year;
            double NewSalary = OldSalary + Bonus;
            Data[i, 3] = OldSalary;
            Data[i, 4] = NewSalary;
        }

        for (int i = 0; i < Data.GetLength(0); i++){
            Console.WriteLine("Bonus = " + Data[i, 2] + " OldSalary = " + Data[i, 3] +"  NewSalary = " + Data[i, 4]);
        }
    }
}

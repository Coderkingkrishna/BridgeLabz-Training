using System;
class Salary{
    public static void Main(string[] args){
        var Data = new double[10, 5];
        for (var i = 0; i < 10; i++){
            var SalaryAmount = double.Parse(Console.ReadLine());
            var Year = double.Parse(Console.ReadLine());
            Data[i, 0] = SalaryAmount;
            Data[i, 1] = Year;
            var Bonus = Year < 5? (SalaryAmount * 2) / 100 : (SalaryAmount * 5) / 100;
            Data[i, 2] = Bonus;
            var OldSalary = SalaryAmount * Year;
            var NewSalary = OldSalary + Bonus;
            Data[i, 3] = OldSalary;
            Data[i, 4] = NewSalary;
        }

        for (var i = 0; i < Data.GetLength(0); i++){
            Console.WriteLine("Bonus = " + Data[i, 2] + " OldSalary = " + Data[i, 3] +"  NewSalary = " + Data[i, 4]);
        }
    }
}

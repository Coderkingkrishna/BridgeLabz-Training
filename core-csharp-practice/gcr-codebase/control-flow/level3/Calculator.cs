using System;
class Calculator{
    public static void Main(){
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        String Op = Console.ReadLine();
        switch (Op) {
            case "+" : 
                Console.WriteLine(A + B);
                break;
            case "-" :
                Console.WriteLine(A - B);
                break;
            case "*":
                Console.WriteLine(A * B);
                break;
            case "/":
                if(B == 0)Console.WriteLine("Denominator can't be zero");
                else Console.WriteLine(A / B);
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
            
        }
    }
}
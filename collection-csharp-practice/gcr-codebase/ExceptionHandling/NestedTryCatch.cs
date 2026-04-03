using System;

class NestedTryCatch
{
    static void Main()
    {
        try
        {
            int[] arr = { 10, 20, 30 };
            int index = Convert.ToInt32(Console.ReadLine());
            try
            {
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arr[index] / divisor);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}

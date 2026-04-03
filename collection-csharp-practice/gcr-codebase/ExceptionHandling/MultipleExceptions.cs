using System;

class MultipleExceptions
{
    static void Main()
    {
        try
        {
            int[] arr = { 10, 20, 30 };
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arr[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
    }
}

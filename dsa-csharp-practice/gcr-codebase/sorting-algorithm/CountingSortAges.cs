using System;

class CountingSortAges
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] ages = new int[n];

        Console.WriteLine("Enter ages of students (between 10 and 18):");
        for (int i = 0; i < n; i++)
        {
            ages[i] = int.Parse(Console.ReadLine());
            if (ages[i] < 10 || ages[i] > 18)
            {
                Console.WriteLine("Invalid age! Enter age between 10 and 18.");
                i--;
            }
        }

        int[] count = new int[19];

        for (int i = 0; i < n; i++)
            count[ages[i]]++;

        Console.WriteLine("Sorted Ages:");
        for (int age = 10; age <= 18; age++)
        {
            while (count[age] > 0)
            {
                Console.Write(age + " ");
                count[age]--;
            }
        }
    }
}

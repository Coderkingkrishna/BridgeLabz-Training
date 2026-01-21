using System;
using System.Collections;

class ReverseListArrayList
{
    public static void Run()
    {
        ArrayList list = new ArrayList();
        Console.WriteLine("Enter integers for ArrayList (comma separated):");
        string[] input = Console.ReadLine().Split(',');

        foreach (string s in input)
            list.Add(int.Parse(s.Trim()));

        int i = 0, j = list.Count - 1;
        while (i < j)
        {
            object temp = list[i];
            list[i] = list[j];
            list[j] = temp;
            i++;
            j--;
        }

        Console.WriteLine("Reversed ArrayList:");
        foreach (object obj in list)
            Console.Write(obj + " ");
        Console.WriteLine();
    }
}
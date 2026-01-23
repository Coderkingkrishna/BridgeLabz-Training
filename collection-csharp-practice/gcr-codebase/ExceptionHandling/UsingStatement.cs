using System;
using System.IO;

class UsingStatementDemo
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("info.txt"))
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}

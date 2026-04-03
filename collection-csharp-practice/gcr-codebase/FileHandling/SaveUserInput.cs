using System;
using System.IO;

class SaveUserInput
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        using (StreamWriter writer = new StreamWriter("user.txt"))
        {
            Console.WriteLine("Enter name:");
            string name = reader.ReadLine();

            Console.WriteLine("Enter age:");
            string age = reader.ReadLine();

            Console.WriteLine("Enter favorite language:");
            string lang = reader.ReadLine();

            writer.WriteLine(name);
            writer.WriteLine(age);
            writer.WriteLine(lang);
        }

        Console.WriteLine("Data saved");
    }
}

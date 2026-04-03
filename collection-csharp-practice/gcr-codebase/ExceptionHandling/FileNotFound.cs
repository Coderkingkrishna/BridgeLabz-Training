using System;
using System.IO;

class FileNotFoundDemo
{
    static void Main()
    {
        try
        {
            string text = File.ReadAllText("data.txt");
            Console.WriteLine(text);
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}

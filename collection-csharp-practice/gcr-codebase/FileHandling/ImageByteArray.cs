using System;
using System.IO;

class ImageByteArray
{
    static void Main()
    {
        Console.WriteLine("Enter image path:");
        string source = Console.ReadLine();

        try
        {
            byte[] bytes = File.ReadAllBytes(source);
            using MemoryStream ms = new MemoryStream(bytes);
            File.WriteAllBytes("copy.jpg", ms.ToArray());

            Console.WriteLine("Image copied");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

using System;
using System.IO;

class FileReadComparison
{
    static void Main()
    {
        string path = "largefile.txt";

        DateTime srStart = DateTime.Now;
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.ReadLine() != null)
                ;
        }
        DateTime srEnd = DateTime.Now;

        DateTime fsStart = DateTime.Now;
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            byte[] buffer = new byte[4096];
            while (fs.Read(buffer, 0, buffer.Length) > 0)
                ;
        }
        DateTime fsEnd = DateTime.Now;

        Console.WriteLine("\nFile Reading Time (ms)");
        Console.WriteLine("StreamReader : " + (srEnd - srStart).TotalMilliseconds);
        Console.WriteLine("FileStream   : " + (fsEnd - fsStart).TotalMilliseconds);
    }
}

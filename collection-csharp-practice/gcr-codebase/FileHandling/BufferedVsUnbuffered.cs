using System;
using System.Diagnostics;
using System.IO;

class BufferedVsUnbuffered
{
    static void Main()
    {
        Console.WriteLine("Enter source file path:");
        string source = Console.ReadLine();

        Console.WriteLine("Enter destination file path:");
        string destination = Console.ReadLine();

        byte[] buffer = new byte[4096];
        Stopwatch sw = new Stopwatch();

        sw.Start();
        using (FileStream fsRead = new FileStream(source, FileMode.Open))
        using (FileStream fsWrite = new FileStream(destination, FileMode.Create))
        {
            int read;
            while ((read = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                fsWrite.Write(buffer, 0, read);
        }
        sw.Stop();
        Console.WriteLine("Unbuffered time: " + sw.ElapsedMilliseconds);

        sw.Restart();
        using (BufferedStream br = new BufferedStream(new FileStream(source, FileMode.Open)))
        using (
            BufferedStream bw = new BufferedStream(
                new FileStream(destination + "_buf", FileMode.Create)
            )
        )
        {
            int read;
            while ((read = br.Read(buffer, 0, buffer.Length)) > 0)
                bw.Write(buffer, 0, read);
        }
        sw.Stop();
        Console.WriteLine("Buffered time: " + sw.ElapsedMilliseconds);
    }
}

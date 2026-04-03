using System;
using System.IO;

class BinaryStudent
{
    static void Main()
    {
        using (BinaryWriter bw = new BinaryWriter(File.Open("student.bin", FileMode.Create)))
        {
            bw.Write(1);
            bw.Write("Krishna");
            bw.Write(8.5);
        }

        using (BinaryReader br = new BinaryReader(File.Open("student.bin", FileMode.Open)))
        {
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
        }
    }
}

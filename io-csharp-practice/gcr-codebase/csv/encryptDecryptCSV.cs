using System;
using System.IO;
using System.Text;

class encryptDecryptCSV
{
    static string Encrypt(string input)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(input);
        return Convert.ToBase64String(bytes);
    }

    static string Decrypt(string input)
    {
        return Encoding.UTF8.GetString(Convert.FromBase64String(input));
    }

    static void Main()
    {
        StreamWriter sw = new StreamWriter("secure.csv");
        sw.WriteLine("Salary");
        sw.WriteLine(Encrypt("50000"));

        string encrypted = File.ReadAllLines("secure.csv")[1];
        Console.WriteLine("Decrypted Salary: " + Decrypt(encrypted));
    }
}

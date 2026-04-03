using System;
using System.IO;

public static class Logger
{
    private static string filePath = "error_log.txt";

    public static void Log(string message)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("====================================");
                writer.WriteLine("Date: " + DateTime.Now);
                writer.WriteLine("Error: " + message);
                writer.WriteLine("====================================");
            }
        }
        catch
        {
            Console.WriteLine("⚠ Logging failed.");
        }
    }
}

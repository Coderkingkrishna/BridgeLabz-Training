using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class JSONCSV
{
    static void Main()
    {
        var json = File.ReadAllText("students.json");
        var list = JsonSerializer.Deserialize<List<Dictionary<string, object>>>(json);

        StreamWriter sw = new StreamWriter("json_to_csv.csv");
        sw.WriteLine("ID,Name,Age,Marks");
        foreach (var s in list)
            sw.WriteLine(s["ID"] + "," + s["Name"] + "," + s["Age"] + "," + s["Marks"]);

        Console.WriteLine("JSON converted to CSV");
    }
}

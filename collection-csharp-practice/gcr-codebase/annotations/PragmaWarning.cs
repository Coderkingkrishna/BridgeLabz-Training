using System;
using System.Collections;

class PragmaWarningDemo
{
    static void Main()
    {
#pragma warning disable
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Text");
#pragma warning restore

        foreach (var item in list)
            Console.WriteLine(item);
    }
}

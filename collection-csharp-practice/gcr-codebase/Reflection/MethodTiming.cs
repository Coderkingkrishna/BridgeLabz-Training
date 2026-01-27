using System;
using System.Diagnostics;
using System.Reflection;

class Sample
{
    public void Work()
    {
        for (int i = 0; i < 1000000; i++) { }
    }
}

class MethodTiming
{
    static void Main()
    {
        Sample s = new Sample();
        MethodInfo m = typeof(Sample).GetMethod("Work");

        Stopwatch sw = new Stopwatch();
        sw.Start();
        m.Invoke(s, null);
        sw.Stop();

        Console.WriteLine("Execution time in ms: " + sw.ElapsedMilliseconds);
    }
}

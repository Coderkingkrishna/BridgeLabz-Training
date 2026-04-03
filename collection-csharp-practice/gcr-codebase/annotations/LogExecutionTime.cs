using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class Worker
{
    [LogExecutionTime]
    public void DoWork()
    {
        for (int i = 0; i < 1000000; i++) { }
    }
}

class ExecutionTimeDemo
{
    static void Main()
    {
        Worker w = new Worker();
        MethodInfo m = typeof(Worker).GetMethod("DoWork");

        Stopwatch sw = new Stopwatch();
        sw.Start();
        m.Invoke(w, null);
        sw.Stop();

        Console.WriteLine("Execution time: " + sw.ElapsedMilliseconds);
    }
}

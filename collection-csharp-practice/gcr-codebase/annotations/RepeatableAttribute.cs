using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description;

    public BugReportAttribute(string desc)
    {
        Description = desc;
    }
}

class BugDemo
{
    [BugReport("Null issue")]
    [BugReport("Performance issue")]
    public void Process() { }

    static void Main()
    {
        MethodInfo m = typeof(BugDemo).GetMethod("Process");
        var bugs = m.GetCustomAttributes(typeof(BugReportAttribute), false);
        foreach (BugReportAttribute b in bugs)
            Console.WriteLine(b.Description);
    }
}

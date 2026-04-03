using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task;
    public string AssignedTo;
    public string Priority;

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Refactor code", "Dev1")]
    [Todo("Add tests", "Dev2", "HIGH")]
    public void Build() { }
}

class TodoDemo
{
    static void Main()
    {
        MethodInfo m = typeof(Project).GetMethod("Build");
        var todos = m.GetCustomAttributes(typeof(TodoAttribute), false);
        foreach (TodoAttribute t in todos)
            Console.WriteLine(t.Task + " AssignedTo: " + t.AssignedTo + " Priority: " + t.Priority);
    }
}

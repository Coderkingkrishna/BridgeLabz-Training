using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public string Priority;
    public string AssignedTo;

    public TaskInfoAttribute(string priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo("HIGH", "Krishna")]
    public void CompleteTask() { }
}

class TaskInfoDemo
{
    static void Main()
    {
        MethodInfo m = typeof(TaskManager).GetMethod("CompleteTask");
        TaskInfoAttribute attr = (TaskInfoAttribute)
            Attribute.GetCustomAttribute(m, typeof(TaskInfoAttribute));
        Console.WriteLine("Priority: " + attr.Priority + " AssignedTo: " + attr.AssignedTo);
    }
}

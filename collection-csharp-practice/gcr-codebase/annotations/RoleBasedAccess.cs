using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class RoleAllowedAttribute : Attribute
{
    public string Role;

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

[RoleAllowed("ADMIN")]
class AdminService
{
    public void SecureTask()
    {
        Console.WriteLine("Admin task executed");
    }
}

class RoleAccessDemo
{
    static void Main()
    {
        Console.Write("Enter role: ");
        string role = Console.ReadLine();

        Type t = typeof(AdminService);
        RoleAllowedAttribute attr = (RoleAllowedAttribute)
            Attribute.GetCustomAttribute(t, typeof(RoleAllowedAttribute));

        if (attr.Role == role)
            t.GetMethod("SecureTask").Invoke(new AdminService(), null);
        else
            Console.WriteLine("Access Denied!");
    }
}

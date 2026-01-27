using System;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Length;

    public MaxLengthAttribute(int len)
    {
        Length = len;
    }
}

class User
{
    [MaxLength(5)]
    public string Username;

    public User(string name)
    {
        if (name.Length > 5)
            throw new ArgumentException("Username too long");
        Username = name;
    }
}

class MaxLengthDemo
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string name = Console.ReadLine();
        try
        {
            User u = new User(name);
            Console.WriteLine("User created");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

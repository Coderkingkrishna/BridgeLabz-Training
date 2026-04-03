using System;
using System.Text.RegularExpressions;

public static class ProfileUtility
{
    public static string FormatName(string name)
    {
        name = name.Trim().ToLower();
        return char.ToUpper(name[0]) + name.Substring(1);
    }

    public static bool IsValidEmail(string email)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }

    public static string GenerateEmail(string name)
    {
        return name.ToLower() + "@techville.com";
    }
}

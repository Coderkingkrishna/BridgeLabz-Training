using System;

public class PasswordBacktrack : IPassword
{
    private bool alreadyFound = false;

    public void PasswordCheck(string password, string result, int idx)
    {
        if (alreadyFound)
            return;

        if (idx == password.Length)
        {
            if (result.Equals(password))
            {
                Console.WriteLine("Password Cracked: " + result);
                alreadyFound = true;
            }
            return;
        }

        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        foreach (char ch in chars)
        {
            PasswordCheck(password, result + ch, idx + 1);
        }
    }

    public string GeneratePassword(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        char[] password = new char[length];
        for (int i = 0; i < length; i++)
        {
            password[i] = chars[random.Next(chars.Length)];
        }
        return new string(password);
    }
}

using System;

class PasswordChecker
{
    IPassword password = new PasswordBacktrack();

    public void CheckPassword()
    {
        Console.WriteLine("Enter the length of the password to generate and crack:");
        int length = Convert.ToInt32(Console.ReadLine());
        string passwordToCrack = password.GeneratePassword(length);
        Console.WriteLine("Generated Password to Crack: " + passwordToCrack);
        DateTime startTime = DateTime.Now;
        password.PasswordCheck(passwordToCrack, "", 0);
        DateTime endTime = DateTime.Now;
        TimeSpan timeTaken = endTime - startTime;
        Console.WriteLine(
            "Time taken to crack the password: " + timeTaken.TotalSeconds + " seconds"
        );
    }
}

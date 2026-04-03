using System;

public class AC : IControllable
{
    public void TurnOn()
    {
        Console.WriteLine("AC is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("AC OFF");
    }
}

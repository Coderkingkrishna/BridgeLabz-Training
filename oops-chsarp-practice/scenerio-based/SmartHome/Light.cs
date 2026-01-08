using System;

public class Light : IControllable
{
    public void TurnOn()
    {
        Console.WriteLine("Light is turned ON with soft brightness");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is turn OFF");
    }
}

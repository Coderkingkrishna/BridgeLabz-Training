using System;

class Fan : IControllable
{
    public void TurnOn()
    {
        Console.WriteLine("Fan is spin");
    }

    public void TurnOff()
    {
        Console.WriteLine("Fan is stopp");
    }
}

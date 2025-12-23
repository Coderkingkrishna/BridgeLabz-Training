using System;

class DayOfWeek
{
    public static void Main()
    {
        int Month = int.Parse(Console.ReadLine());
        int Days = int.Parse(Console.ReadLine());
        int Year = int.Parse(Console.ReadLine());

        int y0 = Year- (14 - Month) / 12;
        int x = y0 + y0/4 - y0/100 + y0/400;
        int m0 = Month + 12 * ((14 - Month) / 12) - 2;
        int d0 = (Days + x + 31*m0 / 12) % 7;

        Console.WriteLine(d0);

    }
}
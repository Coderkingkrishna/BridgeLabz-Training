
using System.Threading;

public class PerformanceTask
{
    public void LongRunningTask()
    {
        Thread.Sleep(3000);
    }
}

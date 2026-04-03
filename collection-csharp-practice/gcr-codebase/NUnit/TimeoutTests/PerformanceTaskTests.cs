
using NUnit.Framework;

[TestFixture]
public class PerformanceTaskTests
{
    [Test]
    [Timeout(2000)]
    public void Performance_Test()
    {
        PerformanceTask t = new PerformanceTask();
        t.LongRunningTask();
    }
}

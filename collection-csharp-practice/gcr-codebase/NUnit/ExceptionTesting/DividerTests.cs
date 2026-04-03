
using NUnit.Framework;

[TestFixture]
public class DividerTests
{
    [Test]
    public void Divide_By_Zero_Test()
    {
        Divider d = new Divider();
        Assert.Throws<System.ArithmeticException>(() => d.Divide(10, 0));
    }
}

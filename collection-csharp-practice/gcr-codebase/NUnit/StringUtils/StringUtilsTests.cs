
using NUnit.Framework;

[TestFixture]
public class StringUtilsTests
{
    private StringUtils utils;

    [SetUp]
    public void Setup()
    {
        utils = new StringUtils();
    }

    [Test]
    public void Palindrome_Test()
    {
        Assert.IsTrue(utils.IsPalindrome("level"));
    }
}

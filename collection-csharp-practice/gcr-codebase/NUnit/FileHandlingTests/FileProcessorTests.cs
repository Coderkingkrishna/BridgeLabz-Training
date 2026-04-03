
using NUnit.Framework;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    private FileProcessor fp;
    private string file = "test.txt";

    [SetUp]
    public void Setup()
    {
        fp = new FileProcessor();
    }

    [Test]
    public void File_Write_Read_Test()
    {
        fp.WriteToFile(file, "hello");
        Assert.IsTrue(File.Exists(file));
        Assert.AreEqual("hello", fp.ReadFromFile(file));
    }
}

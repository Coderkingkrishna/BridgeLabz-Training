
using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    private ListManager manager;
    private List<int> list;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
        list = new List<int>();
    }

    [Test]
    public void Add_Element_Test()
    {
        manager.AddElement(list, 10);
        Assert.AreEqual(1, manager.GetSize(list));
    }
}

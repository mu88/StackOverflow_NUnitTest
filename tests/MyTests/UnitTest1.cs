using MyProject;
using NUnit.Framework;

namespace MyTests;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void MyTest()
    {
        var testee = new Class1();

        var result = testee.Add(1, 2);
        
        Assert.AreEqual(3, result);
    }
}
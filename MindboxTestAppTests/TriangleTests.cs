namespace MindboxTestAppTests;
using MindboxTestLib;
using NUnit.Framework;

public class TriangleTests
{
    [Test]
    public void IsRectangular_10and8and6_TrueReturned()
    {
        var triangle = new Triangle(10, 8, 6);
        var isRect = triangle.IsRectangular;
        Assert.That(isRect, Is.EqualTo(true));
    }
    
    [Test]
    public void IsRectangular_10and7and6_FalseReturned()
    {
        var triangle = new Triangle(10, 7, 6);
        var isRect = triangle.IsRectangular;
        Assert.That(isRect, Is.EqualTo(false));
    }
    
    [Test]
    public void Square_10and8and6_Returned()
    {
        var triangle = new Triangle(10, 8, 6);
        Assert.That(triangle.Square, Is.EqualTo(24));
    }
    
    [Test]
    public void Side_100and8and6_ExceptionReturned()
    {
        var exception = Assert.Throws<Exception>(() => { new Triangle(100, 8, 6); });
        Assert.That(exception.Message, Is.EqualTo("Triangle inequality theorem is disproved."));
    }
    [Test]
    public void Side_0and8and6_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Triangle(0, 8, 6); });
        Assert.That(exception.Message, Is.EqualTo("Side cannot be less or equal to zero."));
    }
}
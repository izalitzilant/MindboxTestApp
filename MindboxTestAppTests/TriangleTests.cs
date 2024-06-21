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
    public void SideMin_0and8and6_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Triangle(0, 8, 6); });
        Assert.That(exception.Message, Is.EqualTo("SideMin cannot be less or equal to zero."));
    }
    [Test]
    public void SideMax_0_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Triangle(0); });
        Assert.That(exception.Message, Is.EqualTo("SideMax cannot be less or equal to zero."));
    }
    [Test]
    public void SideMid_0and0and0given_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Triangle(0, 0, 0); });
        Assert.That(exception.Message, Is.EqualTo("SideMid cannot be less or equal to zero."));
    }
    [Test]
    public void SideMax_5and4and3given_10Returned()
    {
        var triangle = new Triangle(5, 4, 3);
        Assert.That(triangle.sideMax, Is.EqualTo(5));
    }
    [Test]
    public void SideMid_5and4and3given_4Returned()
    {
        var triangle = new Triangle(5, 4, 3);
        Assert.That(triangle.sideMid, Is.EqualTo(4));
    }
    [Test]
    public void SideMin_5and4and3given_3Returned()
    {
        var triangle = new Triangle(5, 4, 3);
        Assert.That(triangle.sideMin, Is.EqualTo(3));
    }
    [Test]
    public void Side_10given_10Returned()
    {
        var triangle = new Triangle(10);
        Assert.That(triangle.sideMax, Is.EqualTo(10));
    }
    
    [Test]
    public void IsEqualiteral_10given_TrueReturned()
    {
        var triangle = new Triangle(10);
        var isRect = triangle.IsEquilateral;
        Assert.That(isRect, Is.EqualTo(true));
    }
    [Test]
    public void IsEqualiteral_10and8and6given_FalseReturned()
    {
        var triangle = new Triangle(10, 8, 6);
        var isEq = triangle.IsEquilateral;
        Assert.That(isEq, Is.EqualTo(false));
    }
}
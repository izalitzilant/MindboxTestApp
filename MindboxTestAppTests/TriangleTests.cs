using MindboxTestLib;
using MindboxTestLib.Models;
using NUnit.Framework;

namespace MindboxTestAppTests;

public class TriangleTests
{
    [Test]
    public void IsRectangular_10and8and6_TrueReturned()
    {
        var triangle = new Triangle(10, 8, 6);
        var isRect = triangle.IsRectangular();
        Assert.That(isRect, Is.EqualTo(true));
    }
    [Test]
    public void IsRectangular_10and7and6_FalseReturned()
    {
        var triangle = new Triangle(10, 7, 6);
        var isRect = triangle.IsRectangular();
        Assert.That(isRect, Is.EqualTo(false));
    }
    [Test]
    public void Square_10and8and6_Returned()
    {
        var calc = new SquareCalculator();
        var triangle = new Triangle(10, 8, 6);
        Assert.That(calc.GetSquare(triangle), Is.EqualTo(24));
    }
    [Test]
    public void Side_100and8and6_ExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Triangle(100, 8, 6); });
        Assert.That(exception.Message, Is.EqualTo("Triangle rule doesn't hold"));
    }
    [Test]
    public void SideMin_0and8and6_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Triangle(0, 8, 6); });
        Assert.That(exception.Message, Is.EqualTo("Invalid arguments: side must be positive"));
    }
    [Test]
    public void SideMid_0and0and0given_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Triangle(0, 0, 0); });
        Assert.That(exception.Message, Is.EqualTo("Invalid arguments: side must be positive"));
    }
    [Test]
    public void SideMax_5and4and3given_10Returned()
    {
        var triangle = new Triangle(5, 4, 3);
        Assert.That(triangle.side1, Is.EqualTo(5));
    }
    [Test]
    public void SideMid_5and4and3given_4Returned()
    {
        var triangle = new Triangle(5, 4, 3);
        Assert.That(triangle.side2, Is.EqualTo(4));
    }
    [Test]
    public void SideMin_5and4and3given_3Returned()
    {
        var triangle = new Triangle(5, 4, 3);
        Assert.That(triangle.side3, Is.EqualTo(3));
    }
}
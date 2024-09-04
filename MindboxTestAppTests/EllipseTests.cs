using MindboxTestLib;
using MindboxTestLib.Models;

namespace MindboxTestAppTests;

public class EllipseTest
{
    [Test]
    public void Square_5and10_SquareReturned()
    {
        var calc = new SquareCalculator();
        var ellipse = new Ellipse(5, 10);
        var trueSquare = Math.PI * 5 * 10;
        Assert.That(calc.GetSquare(ellipse), Is.EqualTo(trueSquare));
    }
    [Test]
    public void RadiusX_5and10given_5Returned()
    {
        var ellipse = new Ellipse(5, 10);
        Assert.That(ellipse.radiusX, Is.EqualTo(5));
    }
    [Test]
    public void RadiusY_5and10given_10Returned()
    {
        var ellipse = new Ellipse(5, 10);
        Assert.That(ellipse.radiusY, Is.EqualTo(10));
    }
    [Test]
    public void Radius_0and8_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Ellipse(0, 8); });
        Assert.That(exception.Message, Is.EqualTo("Invalid arguments: side must be positive"));
    }
    [Test]
    public void Radius_8and0_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Ellipse(0, 8); });
        Assert.That(exception.Message, Is.EqualTo("Invalid arguments: side must be positive"));
    }
}
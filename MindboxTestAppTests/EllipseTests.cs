using MindboxTestLib;
namespace MindboxTestAppTests;

public class EllipseTest
{
    [Test]
    public void Square_5and10_SquareReturned()
    {
        var ellipse = new Ellipse(5, 10);
        var trueSquare = Math.PI * 5 * 10;
        Assert.That(ellipse.Square, Is.EqualTo(trueSquare));
    }
    [Test]
    public void RadiusX_5and10given_5Returned()
    {
        var ellipse = new Ellipse(5, 10);
        Assert.That(ellipse.RadiusX, Is.EqualTo(5));
    }
    [Test]
    public void RadiusY_5and10given_10Returned()
    {
        var ellipse = new Ellipse(5, 10);
        Assert.That(ellipse.RadiusY, Is.EqualTo(10));
    }
    [Test]
    public void Radius_0and8_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Ellipse(0, 8); });
        Assert.That(exception.Message, Is.EqualTo("radiusX cannot be less or equal to zero"));
    }
    [Test]
    public void Radius_8and0_ArgumentExceptionReturned()
    {
        var exception = Assert.Throws<ArgumentException>(() => { new Ellipse(8, 0); });
        Assert.That(exception.Message, Is.EqualTo("radiusY cannot be less or equal to zero"));
    }
}
namespace MindboxTestAppTests;
using MindboxTestLib;

public class CircleTests
{
    [Test]
    public void Square_5given_SquareReturned()
    {
        var circle = new Circle(5);
        var square = Math.PI * Math.Pow(5, 2);
        Assert.That(circle.Square, Is.EqualTo(square));
    }
    
    [Test]
    public void Square_0given_ArgumentExceptionThrown()
    {
        var exception = Assert.Throws<ArgumentException>(() => new Circle(0));
        Assert.That(exception.Message, Is.EqualTo("radiusX cannot be less or equal to zero"));
    }
}
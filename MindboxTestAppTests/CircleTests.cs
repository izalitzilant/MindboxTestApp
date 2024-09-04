using MindboxTestLib;
using MindboxTestLib.Models;

namespace MindboxTestAppTests;

public class CircleTests
{
    [Test]
    public void Square_5given_SquareReturned()
    {
        var calc = new SquareCalculator();
        var circle = new Circle(5);
        var square = Math.PI * Math.Pow(5, 2);
        Assert.That(calc.GetSquare(circle), Is.EqualTo(square));
    }
    
    [Test]
    public void Square_0given_ArgumentExceptionThrown()
    {
        var exception = Assert.Throws<ArgumentException>(() => new Circle(0));
        Assert.That(exception.Message, Is.EqualTo("Invalid arguments: side must be positive"));
    }    
}
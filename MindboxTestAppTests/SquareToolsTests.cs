using MindboxTestLib;

namespace MindboxTestAppTests;

public class SquareToolsTests
{
    [Test]
    public void SquareToolsTest()
    {
        var triangle_square = SquareTools.S(new Triangle(5, 4, 3));
        Assert.That(triangle_square, Is.EqualTo(6));
    }
}
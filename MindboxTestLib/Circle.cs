namespace MindboxTestLib;

public class Circle: PlaneFigure
{
    public new double Square => base.Square;

    public Circle(double radius)
    {
        var circle = new Ellipse(radius, radius);
        base.Square = circle.Square;
    }
}
namespace MindboxTestLib;

public class Circle: PlaneFigure, IPlaneFigure
{
    public new double Square => base.Square;
    public double GetSquare()
    {
        return Square;
    }

    public Circle(double radius)
    {
        var circle = new Ellipse(radius, radius);
        base.Square = circle.Square;
    }
}
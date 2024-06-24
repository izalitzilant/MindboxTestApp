namespace MindboxTestLib;

public class Ellipse: PlaneFigure, IPlaneFigure
{
    private double _radiusX;
    private double _radiusY;
    
    public double RadiusX
    {
        get => _radiusX;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("radiusX cannot be less or equal to zero");
            }
            _radiusX = value;
        }
    }
    public double RadiusY
    {
        get => _radiusY;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("radiusY cannot be less or equal to zero");
            }
            _radiusY = value;
        }
    }
    
    public new double Square => base.Square;
    public double GetSquare()
    {
        return Square;
    }

    public Ellipse(double radiusX, double radiusY)
    {
        RadiusX = radiusX;
        RadiusY = radiusY;
        base.Square = GetSquare(radiusX, radiusY);
    }
    private double GetSquare(double radiusA, double radiusB)
    {
         return Math.PI * radiusA * radiusB;
    }
}
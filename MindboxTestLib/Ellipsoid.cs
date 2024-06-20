namespace MindboxTestLib;

public class Ellipsoid: PlaneFigure
{
    #region 
    
    private double _radiusX;
    private double _radiusY;
    
    public double radiusX
    {
        get => _radiusX;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("radiusX cannot be less or equal to zero");
            }
        }
    }
    public double radiusY
    {
        get => _radiusY;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("radiusY cannot be less or equal to zero");
            }
        }
    }
    
    #endregion

    public new double Square => base.Square;

    public Ellipsoid(double radiusA, double radiusB)
    {
        radiusX = radiusA;
        radiusY = radiusB;
        base.Square = GetSquare(radiusA, radiusB);
    }
    private double GetSquare(double radiusA, double radiusB)
    {
         return Math.PI * radiusA * radiusB;
    }
}
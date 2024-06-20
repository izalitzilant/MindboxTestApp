namespace MindboxTestLib;

public class Triangle : PlaneFigure
{
    # region 
    private double _sideMax;
    private double _sideMin;
    private double _sideMid;

    public double sideMax
    {
        get => _sideMax;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Side cannot be less or equal to zero.");
            }
            
            _sideMax = value;
        }
    }
    public double sideMid
    {
        get => _sideMid;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Side cannot be less or equal to zero.");
            }

            _sideMid = value;
        }
    }
    public double sideMin
    {
        get => _sideMin;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Side cannot be less or equal to zero.");
            }

            _sideMin = value;
        }
    }
    
    #endregion
    public new double Square => base.Square;
    public bool IsRectangular { get; private set; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        double perimeter = sideA + sideB + sideC;
        
        sideMax = Math.Max(sideA, Math.Max(sideB, sideC));
        sideMin = Math.Min(sideA, Math.Min(sideB, sideC));
        sideMid = perimeter - sideMax - sideMin;

        if (sideMax >= sideMid + sideMin)
        {
            throw new Exception("Triangle inequality theorem is disproved.");
        }

        IsRectangular = CheckPythagorean(sideMax, sideMid, sideMin);
        base.Square = HeronsFormula(perimeter, sideA, sideB, sideC);
    }
    bool CheckPythagorean(double hypotenuze, double catet1, double catet2)
    { 
        return Math.Pow(hypotenuze, 2) == Math.Pow(catet1, 2) + Math.Pow(catet2, 2);
    }
    
    double HeronsFormula(double perim, double sideA, double sideB, double sideC)
    {
        perim /= 2;
        var s = perim * (perim - sideA) * (perim - sideB) * (perim - sideC);
        return Math.Sqrt(s);
    }
}


namespace MindboxTestLib;

public class Triangle : PlaneFigure
{
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
                throw new ArgumentException("SideMax cannot be less or equal to zero.");
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
                throw new ArgumentException("SideMid cannot be less or equal to zero.");
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
                throw new ArgumentException("SideMin cannot be less or equal to zero.");
            }

            _sideMin = value;
        }
    }
    public new double Square => base.Square;
    public bool IsRectangular { get; private set; }
    public bool IsEquilateral { get; private set; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        var perimeter = sideA + sideB + sideC;
        var maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
        var minSide = Math.Min(sideA, Math.Min(sideB, sideC));
        var midSide = perimeter - maxSide - minSide;
        sideMid = midSide;
        sideMax = maxSide;
        sideMin = minSide;
        if (sideMax >= sideMid + sideMin)
        {
            throw new Exception("Triangle inequality theorem is disproved.");
        }
        IsEquilateral = false;
        IsRectangular = CheckPythagorean(_sideMax, _sideMid, _sideMin);
        base.Square = HeronsFormula(perimeter, _sideMax, _sideMid, _sideMin);
    }

    public Triangle(double side)
    {
        var perimeter = 3 * side;
        sideMax = side;
        sideMid = side;
        sideMin = side;
        IsRectangular = false;
        IsEquilateral = true;
        base.Square = HeronsFormula(perimeter, _sideMax, _sideMid, _sideMin);
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


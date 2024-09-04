namespace MindboxTestLib.Models
{
    public class Ellipse : PlaneFigure
    {
        public double radiusX {get; private set;}
        public double radiusY {get; private set;}
        public Ellipse(double radiusX, double radiusY)
        {
            if (radiusX <= 0 | radiusY <= 0){
                throw new ArgumentException("Invalid arguments: side must be positive");
            }
            this.radiusX = radiusX;
            this.radiusY = radiusY;
        }
        public override double Square()
        {
            return Math.PI * radiusX * radiusY;
        }
    }
}
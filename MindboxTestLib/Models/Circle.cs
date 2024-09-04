namespace MindboxTestLib.Models
{
    public class Circle: PlaneFigure
    {
        protected Ellipse circle {get; private set;}
        public Circle(double radius)
        {
            circle = new Ellipse(radius, radius);
        }

        public override double Square()
        {
            return circle.Square();
        }
    }
}
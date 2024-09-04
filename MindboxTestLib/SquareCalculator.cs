using MindboxTestLib.Interfaces;
using MindboxTestLib.Models;

namespace MindboxTestLib
{
    public class SquareCalculator: ISquareCalculator
    {
        public double GetSquare(PlaneFigure figure) {
            return figure.Square();
        }
    }
}
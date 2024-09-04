
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MindboxTestLib.Models
{
    public class Triangle: PlaneFigure
    {
        public double side1 { get; private set; }
        public double side2 { get; private set; }
        public double side3 { get; private set; }

        public Triangle(double side1, double side2, double side3) {
            if (side1 <= 0 | side2 <= 0 | side3 <= 0) {
                throw new ArgumentException("Invalid arguments: side must be positive");
            }
            if (!Triangle.TriangleRuleCheck(side1, side2, side3)) {
                throw new ArgumentException("Triangle rule doesn't hold");
            }
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double Square() {            // still O(n) - so its okay
            var p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public bool IsRectangular(){
            var sideList = new [] {side1, side2, side3};
            var hypo = sideList.Max();
            var cat1 = sideList.Min();
            var cat2 = sideList.Sum() - hypo - cat1;

            if (Math.Pow(hypo, 2) == Math.Pow(cat1, 2) + Math.Pow(cat2, 2)) {
                return true;
            }

            return false;
        }


        private static bool TriangleRuleCheck(double side1, double side2, double side3){
            if (side1 >= side2 + side3 | side2 >= side1 + side3 | side3 >= side1 + side2) {
                return false;
            }
            return true;
        }
    }
}


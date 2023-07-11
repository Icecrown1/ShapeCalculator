using System;

namespace ShapeCalculatorLibrary
{
    public class AreaCalculatorVisitor : ShapeVisitor
    {
        public override double Visit(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        public override double Visit(Triangle triangle)
        {
            double semiperimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - triangle.SideA) * (semiperimeter - triangle.SideB) * (semiperimeter - triangle.SideC));
        }
    }
}


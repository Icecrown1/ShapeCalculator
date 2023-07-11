using System;

namespace ShapeCalculatorLibrary
{
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Accept(ShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public bool IsRightTriangle()
        {
            // Проверяем теорему Пифагора
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);

            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }
    }
}
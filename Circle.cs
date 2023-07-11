namespace ShapeCalculatorLibrary
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Accept(ShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}

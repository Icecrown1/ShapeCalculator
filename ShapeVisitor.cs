namespace ShapeCalculatorLibrary
{
    public abstract class ShapeVisitor
    {
        public abstract double Visit(Circle circle);
        public abstract double Visit(Triangle triangle);
    }
}

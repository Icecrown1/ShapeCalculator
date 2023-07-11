namespace ShapeCalculatorLibrary
{
    public interface IShape
    {
        double Accept(ShapeVisitor visitor);
    }

}

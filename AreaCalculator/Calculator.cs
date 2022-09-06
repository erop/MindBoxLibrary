using AreaCalculator.Shapes;

namespace AreaCalculator;

public class Calculator : ICalculator
{
    public double CalculateArea(IShape shape)
    {
        return shape.GetArea();
    }
}
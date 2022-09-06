using AreaCalculator.Shapes;

namespace AreaCalculator;

public interface ICalculator
{
    double CalculateArea(IShape shape);
}
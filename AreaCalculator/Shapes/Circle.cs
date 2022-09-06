namespace AreaCalculator.Shapes;

public class Circle : IShape
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; init; }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
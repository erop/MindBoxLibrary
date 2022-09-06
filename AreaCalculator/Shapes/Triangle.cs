namespace AreaCalculator.Shapes;

public class Triangle : IShape
{
    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public Triangle(double a)
    {
        A = B = C = a;
        Type = TriangleType.Equilateral;
    }

    public Triangle(double a, double b)
    {
        A = B = a;
        C = b;
        Type = TriangleType.Isosceles;
    }

    public double A { get; init; }
    public double B { get; init; }
    public double C { get; init; }

    public TriangleType Type { get; init; } = TriangleType.Versatile;

    public double GetArea()
    {
        var perimeter = A + B + C;
        var semiperimeter = perimeter / 2;

        return Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
    }

    public bool IsRightTriangle()
    {
        if (Type == TriangleType.Equilateral) return false;

        var sides = new List<double> {A, B, C};
        var longestSide = sides.Max();
        var longestIndex = sides.IndexOf(longestSide);
        sides.RemoveAt(longestIndex);

        return Math.Pow(longestSide, 2).Equals(sides.Sum(s => Math.Pow(s, 2)));
    }
}
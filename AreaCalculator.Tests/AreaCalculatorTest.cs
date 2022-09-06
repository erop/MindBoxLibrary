using AreaCalculator.Shapes;

namespace AreaCalculator.Tests;

public class AreaCalculatorTest
{
    [Fact]
    public void CircleAreaCalculation()
    {
        var calculator = CreateCalculator();
        var shape = CreateCircle(10f);
        Assert.Equal(Math.PI * Math.Pow(10f, 2), calculator.CalculateArea(shape));
    }

    [Fact]
    public void TriangleAreaCalculation()
    {
        var calculator = CreateCalculator();
        var shape = CreateTriangle(3d, 4d, 5d);
        Assert.Equal(Math.Sqrt(6 * 3 * 2 * 1), calculator.CalculateArea(shape));
    }

    private Circle CreateCircle(float radius)
    {
        return new Circle(radius);
    }

    private ICalculator CreateCalculator()
    {
        return new Calculator();
    }

    [Fact]
    public void CheckTriangleIsRight()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void CheckTriangleIsNotRight()
    {
        var triangle = new Triangle(3, 5, 5);
        Assert.False(triangle.IsRightTriangle());
    }

    private Triangle CreateTriangle(double a, double b, double c)
    {
        return new Triangle(a, b, c);
    }
}
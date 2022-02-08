namespace MindBoxTestTask.Tests.Services.Calculators;

public class CircleCalculatorServiceTest
{
    [Theory]
    [InlineData(10, 314)]
    [InlineData(1, 3)]
    [InlineData(-1, 3)]
    [InlineData(-2.5, 3)]
    public void CircleCalculatorService_CalculateSquare_True(int radius, double expectedResult)
    {
        Circle circle = new(radius);

        var result = CalculateSquare(circle);

        Assert.Equal(expected: expectedResult, actual: result);
    }

    private int CalculateSquare(Circle circle)
    {
        if (circle.Radius < 0)
            throw new ArgumentException(
                message: "Радиус фигуры не может быть отрицательным");

        return (int)(Math.PI * circle.Radius * circle.Radius);
    }
}
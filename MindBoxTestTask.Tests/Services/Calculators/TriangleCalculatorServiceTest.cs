namespace MindBoxTestTask.Tests.Services.Calculators;

public class TriangleCalculatorServiceTest
{
    [Theory]
    [InlineData(10, 10, 10, 43)]
    [InlineData(3, 4, 5, 6)]
    public void TriangleCalculatorService_CalculateSquare_True(int a, int b, int c, double expectedResult)
    {
        Triangle triangle = new(a, b, c);

        var result = CalculateSquare(triangle);

        Assert.Equal(expected: expectedResult, actual: result);
    }

    private int CalculateSquare(Triangle triangle)
    {
        if (triangle.A < 1 | triangle.B < 1 | triangle.C < 1)
            throw new ArgumentException("Стороны треугольника не могут быть меньше нуля");

        // Используем формулу Герона для нахождения площади треугольника
        // по трем сторонам:

        double p = (triangle.A + triangle.B + triangle.C) / 2;

        double s = Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));

        // Возвращаем ответ
        return (int)s;
    }
}
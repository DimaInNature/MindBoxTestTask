namespace MindBoxTestTask.Services.Calculators;

public class TriangleCalculatorService : IShapeCalculator<Triangle>
{
    /// <summary> Вычисляет площадь треугольника по формуле Герона </summary>

    public double CalculateSquare(Triangle triangle)
    {
        // Используем формулу Герона для нахождения площади треугольника
        // по трем сторонам:

        var (a, b, c) = triangle.GetData();

        double p = (a + b + c) / 2;

        double square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        // Возвращаем ответ

        return square;
    }
}
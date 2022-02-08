namespace MindBoxTestTask.Services.Calculators;

public class TriangleCalculatorService : IShapeCalculator<Triangle>
{
    public int CalculateSquare(Triangle triangle)
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


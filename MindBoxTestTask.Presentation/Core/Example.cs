namespace MindBoxTestTask.Presentation.Core;

public static class Example
{
    private static readonly IShapeCalculator<Triangle> _triangleCalculator;
    private static readonly IShapeCalculator<Circle> _circleCalculator;

    static Example()
    {
        // Внедряем зависимости
        _triangleCalculator = Program.ServiceProvider
            .GetService<IShapeCalculator<Triangle>>()
            ?? throw new ArgumentNullException(nameof(_triangleCalculator));

        _circleCalculator = Program.ServiceProvider
            .GetService<IShapeCalculator<Circle>>()
            ?? throw new ArgumentNullException(nameof(_circleCalculator));
    }

    public static void Start(Triangle triangle, Circle circle)
    {
        // находим площади фигур
        var triangleSquare = _triangleCalculator.CalculateSquare(triangle);

        var circleSquare = _circleCalculator.CalculateSquare(circle);

        // выводим сообщение на экран с информацией

        Console.WriteLine($"Triangle (a:{triangle.A}, b:{triangle.B}, c:{triangle.C}) square is {triangleSquare}.\n" +
            $"Is rectangular: {triangle.IsRectangular()}\n");

        Console.WriteLine($"Circle (radius: {circle.Radius}) square is {circleSquare}");
    }
}

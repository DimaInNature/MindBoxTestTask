namespace MindBoxTestTask.Services.Startup;

public class StartupExampleService
{
    private readonly IShapeCalculator<Triangle>? _triangleCalculator;
    private readonly IShapeCalculator<Circle>? _circleCalculator;

    public StartupExampleService(IShapeCalculator<Triangle> triangleCalculator,
        IShapeCalculator<Circle> shapeCalculator) =>
        (_triangleCalculator, _circleCalculator) = (triangleCalculator, shapeCalculator);

    /// <summary> Запускает демонстрацию </summary>

    public void Start(Triangle triangle, Circle circle)
    {
        // находим площади фигур

        var triangleSquare = _triangleCalculator?.CalculateSquare(shape: triangle);

        var circleSquare = _circleCalculator?.CalculateSquare(shape: circle);

        // выводим сообщение на экран с информацией

        Console.WriteLine(
            $"Triangle ({triangle}) square is {triangleSquare}.\n" +
            $"Is rectangular: {triangle.IsRectangular()}\n" +
            $"Circle ({circle}) square is {circleSquare}");
    }
}
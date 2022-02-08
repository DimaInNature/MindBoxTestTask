namespace MindBoxTestTask.Services.Calculators;

public class CircleCalculatorService : IShapeCalculator<Circle>
{
    public int CalculateSquare(Circle circle)
    {
        // Выполняем проверку. Радиус не может быть отрицательным.
        if (circle.Radius < 0)
            throw new ArgumentException(
                message: "Радиус фигуры не может быть отрицательным");

        // Формула площади будет: π*Radius^2
        return (int)(Math.PI * circle.Radius * circle.Radius);
    }
}

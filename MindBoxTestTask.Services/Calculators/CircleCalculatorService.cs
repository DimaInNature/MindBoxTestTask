namespace MindBoxTestTask.Services.Calculators;

public class CircleCalculatorService : IShapeCalculator<Circle>
{
    public double CalculateSquare(Circle circle)
    {
        int radius = circle.GetData();

        double square = Math.PI * radius * radius;

        return square;
    }
}
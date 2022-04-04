namespace MindBoxTestTask.Services.Abstract.Calculators;

public interface IShapeCalculator<T>
    where T : IShape
{
    double CalculateSquare(T shape);
}
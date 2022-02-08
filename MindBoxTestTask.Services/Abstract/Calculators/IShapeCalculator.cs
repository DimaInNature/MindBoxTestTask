namespace MindBoxTestTask.Services.Abstract.Calculators;

public interface IShapeCalculator<T>
    where T : IShape
{
    int CalculateSquare(T shape);
}
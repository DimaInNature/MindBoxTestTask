namespace MindBoxTestTask.Domain.Shapes;

public record struct Triangle : IShape
{
    /// <summary> Первая сторона </summary>

    private readonly int _a;

    /// <summary> Вторая сторона </summary>

    private readonly int _b;

    /// <summary> Третья сторона </summary>

    private readonly int _c;

    public Triangle(int a, int b, int c)
    {
        if (IsValidData(a, b, c) is false)
            throw new ArgumentException(message: "Треугольник не существует");

        (_a, _b, _c) = (a, b, c);
    }

    /// <summary> Метод возвращающих кортеж данных о треугольнике </summary>

    public (int a, int b, int c) GetData() => (_a, _b, _c);

    public override string ToString() => $"a: {_a}, b: {_b}, c: {_c}";

    /// <summary> Метод, который показывает, является ли фигура треугольником </summary>

    public bool IsRectangular()
    {
        var (a, b, c) = (_a * _a, _b * _b, _c * _c);

        return (a + b == c)
           | (a + c == b)
           | (c + b == a);
    }

    /// <summary> Простейший валидатор </summary>

    private static bool IsValidData(int a, int b, int c) =>
       (a + b > c) | (b + c > a) | (c + a > b) | a < 1 | b < 1 | c < 1;
}
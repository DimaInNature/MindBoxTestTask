namespace MindBoxTestTask.Domain.Shapes;

public record struct Circle : IShape
{
    /// <summary> Радиус круга </summary>

    private readonly int _radius;

    public Circle(int radius)
    {
        if (IsValidData(radius) is false)
            throw new ArgumentException(message: "Создание круга с введёнными данными - невозможно");

        _radius = radius;
    }

    public override string ToString() => $"radius: {_radius}";

    /// <summary> Возвращает данные об объекте </summary>

    public int GetData() => _radius;

    /// <summary> Простейший валидатор </summary>

    private static bool IsValidData(int radius) => radius > 0;
}
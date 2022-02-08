namespace MindBoxTestTask.Domain.Shapes;

public struct Triangle : IShape
{
    public Triangle(int a, int b, int c)
    {
        bool isCorrect = (a + b > c) | (b + c > a) | (c + a > b);

        (A, B, C) = isCorrect
            ? (a, b, c)
            : throw new ArgumentException(message: "Треугольник не существует");
    }

    // Изменяем дефолтные аксессоры, добавляем им логики.

    // Значение стороны не может быть меньше единицы.

    public int A
    {
        get => _a < 1
            ? 1
            : _a;
        set => _a = value < 1
            ? 1
            : _a = value;
    }

    private int _a = 1;

    public int B
    {
        get => _b < 1
            ? 1
            : _b;
        set => _b = value < 1
            ? 1
            : _b = value;
    }

    private int _b = 1;

    public int C
    {
        get => _c < 1
            ? 1
            : _c;
        set => _c = value < 1
            ? 1 :
            _c = value;
    }

    private int _c = 1;
}
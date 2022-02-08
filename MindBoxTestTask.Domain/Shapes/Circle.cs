namespace MindBoxTestTask.Domain.Shapes;

public struct Circle : IShape
{
    public Circle(int radius) =>
        Radius = radius;

    public int Radius
    {
        get => _radius < 1
            ? 1
            : _radius;
        set => _radius = value < 1
            ? 1
            : value;
    }

    private int _radius = 1;
}
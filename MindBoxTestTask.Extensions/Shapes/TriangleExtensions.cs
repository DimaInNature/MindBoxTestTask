namespace MindBoxTestTask.Exstensions.Shapes;

public static class TriangleExtensions
{
    public static bool IsRectangular(this Triangle triangle)
    {
        (int a, int b, int c) = (triangle.A, triangle.B, triangle.C);

        return ((a * a) + (b * b) == c * c)
            | ((a * a) + (c * c) == b * b)
            | ((c * c) + (b * b) == a * a);
    }
}

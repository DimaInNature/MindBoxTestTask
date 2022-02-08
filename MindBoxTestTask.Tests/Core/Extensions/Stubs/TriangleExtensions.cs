namespace MindBoxTestTask.Tests.Core.Extensions.Stubs;

internal static class TriangleExtensions
{
    public static bool IsRightTriangle(this Triangle triangle)
    {
        (int a, int b, int c) = (triangle.A, triangle.B, triangle.C);

        return ((a * a) + (b * b) == c * c)
            | ((a * a) + (c * c) == b * b)
            | ((c * c) + (b * b) == a * a);
    }
}

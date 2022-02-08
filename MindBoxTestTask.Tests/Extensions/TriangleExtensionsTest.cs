namespace MindBoxTestTask.Tests.Extensions;

public class TriangleExtensionsTest
{
    [Theory]
    [InlineData(4, 3, 5)]
    public void TriangleExtensions_IsRightTriangle_True(int a, int b, int c)
    {
        Triangle triangle = new(a, b, c);

        var result = triangle.IsRightTriangle();

        Assert.True(result);
    }

    [Theory]
    [InlineData(5, 3, 5)]
    public void TriangleExtensions_IsRightTriangle_False(int a, int b, int c)
    {
        Triangle triangle = new(a, b, c);

        var result = triangle.IsRightTriangle();

        Assert.False(result);
    }
}

namespace MindBoxTestTask.Tests.Extensions;

public class TriangleExtensionsTest
{
    [Theory]
    [InlineData(4, 3, 5)]
    public void TriangleExtensions_IsRectangular_True(int a, int b, int c)
    {
        Triangle triangle = new(a, b, c);

        var result = triangle.IsRectangular();

        Assert.True(result);
    }

    [Theory]
    [InlineData(5, 3, 5)]
    public void TriangleExtensions_IsRectangular_False(int a, int b, int c)
    {
        Triangle triangle = new(a, b, c);

        var result = triangle.IsRectangular();

        Assert.False(result);
    }
}

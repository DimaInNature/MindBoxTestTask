namespace MindBoxTestTask.Tests.Domain.Models;

public class TriangleTest
{
    [Theory]
    [InlineData(4, 3, 5)]
    public void Triangle_IsRectangular_True(int a, int b, int c)
    {
        // Arrange

        Triangle triangle = new(a, b, c);

        // Act

        var result = triangle.IsRectangular();

        // Assert

        Assert.True(result);
    }
}
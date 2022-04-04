namespace MindBoxTestTask.Tests.Services.Calculators;

public class TriangleCalculatorServiceTest
{
    private readonly TriangleCalculatorService _fixture = new();

    [Theory]
    [InlineData(10, 10, 10, 43.30127018922193)]
    [InlineData(3, 4, 5, 6)]
    public void TriangleCalculatorService_CalculateSquare_True(int a, int b, int c, double expectedResult)
    {
        // Arrange

        Triangle triangle = new(a, b, c);

        // Act

        var result = _fixture.CalculateSquare(triangle);

        // Assert

        Assert.Equal(expected: expectedResult, actual: result);
    }
}
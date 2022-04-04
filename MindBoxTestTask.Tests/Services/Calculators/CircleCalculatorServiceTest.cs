namespace MindBoxTestTask.Tests.Services.Calculators;

public class CircleCalculatorServiceTest
{
    private readonly CircleCalculatorService _fixture = new();

    [Theory]
    [InlineData(10, 314.1592653589793)]
    [InlineData(1, Math.PI)]
    public void CircleCalculatorService_CalculateSquare_True(int radius, double expectedResult)
    {
        // Arrange

        Circle circle = new(radius);

        // Act

        var result = _fixture.CalculateSquare(circle);

        // Assert

        Assert.Equal(expected: expectedResult, actual: result);
    }
}
namespace MindBoxTestTask.Presentation;

public class Program
{
    public static IServiceProvider ServiceProvider;

    static void Main(string[] args)
    {
        var services = new ServiceCollection();

        ConfigureServices(services);

        ServiceProvider = services.BuildServiceProvider();

        Triangle triangle = new(a: 3, b: 4, c: 5);

        Circle circle = new(radius: 10);

        Example.Start(triangle, circle);

        Console.ReadLine();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IShapeCalculator<Triangle>, TriangleCalculatorService>();
        services.AddTransient<IShapeCalculator<Circle>, CircleCalculatorService>();
    }
}

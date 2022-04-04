namespace MindBoxTestTask.Presentation;

public class Program
{
    private static void Main(string[] args)
    {
        // Создаём коллекцию сервисов
        // и запускаем механизм внедрения зависимостей

        ServiceCollection services = new();

        ConfigureServices(services);

        IServiceProvider serviceProvider = services.BuildServiceProvider();

        // Создание тестовых данных

        Triangle triangle = new(a: 3, b: 4, c: 5);

        Circle circle = new(radius: 10);

        // Запуск тестового сервиса

        serviceProvider.GetStartupService()?.Start(triangle, circle);

        Console.ReadLine();
    }

    /// <summary> Конфигуратор IoC контейнера </summary>

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddTransient<IShapeCalculator<Triangle>, TriangleCalculatorService>();
        services.AddTransient<IShapeCalculator<Circle>, CircleCalculatorService>();
        services.AddSingleton<StartupExampleService>();
    }
}

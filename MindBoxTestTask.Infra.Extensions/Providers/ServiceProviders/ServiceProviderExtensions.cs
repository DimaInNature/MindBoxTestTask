namespace MindBoxTestTask.Infra.Extensions.Providers.ServiceProviders;

public static class ServiceProviderExtensions
{
    /// <summary> Находит сервис, который отвечает за демонстрацию функционала </summary>

    public static StartupExampleService? GetStartupService(this IServiceProvider serviceProvider) =>
        serviceProvider.GetService<StartupExampleService>();
}
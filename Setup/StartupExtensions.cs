using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProjectUsingsUsage.Cqrs;

namespace ProjectUsingsUsage.Setup;
internal static class StartupExtensions
{
    public static void ConfigureAppServices(this ServiceCollection services)
    {
        services
            .AddLogging(configure => configure.AddDebug())
            .AddScoped<AnyCommandOrQueryProcessor>()
            .AddScoped<MainForm>();
    }
}

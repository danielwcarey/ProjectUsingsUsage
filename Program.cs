using Microsoft.Extensions.DependencyInjection;
using ProjectUsingsUsage.Setup;

namespace ProjectUsingsUsage;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var services = new ServiceCollection();
        services.ConfigureAppServices();
        using var serviceProvider = services.BuildServiceProvider();

        var form1 = serviceProvider.GetRequiredService<MainForm>();

        Application.Run(form1);
    }
}
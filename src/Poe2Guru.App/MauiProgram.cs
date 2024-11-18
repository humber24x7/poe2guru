using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Poe2Guru.Application.Services;
using Poe2Guru.Infrastructure;

namespace Poe2Guru.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        
        // Add configuration file.
        var assembly = Assembly.GetExecutingAssembly();
        using var stream = assembly.GetManifestResourceStream("Poe2Guru.App.appsettings.json");
        builder.Configuration.AddJsonStream(stream);
        
        // Add infrastructure services.
        builder.Services.AddInfrastructure(builder.Configuration);
        
        // Add application services.
        builder.Services.AddSingleton<UserService>();
        
        // Add application use cases.
        

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
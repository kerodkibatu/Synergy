using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Synergy.MVVM.ViewModel;

namespace Synergy;
public static class MauiProgram
{
    public static AppVM VM;
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        VM = new();
#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
using MauiEdit.Services;
using Microsoft.Extensions.Logging;
using WinFormsCommandBinding.Models.Service;

namespace MauiEdit;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        // We pass the dialog service to the service provider, so we can use it in the view models.
        builder.Services.AddSingleton(typeof(IDialogService), new MauiDialogService());

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

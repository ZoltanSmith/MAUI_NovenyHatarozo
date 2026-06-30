using Microsoft.Extensions.Logging;
using MAUI_NovenyHatarozo.ViewModel;
using MAUI_NovenyHatarozo.Pages;

namespace MAUI_NovenyHatarozo
{
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
                })
                .Services
                    .AddSingleton<MainVM>()
                    .AddSingleton<MainPage>()
                    .AddSingleton<NovenyListVM>()
                    .AddSingleton<ListPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

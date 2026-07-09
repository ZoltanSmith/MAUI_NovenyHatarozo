using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Views;
using MAUI_NovenyHatarozo.Components;
using MAUI_NovenyHatarozo.Data;
using MAUI_NovenyHatarozo.Pages;
using MAUI_NovenyHatarozo.Repository;
using MAUI_NovenyHatarozo.Services;
using MAUI_NovenyHatarozo.ViewModel;
using Microsoft.Extensions.Logging;

namespace MAUI_NovenyHatarozo
{
    public static class MauiProgram
    {
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
                })
                .Services
                    .AddSingleton<MainVM>()
                    .AddSingleton<MainPage>()
                    .AddSingleton<NovenyListVM>()
                    .AddSingleton<ListPage>()
                    .AddSingleton<SoundService>()
                    .AddDbContextFactory<AppDbContext>()
#if DEBUG
                    .AddTransient<INovenyRepository, TestRepo>();
#else
                    .AddTransient<INovenyRepository, SqliteRepo>();
#endif

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

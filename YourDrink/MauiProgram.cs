using Microsoft.Extensions.Logging;
using YourDrink.Services;
using CommunityToolkit.Maui;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace YourDrink
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("MaterialIcons-Regular.ttf", "GoogleFont");
                    fonts.AddFont("MaterialIconsOutlined-Regular.otf", "GoogleFontOutline");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder
                .RegisterAppServices()
                .RegisterViewModels()
                .RegisterViews();

            return builder.Build();
        }
    }
}
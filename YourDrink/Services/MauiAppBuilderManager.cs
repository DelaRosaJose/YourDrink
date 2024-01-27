using YourDrink.Interfaces;
using YourDrink.ViewModels;
using YourDrink.Views;

namespace YourDrink.Services;
public static class MauiAppBuilderManager
{

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder _mauiAppBuilder)
    {
        _mauiAppBuilder.Services.AddSingleton<IConnectivity>((e) => Connectivity.Current);
        _mauiAppBuilder.Services.AddSingleton<IPopupService, PopupService>();
        _mauiAppBuilder.Services.AddSingleton<HttpService>();

        return _mauiAppBuilder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder _mauiAppBuilder)
    {
        _mauiAppBuilder.Services.AddSingleton<MainViewModel>();

        return _mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder _mauiAppBuilder)
    {
        _mauiAppBuilder.Services.AddSingleton<MainPage>();

        return _mauiAppBuilder;
    }

}

using CommunityToolkit.Maui.Views;
using YourDrink.Interfaces;

namespace YourDrink.Services;
public class PopupService : IPopupService
{
    public void ShowPopup(Popup popup)
    {
        var page = Application.Current?.MainPage?? Shell.Current?? throw new NullReferenceException(message:"No se encontro Application MainPage, y no se encontro Shell Application.");
        page.ShowPopup(popup);
    }
}

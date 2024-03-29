using YourDrink.ViewModels;

namespace YourDrink.Views;

public partial class MainPage : ContentPage
{
    readonly MainViewModel _ViewModel;
    public MainPage(MainViewModel vm)
    {
        BindingContext = _ViewModel = vm;
        InitializeComponent();

        var screenMetrics = DeviceDisplay.MainDisplayInfo;

        if (DeviceInfo.Idiom == DeviceIdiom.Tablet)
        {
            ColletionMostPopular.ItemsLayout = ColletionLastest.ItemsLayout = new GridItemsLayout(3, ItemsLayoutOrientation.Horizontal);
        }
        else if (DeviceInfo.Idiom == DeviceIdiom.Phone && screenMetrics.Height < 1940)
        {
            ColletionMostPopular.ItemsLayout = ColletionLastest.ItemsLayout = new GridItemsLayout(1, ItemsLayoutOrientation.Horizontal);
        }
    }



    //private void Category_Tapped(object sender, TappedEventArgs e)
    //{
    //    Task.Run(() =>
    //    {
    //        var value = ((Label)((Frame)sender).Content).Text;
    //        _ViewModel.SearchByCategoryCommand.Execute(value);
    //    }).Wait();
    //}
}

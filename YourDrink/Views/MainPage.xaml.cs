using YourDrink.ViewModels;

namespace YourDrink.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }


    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var value = ((Label)((Frame)sender).Content).Text;
    }
}

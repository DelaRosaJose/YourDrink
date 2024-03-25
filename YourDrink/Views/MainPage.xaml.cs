using YourDrink.ViewModels;

namespace YourDrink.Views;

public partial class MainPage : ContentPage
{
    readonly MainViewModel _ViewModel;
    public MainPage(MainViewModel vm)
    {
        BindingContext = _ViewModel = vm;
        InitializeComponent();
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

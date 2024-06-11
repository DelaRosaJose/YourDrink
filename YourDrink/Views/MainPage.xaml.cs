using YourDrink.Models;
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

    private void ColletionMostPopular_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private async void TappedMostPopularCocktail(object sender, TappedEventArgs e)
    {
        var id = e.Parameter?.ToString();
        Cocktail cocktail = _ViewModel.MostPopulars.FirstOrDefault(x => x.IdDrink == id);

        if (cocktail == default)
            return;

        //Shell.Current.GoToAsync($"//{nameof(CocktailPage)}");
        var navigationParameter = new ShellNavigationQueryParameters
        {
            { "Cocktail", cocktail }
        };
        await Shell.Current.GoToAsync($"{nameof(CocktailPage)}", navigationParameter);


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

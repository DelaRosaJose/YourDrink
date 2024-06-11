using YourDrink.Models;

namespace YourDrink.Views;

[QueryProperty(nameof(Cocktail), "Cocktail")]
public partial class CocktailPage : ContentPage
{
    Cocktail cocktail;
    public Cocktail Cocktail
    {
        get => cocktail;
        set
        {
            cocktail = value;
            OnPropertyChanged();
            BindingContext = Cocktail;
        }
    }

    public CocktailPage()
    {
        InitializeComponent();
    }

    private async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
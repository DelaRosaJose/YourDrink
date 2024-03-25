using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using YourDrink.Models;
using YourDrink.Services;

namespace YourDrink.ViewModels;
public partial class MainViewModel : ObservableObject
{
    //[ObservableProperty]
    //List<Category>? _categories;

    [ObservableProperty]
    ObservableCollection<Cocktail>? _MostPopulars;

    readonly HttpService httpService;
    public MainViewModel(HttpService httpService)
    {
        this.httpService = httpService;

        Task.Run(async () =>
        {

            var _DrinksPopularsData = await httpService.GetAsync<Cocktail.Drinks>(httpService.UrlGetMostPopulars);
            _MostPopulars = new ObservableCollection<Cocktail>(_DrinksPopularsData.drinks);

        }).Wait();
    }

    //[RelayCommand]
    //async Task SearchByCategory(string _category)
    //{

    //    //var _DrinksData = await httpService.HttpPetition(httpService.UrlSearchCocktailByCategory(_category));

    //    var _DrinksData = await httpService.GetAsync<Cocktail.Drinks>(httpService.UrlSearchCocktailByCategory(_category));
    //    //Cocktails.Clear();
    //    //Device.
    //    Cocktails = new ObservableCollection<Cocktail>(_DrinksData.drinks);
    //    //Cocktails = _DrinksData.drinks;

    //}
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

    [ObservableProperty]
    ObservableCollection<Cocktail>? _Lastest;

    [ObservableProperty]
    ItemsLayout _ItemsLayout = new GridItemsLayout(2, ItemsLayoutOrientation.Horizontal);//"HorizontalGrid, 2";

    readonly HttpService httpService;
    public MainViewModel(HttpService httpService)
    {
        this.httpService = httpService;

        Task.Run(async () =>
        {
            var _DrinksPopularsRequest = httpService.GetAsync<Cocktail.Drinks>(httpService.UrlGetMostPopulars);
            var _DrinksLastestsRequest = httpService.GetAsync<Cocktail.Drinks>(httpService.UrlGetLastests);

            var popularData = await _DrinksPopularsRequest;
            var lastestData = await _DrinksLastestsRequest;

            _MostPopulars = new ObservableCollection<Cocktail>(popularData.drinks);
            _Lastest = new ObservableCollection<Cocktail>(lastestData.drinks);

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

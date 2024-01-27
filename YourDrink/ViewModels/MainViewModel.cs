using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YourDrink.Models;
using YourDrink.Services;

namespace YourDrink.ViewModels;
public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    List<Category>? _categories;

    [ObservableProperty]
    List<Cocktail>? _Cocktails;

    readonly HttpService httpService;
    public MainViewModel(HttpService httpService) 
    {
        this.httpService = httpService;

        Task.Run(async () =>
        {
            var _CategoriesData =  httpService.HttpPetition(httpService.UrlGetCategories);
            var _DrinksData =  httpService.HttpPetition(httpService.UrlSearchCocktailByLetter("a"));

            Categories = JsonConvert.DeserializeObject<DrinkCategories>(await _CategoriesData)?.Categories;
            Cocktails = JsonConvert.DeserializeObject<DrinkCocktails>(await _DrinksData)?.Cocktails;
        }).Wait();
    }

    [RelayCommand]
    async Task SearchByCategory(string _category)
    {

        var _DrinksData = await httpService.HttpPetition(httpService.UrlSearchCocktailByCategory(_category));
        Cocktails = JsonConvert.DeserializeObject<DrinkCocktails>(_DrinksData)?.Cocktails;

    }
}

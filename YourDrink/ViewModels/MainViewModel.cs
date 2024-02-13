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
            var _CategoriesData = await httpService.GetAsync<Category.Drinks>(httpService.UrlGetCategories);
            Categories = _CategoriesData.drinks;


            var _DrinksData = await httpService.GetAsync<Cocktail.Drinks>(httpService.UrlSearchCocktailByLetter("a"));

            //Categories = JsonConvert.DeserializeObject<DrinkCategories>(await _CategoriesData)?.Categories;
            //var sss = JsonConvert.DeserializeObject<Cocktail.Drinks>(await _DrinksData);
            Cocktails = _DrinksData.drinks;
        }).Wait();
    }

    [RelayCommand]
    async Task SearchByCategory(string _category)
    {

        //var _DrinksData = await httpService.HttpPetition(httpService.UrlSearchCocktailByCategory(_category));

        var _DrinksData = await httpService.GetAsync<Cocktail.Drinks>(httpService.UrlSearchCocktailByCategory(_category));
        Cocktails = _DrinksData.drinks;

    }
}

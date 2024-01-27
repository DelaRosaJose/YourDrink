using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using YourDrink.Models;
using YourDrink.Services;

namespace YourDrink.ViewModels;
public partial class MainViewModel : Category
{
    [ObservableProperty]
    List<Category>? _categories;

    public MainViewModel(HttpService httpService) 
    {
        Task.Run(async () =>
        {
            var ss = await httpService.HttpPetition(httpService.UrlGetCategory);
            Categories = JsonConvert.DeserializeObject<DrinkCategories>(ss)?.Drinks;
        }).Wait();
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using YourDrink.Models.Base;

namespace YourDrink.Models;
public class DrinkCategories
{
    [JsonProperty("drinks")]
    public List<Category> Drinks { get; set; }
}
public partial class Category: BaseModel<Category>
{

    [ObservableProperty, JsonProperty("strCategory")]
    string? nombre;
}



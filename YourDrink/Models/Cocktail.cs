using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using YourDrink.Models.Base;

namespace YourDrink.Models
{
    public class DrinkCocktails
    {
        [JsonProperty("drinks")]
        public List<Cocktail> Cocktails { get; set; }
    }
    public partial class Cocktail : BaseModel<Cocktail>
    {
        [ObservableProperty]
        string _idDrink;

        [ObservableProperty, JsonProperty("strDrink")]
        string _Name;
        // object _strDrinkAlternate;

        [ObservableProperty, JsonProperty("strTags")]
        string _Tags;
        // object _strVideo;

        [ObservableProperty, JsonProperty("strCategory")]
        string _Category;

        [ObservableProperty, JsonProperty("strIBA")]
        string _IBA;

        [ObservableProperty, JsonProperty("strAlcoholic")]
        string _Alcoholic;

        [ObservableProperty, JsonProperty("strGlass")]
        string _Glass;

        [ObservableProperty, JsonProperty("strInstructions")]
        string _Instructions;

        [ObservableProperty, JsonProperty("strInstructionsES")]
        object _InstructionsES;

        [ObservableProperty, JsonProperty("strInstructionsDE")]
        string _InstructionsDE;

        [ObservableProperty, JsonProperty("InstructionsFR")]
        object _strInstructionsFR;

        [ObservableProperty, JsonProperty("strInstructionsIT")]
        string _InstructionsIT;

        [ObservableProperty, JsonProperty("strDrinkThumb")]
        string _Image;

        [ObservableProperty, JsonProperty("strIngredient1")]
        string _Ingredient1;

        [ObservableProperty, JsonProperty("strIngredient2")]
        string _Ingredient2;

        [ObservableProperty, JsonProperty("strIngredient3")]
        string _Ingredient3;

        [ObservableProperty, JsonProperty("strIngredient4")]
        string _Ingredient4;

        [ObservableProperty, JsonProperty("strIngredient5")]
        string _Ingredient5;

        [ObservableProperty, JsonProperty("strIngredient6")]
        string _Ingredient6;

        [ObservableProperty, JsonProperty("strIngredient7")]
        string _Ingredient7;

        [ObservableProperty, JsonProperty("strIngredient8")]
        object _Ingredient8;

        [ObservableProperty, JsonProperty("strIngredient9")]
        object _Ingredient9;

        [ObservableProperty, JsonProperty("strIngredient10")]
        object _Ingredient10;

        [ObservableProperty, JsonProperty("strIngredient11")]
        object _Ingredient11;

        [ObservableProperty, JsonProperty("strIngredient12")]
        object _Ingredient12;

        [ObservableProperty, JsonProperty("strIngredient13")]
        object _Ingredient13;

        [ObservableProperty, JsonProperty("strIngredient14")]
        object _Ingredient14;

        [ObservableProperty, JsonProperty("strIngredient15")]
        object _Ingredient15;

        [ObservableProperty, JsonProperty("strMeasure1")]
        string _Measure1;

        [ObservableProperty, JsonProperty("strMeasure2")]
        string _Measure2;

        [ObservableProperty, JsonProperty("strMeasure3")]
        string _Measure3;

        [ObservableProperty, JsonProperty("strMeasure4")]
        string _Measure4;

        [ObservableProperty, JsonProperty("strMeasure5")]
        string _Measure5;

        [ObservableProperty, JsonProperty("strMeasure6")]
        string _Measure6;

        [ObservableProperty, JsonProperty("strMeasure7")]
        string _Measure7;

        [ObservableProperty, JsonProperty("strMeasure8")]
        object _Measure8;

        [ObservableProperty, JsonProperty("strMeasure9")]
        object _Measure9;

        [ObservableProperty, JsonProperty("strMeasure10")]
        object _Measure10;

        [ObservableProperty, JsonProperty("strMeasure11")]
        object _Measure11;

        [ObservableProperty, JsonProperty("strMeasure12")]
        object _Measure12;

        [ObservableProperty, JsonProperty("strMeasure13")]
        object _Measure13;

        [ObservableProperty, JsonProperty("strMeasure14")]
        object _Measure14;

        [ObservableProperty, JsonProperty("strMeasure15")]
        object _Measure15;
        string _strImageSource;

        [ObservableProperty, JsonProperty("strImageAttribution")]
        string _ImageAttribution;

        string _strCreativeCommonsConfirmed;
        string _dateModified;


    }
}

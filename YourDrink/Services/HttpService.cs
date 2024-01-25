using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourDrink.Services
{
    public class HttpService
    {
        HttpClient httpClientcli = new HttpClient();
        private const string BaseUrl = "www.thecocktaildb.com/api/json/v1/1/";

        public static string SearchCocktailByName(string Name) => $"{BaseUrl}search.php?s={Name}";
        public static string SearchCocktailByLetter(string Letter) => $"{BaseUrl}search.php?f={Letter}";
        public static string SearchIngredientByName(string Name) => $"{BaseUrl}search.php?i={Name}";
        public static string SearchCocktailById(string Id) => $"{BaseUrl}lookup.php?i={Id}";
        public static string SearchRandomCocktail  => $"{BaseUrl}random.php";
        public static string SearchCocktailByIngredient(string Ingredient) => $"{BaseUrl}filter.php?i={Ingredient}";


        public async Task<string> HttpPetition(string Url)
        {
            var Request = await httpClientcli.GetAsync(Url);
            return await Request.Content.ReadAsStringAsync();
        }
    }
}

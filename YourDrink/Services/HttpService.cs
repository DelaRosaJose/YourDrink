namespace YourDrink.Services
{
    public class HttpService
    {
        public HttpService()
        {
            httpClientcli = new HttpClient();
        }
        private const string BaseUrl = "https://www.thecocktaildb.com/api/json/v1/1/";
        readonly HttpClient httpClientcli; 

        public string UrlSearchCocktailByName(string Name) => $"{BaseUrl}search.php?s={Name}";
        public string UrlSearchCocktailByLetter(string Letter) => $"{BaseUrl}search.php?f={Letter}";
        public string UrlSearchIngredientByName(string Name) => $"{BaseUrl}search.php?i={Name}";
        public string UrlSearchCocktailById(string Id) => $"{BaseUrl}lookup.php?i={Id}";
        public string UrlSearchRandomCocktail => $"{BaseUrl}random.php";
        public string UrlSearchCocktailByIng5redient(string Ingredient) => $"{BaseUrl}filter.php?i={Ingredient}";
        public string UrlGetCategory => $"{BaseUrl}list.php?c=list";


        public async Task<string> HttpPetition(string strUrl)
        {
            //var Url = new Uri(string.Format(strUrl, string.Empty));
            var Request = await httpClientcli.GetAsync(new Uri(strUrl));
            return await Request.Content.ReadAsStringAsync();
        }
    }
}

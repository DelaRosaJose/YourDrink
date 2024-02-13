using MonkeyCache.FileStore;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace YourDrink.Services
{
    public class HttpService
    {
        readonly IConnectivity connectivity;
        public HttpService(IConnectivity connectivity)
        {
            this.connectivity = connectivity;
            httpClientcli = new HttpClient();
        }
        private const string BaseUrl = "https://www.thecocktaildb.com/api/json/v1/1/";
        readonly HttpClient httpClientcli; 

        public string UrlSearchCocktailByName(string Name) => $"{BaseUrl}search.php?s={Name}";
        public string UrlSearchCocktailByLetter(string Letter) => $"{BaseUrl}search.php?f={Letter}";
        public string UrlSearchIngredientByName(string Name) => $"{BaseUrl}search.php?i={Name}";
        public string UrlSearchCocktailById(string Id) => $"{BaseUrl}lookup.php?i={Id}";
        public string UrlSearchCocktailByCategory(string Category) => $"{BaseUrl}filter.php?c={Category}";
        public string UrlSearchRandomCocktail => $"{BaseUrl}random.php";
        public string UrlSearchCocktailByIngredient(string Ingredient) => $"{BaseUrl}filter.php?i={Ingredient}";
        public string UrlGetCategories => $"{BaseUrl}list.php?c=list";


        //public async Task<string> HttpPetition(string strUrl)
        //{
        //    //var Url = new Uri(string.Format(strUrl, string.Empty));
        //    var Request = await httpClientcli.GetAsync(new Uri(strUrl));
        //    return await Request.Content.ReadAsStringAsync();
        //}

        public async Task<T> GetAsync<T>(string url, double days = 7, bool forceRefresh = false)
        {
            if (connectivity.NetworkAccess != NetworkAccess.Internet)
                return Barrel.Current.Get<T>(url);

            if (!forceRefresh && !Barrel.Current.IsExpired(url))
                return Barrel.Current.Get<T>(url);

            try
            {
                
                var request = await httpClientcli.GetAsync(new Uri(url));
                var response = request.Content.ReadAsStringAsync();

                T result = JsonConvert.DeserializeObject<T>(await response);
                
                if (result != null)
                Barrel.Current.Add(url, result, TimeSpan.FromDays(days));
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to get information from server {ex}");
            }

            return default;
        }


    }
}

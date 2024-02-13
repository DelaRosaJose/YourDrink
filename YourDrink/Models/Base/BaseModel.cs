
using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;


namespace YourDrink.Models.Base;
public partial class BaseModel<T> : ObservableObject where T : BaseModel<T>, new()
{
    //[JsonProperty("drinks")]
    //public List<T> drinks { get; set; }
    public class Drinks
    {
        //[JsonProperty("drinks")]
        public List<T> drinks{ get; set; }
    }


    [ObservableProperty]
    //[property: PrimaryKey, NotNull]
    string id = Guid.NewGuid().ToString("n");

    [ObservableProperty]
    long createdAt;

    [ObservableProperty]
    long deleted;

    public virtual T Save()
    {
        if (CreatedAt == default)
            CreatedAt = DateTime.UtcNow.Ticks;

        var obj = (T)this;
        //SQLiteRepository.SaveItem(obj);
        return obj;
    }


}

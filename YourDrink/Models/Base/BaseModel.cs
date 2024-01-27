
using CommunityToolkit.Mvvm.ComponentModel;


namespace YourDrink.Models.Base;
public partial class BaseModel<T> : ObservableObject where T : BaseModel<T>, new()
{

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

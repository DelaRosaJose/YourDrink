using MonkeyCache.FileStore;

namespace YourDrink
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Barrel.ApplicationId = AppInfo.PackageName;
            MainPage = new AppShell();
        }
    }
}

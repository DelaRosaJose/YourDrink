namespace YourDrink
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.CocktailPage), typeof(Views.CocktailPage));
        }
    }
}

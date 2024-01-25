namespace YourDrink.Views
{

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            drinks = new Drink[]
            {
                new Drink() {strCategory= "Ordinary Drink" },
                new Drink() { strCategory= "Cocktail" },
                new Drink() { strCategory = "Shake" },
                new Drink() { strCategory = "Other / Unknown" },
                new Drink() { strCategory = "Cocoa" },
                new Drink() { strCategory = "Shot" },
                new Drink() { strCategory = "Coffee / Tea" },
                new Drink() { strCategory = "Homemade Liqueur" },
                new Drink() { strCategory = "Punch / Party Drink" },
                new Drink() { strCategory = "Beer" },
                new Drink() { strCategory = "Soft Drink" }
            };

            BindingContext = this;
            InitializeComponent();
        }

        public Drink[] drinks { get; set; }

        public class Drink
        {
            public string strCategory { get; set; }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}

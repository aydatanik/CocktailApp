using CocktailsApp.Views;

namespace CocktailsApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SearchCocktailsPage), typeof(SearchCocktailsPage));
        }
    }
}

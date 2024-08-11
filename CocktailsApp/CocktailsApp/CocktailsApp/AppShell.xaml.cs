using CocktailsApp.Views;

namespace CocktailsApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(SearchCocktailsPage), typeof(SearchCocktailsPage));
            Routing.RegisterRoute(nameof(GetRandomCoctailPage), typeof(GetRandomCoctailPage));
            Routing.RegisterRoute(nameof(SearchIngredientsPage), typeof(SearchIngredientsPage));
        }
    }
}

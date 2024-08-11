using CocktailsApp.ViewModels;

namespace CocktailsApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}

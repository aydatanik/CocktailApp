using CocktailsApp.ViewModels;

namespace CocktailsApp.Views;

public partial class SearchCocktailsPage : ContentPage
{
	public SearchCocktailsPage(SearchCocktailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
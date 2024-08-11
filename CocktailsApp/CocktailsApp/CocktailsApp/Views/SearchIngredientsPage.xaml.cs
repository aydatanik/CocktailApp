using CocktailsApp.ViewModels;

namespace CocktailsApp.Views;

public partial class SearchIngredientsPage : ContentPage
{
	public SearchIngredientsPage(SearchIngredientsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
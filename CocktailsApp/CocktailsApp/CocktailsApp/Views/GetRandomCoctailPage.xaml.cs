using CocktailsApp.ViewModels;

namespace CocktailsApp.Views;

public partial class GetRandomCoctailPage : ContentPage
{
	public GetRandomCoctailPage(GetRandomCocktailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
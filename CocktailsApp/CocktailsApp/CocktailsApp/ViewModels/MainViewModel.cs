using CocktailsApp.Callbacks;
using CocktailsApp.Dependency;
using CocktailsApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CocktailsApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ICocktailsSdk _cocktailsSdk;
        public ICommand NavigateSearchCocktailsPageCommand { get; set; }
        public ICommand NavigateGetRandomCocktailsPageCommand { get; set; }
        public ICommand NavigateSearchIngredientsPageCommand { get; set; }

        public MainViewModel(ICocktailsSdk cocktailsSdk, IServiceProvider provider)
        {
            NavigateSearchCocktailsPageCommand = new Command(NavigateSearchCocktailsPage);
            NavigateGetRandomCocktailsPageCommand = new Command(NavigateGetRandomCocktailsPage);
            NavigateSearchIngredientsPageCommand = new Command(NavigateSearchIngredientsPage);
            _cocktailsSdk = cocktailsSdk;
           // var sdk = provider.GetService<ICocktailsSdk>();
           // _cocktailsSdk = sdk!;
            StartCocktailsSdk();
        }

        public void StartCocktailsSdk()
        {
            _cocktailsSdk.StartSdk();
        }
        private async void NavigateSearchCocktailsPage()
        {
            await Shell.Current.GoToAsync(nameof(SearchCocktailsPage));
        }

        private async void NavigateGetRandomCocktailsPage()
        {
            await Shell.Current.GoToAsync(nameof(GetRandomCoctailPage));
        }

        private async void NavigateSearchIngredientsPage()
        {
            await Shell.Current.GoToAsync(nameof(SearchIngredientsPage));
        }
    }
}

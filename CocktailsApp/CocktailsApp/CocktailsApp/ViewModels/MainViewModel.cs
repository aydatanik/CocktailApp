using CocktailsApp.Callbacks;
using CocktailsApp.Dependency;
using CocktailsApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CocktailsApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ICocktailsSdk _cocktailsSdk;
        public ICommand NavigateSearchCocktailsPageCommand { get; set; }

       // ICocktailsSdk sdk = DependencyService.Get<ICocktailsSdk>();

        public MainViewModel(ICocktailsSdk cocktailsSdk)
        {
            NavigateSearchCocktailsPageCommand = new Command(NavigateSearchCocktailsPage);
            _cocktailsSdk = cocktailsSdk;
            StartCocktailsSdk();
            SearchCocktailsByName();
        }
        private async void NavigateSearchCocktailsPage()
        {
            await Shell.Current.GoToAsync(nameof(SearchCocktailsPage));
        }

        public void StartCocktailsSdk()
        {
            _cocktailsSdk.StartSdk();
        }

        public void SearchCocktailsByName()
        {
            ISearchCocktailsCallback callback = new SearchCocktailsCallback();
            _cocktailsSdk.SearchCocktailByName("mojito", callback);

        }
    }
}

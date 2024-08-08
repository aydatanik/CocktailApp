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

            //var serializedObject = JsonSerializer.Serialize(_cocktailsSdk); // or JsonConvert.SerializeObject(yourObject)

            // Navigate and pass the serialized string as a query parameter
            //await Shell.Current.GoToAsync($"{nameof(SearchCocktailsPage)}?SerializedObject={Uri.EscapeDataString(serializedObject)}");
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

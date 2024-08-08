using CocktailsApp.Callbacks;
using CocktailsApp.Dependency;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CocktailsApp.ViewModels
{
    public partial class SearchCocktailsViewModel : ObservableObject
    {
        private string _cocktailName;

        public event PropertyChangedEventHandler PropertyChanged;

        public string CocktailName
        {
            get => _cocktailName;
            set
            {
                _cocktailName = value;
                OnPropertyChanged(nameof(CocktailName));
            }
        }

        public ICommand SearchCocktailsByNameCommand { get; set; }

        private readonly ICocktailsSdk _cocktailsSdk;

        public SearchCocktailsViewModel(ICocktailsSdk cocktailsSdk)
        {
            SearchCocktailsByNameCommand = new Command(SearchCocktailsByName);
            _cocktailsSdk = cocktailsSdk;
        }

        public void SearchCocktailsByName()
        {
            //_cocktailsSdk.StartSdk();
            ISearchCocktailsCallback callback = new SearchCocktailsCallback();
            Application.Current.MainPage.DisplayAlert("Submitted", $"You entered: {CocktailName}", "OK");
            _cocktailsSdk.SearchCocktailByName("mojito", callback);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}

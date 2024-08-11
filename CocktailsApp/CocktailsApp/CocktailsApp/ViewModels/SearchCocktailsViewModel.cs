using CocktailsApp.Callbacks;
using CocktailsApp.Dependency;
using CocktailsApp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CocktailsApp.ViewModels
{
    public partial class SearchCocktailsViewModel : ObservableObject, ISearchCocktailsCallback, INotifyPropertyChanged
    {
        private string _cocktailName;
        public string CocktailName
        {
            get => _cocktailName;
            set
            {
                _cocktailName = value;
                OnPropertyChanged(nameof(CocktailName));
            }
        }

        private ObservableCollection<Cocktail> _cocktailList;
        public ObservableCollection<Cocktail> CocktailList
        {
            get => _cocktailList;
            set
            {
                _cocktailList = value;
                OnPropertyChanged(nameof(CocktailList));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SearchCocktailsByNameCommand { get; set; }

        private readonly ICocktailsSdk _cocktailsSdk;

        public SearchCocktailsViewModel(ICocktailsSdk cocktailsSdk, IServiceProvider provider)
        {
            SearchCocktailsByNameCommand = new Command(SearchCocktailsByName);
            _cocktailsSdk = cocktailsSdk;
            //var sdk = provider.GetService<ICocktailsSdk>();
            //_cocktailsSdk = sdk!;
        }

        public void SearchCocktailsByName()
        {
            try
            {
                ISearchCocktailsCallback callback = this;
                if (CocktailName != null)
                {
                    CocktailList = new ObservableCollection<Cocktail>();
                    _cocktailsSdk.SearchCocktailByName(CocktailName, callback);
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Warning", "Please enter cocktail name!", "OK");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace!.ToString());
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void OnSearchCocktailsResult(List<Model.Cocktail> cocktails)
        {
            ObservableCollection<Cocktail> updatedCocktailList = new ObservableCollection<Cocktail>();
            if (cocktails != null)
            {
                foreach (var item in cocktails)
                {
                    updatedCocktailList.Add(item);
                }
                CocktailList = updatedCocktailList;
            }

            /*MainThread.BeginInvokeOnMainThread(() =>
            {
                CocktailList = updatedCocktailList;
            });*/
        }

        public void OnSearchCocktailsFailed()
        {
            Application.Current.MainPage.DisplayAlert("Error", "Error in search cocktails", "OK");
        }
    }
}

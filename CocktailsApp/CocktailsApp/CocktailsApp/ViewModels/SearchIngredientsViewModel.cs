using CocktailsApp.Dependency;
using CocktailsApp.Listener;
using CocktailsApp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CocktailsApp.ViewModels
{
    public class SearchIngredientsViewModel : ObservableObject, IingredientListener, INotifyPropertyChanged
    {
        private string _ingredientName;
        public string IngredientName
        {
            get => _ingredientName;
            set
            {
                _ingredientName = value;
                OnPropertyChanged(nameof(IngredientName));
            }
        }

        private ObservableCollection<Model.Ingredient> _ingredientList;
        public ObservableCollection<Model.Ingredient> IngeredientList
        {
            get => _ingredientList;
            set
            {
                _ingredientList = value;
                OnPropertyChanged(nameof(IngeredientList));
            }
        }
        public ICommand SearchIngredientsByNameCommand { get; set; }

        private readonly ICocktailsSdk _cocktailsSdk;

        public event PropertyChangedEventHandler PropertyChanged;
        public SearchIngredientsViewModel(ICocktailsSdk cocktailsSdk)
        {
            SearchIngredientsByNameCommand = new Command(SearchIngredientsByName);
            _cocktailsSdk = cocktailsSdk;
        }

        public void SearchIngredientsByName()
        {
            try
            {
                if(IngredientName != null)
                {
                    _cocktailsSdk.SearchIngredientByName(this, IngredientName);
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Wartning", "Please enter ingredient name!", "OK");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace!.ToString());
            }
        }

        public void OnIngredientSearchError()
        {
            Application.Current.MainPage.DisplayAlert("Error", "Error in searching ingredient!!", "OK");
        }

        public void OnIngredientSearchCompleted(List<Model.Ingredient> ingredients)
        {
            ObservableCollection<Model.Ingredient> updatedIngredientList = new ObservableCollection<Model.Ingredient>();
            if (ingredients != null)
            {
                foreach (var item in ingredients)
                {
                    updatedIngredientList.Add(item);
                }
                IngeredientList = updatedIngredientList;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

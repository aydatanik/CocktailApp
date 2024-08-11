using CocktailsApp.Callbacks;
using CocktailsApp.Dependency;
using CocktailsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CocktailsApp.ViewModels
{
    public class GetRandomCocktailViewModel :  INotifyPropertyChanged, IGetCocktailCallback
    {
        private string _result;
        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand GetRandomCocktailCommand { get; set; }

        private readonly ICocktailsSdk _cocktailsSdk;

        public GetRandomCocktailViewModel(ICocktailsSdk  cocktailsSdk)
        {
            GetRandomCocktailCommand = new Command(GetRandomCocktail);
            _cocktailsSdk = cocktailsSdk;
        }

        public void GetRandomCocktail()
        {
            try
            {
                IGetCocktailCallback callback = this;
                _cocktailsSdk.GetRandomCocktail(callback);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace!.ToString());
            }
        }

        public void OnGetRandomCocktailResult(Cocktail cocktail)
        {
            if (cocktail != null)
            {
                Result = cocktail.ToString();
            }
        }

        public void OnGetRandomCocktailError()
        {
            Application.Current.MainPage.DisplayAlert("Error", "Error in random cocktails", "OK");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

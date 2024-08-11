using CocktailsApp.Callbacks;
using CocktailsApp.Listener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Dependency
{
    public interface ICocktailsSdk
    {
        void StartSdk();

        void SearchCocktailByName(String cocktailName, ISearchCocktailsCallback callback);

        void GetRandomCocktail(IGetCocktailCallback callback);
       
        void SearchIngredientByName(IingredientListener callback, String  ingredientName);
       
    }
}

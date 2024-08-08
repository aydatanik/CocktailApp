using CocktailsApp.Callbacks;
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
         
        // another two method 


    }
}

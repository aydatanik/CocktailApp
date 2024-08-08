using CocktailsApp.Callbacks;
using CocktailsApp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Platforms.Dependecy
{
    public class CocktailsSdk : ICocktailsSdk
    {
        public void SearchCocktailByName()
        {
            throw new NotImplementedException();
        }

        public void SearchCocktailByName(string cocktailName, ISearchCocktailsCallback callback)
        {
            throw new NotImplementedException();
        }

        public void StartSdk()
        {
            throw new NotImplementedException();
        }
    }
}

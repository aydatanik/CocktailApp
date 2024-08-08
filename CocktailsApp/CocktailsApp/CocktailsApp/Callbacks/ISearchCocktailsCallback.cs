using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Callbacks
{
    public interface ISearchCocktailsCallback 
    {
        public void OnSearchCocktailsResult();
        public void OnSearchCocktailsFailed();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Callbacks
{
    public class SearchCocktailsCallback : ISearchCocktailsCallback
    {
        public void OnSearchCocktailsFailed()
        {
            Console.WriteLine("---------------------> OnSearchCocktailsFailed");
        }

        public void OnSearchCocktailsResult()
        {
            Console.WriteLine("---------------------> OnSearchCocktailResult");
        }
    }
}

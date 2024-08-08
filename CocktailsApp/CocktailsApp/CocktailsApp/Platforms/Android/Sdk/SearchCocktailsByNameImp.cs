using Callbacks;
using Domain;
using Exceptions;
using Java.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Platforms.Android.Sdk
{
    public class SearchCocktailsByNameImp : Java.Lang.Object, ISearchCocktailsCallback
    {
          public CocktailsApp.Callbacks.ISearchCocktailsCallback Callback { get;  set; }

        public void OnSearchCocktailsFailed(CocktailsSdkException? p0)
        {
            Callback?.OnSearchCocktailsResult();
        }

        public void OnSearchCocktailsResult(IList<Cocktail>? p0)
        {
            Callback?.OnSearchCocktailsResult();
        }

   


     
    }
}

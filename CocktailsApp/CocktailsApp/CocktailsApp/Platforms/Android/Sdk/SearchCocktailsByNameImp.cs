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
            Callback?.OnSearchCocktailsFailed();
        }

        public void OnSearchCocktailsResult(IList<Cocktail>? p0)
        {
            List<Model.Cocktail> cocktails = new List<Model.Cocktail>();
            if (p0 != null)
            {
                foreach (var item in p0)
                {
                    Model.Cocktail cocktail = new Model.Cocktail();
                    cocktail.IdDrink = item.IdDrink;
                    cocktail.StrDrink = item.StrDrink;
                    cocktail.StrDrinkAlternate = item.StrDrinkAlternate;
                    cocktail.StrTags = item.StrTags;
                    cocktail.StrVideo = item.StrVideo;
                    cocktail.StrCategory = item.StrCategory;
                    cocktail.StrIBA = item.StrIBA;
                    cocktail.StrAlcoholic = item.StrAlcoholic;
                    cocktail.StrGlass = item.StrGlass;
                    cocktail.StrDrinkThumb = item.StrDrinkThumb;
                    cocktail.StrImageSource = item.StrImageSource;
                    cocktail.StrImageAttribution = item.StrImageAttribution;
                    cocktail.StrCreativeCommonsConfirmed = item.StrCreativeCommonsConfirmed;
                    cocktail.DateModified = item.DateModified;
                    //cocktail.Ingredients = (Dictionary<string, string>?)item.Ingredients;
                    //cocktail.Measures = (Dictionary<string, string>?)item.Measures;
                    cocktails.Add(cocktail);
                }
            }
            Callback?.OnSearchCocktailsResult(cocktails);
        }
    }
}

using Callbacks;
using Domain;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Platforms.Android.Sdk
{
    public class GetRandomCocktailImp : Java.Lang.Object, IGetCocktailCallback
    {
        public CocktailsApp.Callbacks.IGetCocktailCallback Callback { get; set; }
        public void OnGetRandomCocktailFailed(CocktailsSdkException? p0)
        {
            Callback?.OnGetRandomCocktailError();
        }

        public void OnGetRandomCocktailResult(Cocktail? p0)
        {
            Model.Cocktail cocktail = new Model.Cocktail();
            if (p0 != null)
            {
                cocktail.IdDrink = p0.IdDrink;
                cocktail.StrDrink = p0.StrDrink;
                cocktail.StrDrinkAlternate = p0.StrDrinkAlternate;
                cocktail.StrTags = p0.StrTags;
                cocktail.StrVideo = p0.StrVideo;
                cocktail.StrCategory = p0.StrCategory;
                cocktail.StrIBA = p0.StrIBA;
                cocktail.StrAlcoholic = p0.StrAlcoholic;
                cocktail.StrGlass = p0.StrGlass;
                cocktail.StrDrinkThumb = p0.StrDrinkThumb;
                cocktail.StrImageSource = p0.StrImageSource;
                cocktail.StrImageAttribution = p0.StrImageAttribution;
                cocktail.StrCreativeCommonsConfirmed = p0.StrCreativeCommonsConfirmed;
                cocktail.DateModified = p0.DateModified;
            }
            Callback?.OnGetRandomCocktailResult(cocktail);   
        }
    }
}

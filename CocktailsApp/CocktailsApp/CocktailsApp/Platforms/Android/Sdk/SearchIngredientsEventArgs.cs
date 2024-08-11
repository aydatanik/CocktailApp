using Android.Runtime;
using Domain;
using Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Platforms.Android.Sdk
{
    public class SearchIngredientsEventArgs : IngredientEventArgs
    {
        public SearchIngredientsEventArgs(IList<Ingredient>? p0) : base(p0)
        {
        }

        protected SearchIngredientsEventArgs(nint javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public void OnIngredientSearchCompleted(Java.Lang.Object? p0)
        {
           
        }

        public void OnIngredientSearchError(string? p0)
        {
           
        }
    }
}

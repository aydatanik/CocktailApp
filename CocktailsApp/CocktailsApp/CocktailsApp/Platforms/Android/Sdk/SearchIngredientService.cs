using Com.Example.Myhttpsdk.Core;
using Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CocktailsApp.Platforms.Android.Sdk
{
    public class SearchIngredientService : Java.Lang.Object, IIngredientListener
    {
        public event EventHandler<IngredientEventArgs> IngredientSearchCompleted;

        public void SearchIngredientByName(String ingredientName)
        {
           // CocktailManager.Instance.SearchIngredientByName(listener, ingredientName);
        }
     

        public void OnIngredientSearchCompleted(Java.Lang.Object? p0)
        {
            Console.WriteLine("aaa");
        }

        public void OnIngredientSearchError(string? p0)
        {
            throw new NotImplementedException();
        }
    }
}

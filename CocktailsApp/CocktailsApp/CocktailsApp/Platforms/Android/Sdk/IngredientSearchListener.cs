using Android.App;
using Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Platforms.Android.Sdk
{
    public class IngredientSearchListener : Java.Lang.Object, IIngredientListener
    {
        public IngredientSearchListener() { }
        public CocktailsApp.Listener.IingredientListener Listener { get; set; }
       
        public void OnIngredientSearchCompleted(Java.Lang.Object? p0)
        {
            Console.WriteLine("Success");
            List<Model.Ingredient> ingredients = new List<Model.Ingredient>();
            if (p0 is IngredientEventArgs)
            {
                var eventArgs = (IngredientEventArgs)p0;
                foreach (var ing in eventArgs.Ingredients!)
                {
                    Model.Ingredient ingredient = new Model.Ingredient();
                    ingredient.IdIngredient = ing.IdIngredient;
                    ingredient.StrIngredient = ing.StrIngredient;
                    ingredient.StrDescription = ing.StrDescription;
                    ingredient.StrType = ing.StrType;
                    ingredient.StrAlcohol = ing.StrAlcohol;
                    ingredient.StrABV = ing.StrABV;
                    ingredients.Add(ingredient);
                }
            }
            Listener.OnIngredientSearchCompleted(ingredients);
        }

        public void OnIngredientSearchError(string? p0)
        {
            Console.WriteLine("Fail");
            Listener.OnIngredientSearchError();
        }
    }
}

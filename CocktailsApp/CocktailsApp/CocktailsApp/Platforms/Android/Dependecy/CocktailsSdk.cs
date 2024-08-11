using Android.Speech;
using CocktailsApp.Callbacks;
using CocktailsApp.Dependency;
using CocktailsApp.Listener;
using CocktailsApp.Platforms.Android.Sdk;
using Com.Example.Myhttpsdk.Core;
using Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Application = Android.App.Application;

namespace CocktailsApp.Platforms.Dependecy
{
    public class CocktailsSdk : ICocktailsSdk
    {
        public event EventHandler<SearchIngredientsEventArgs> IngredientSearchCompleted;
        public void SearchCocktailByName(string cocktailName, ISearchCocktailsCallback callback)
        {
            try
            {
                var searchCocktailCallback = new SearchCocktailsByNameImp();
                searchCocktailCallback.Callback = callback;
                CocktailManager.Instance!.SearchCocktailsByName(cocktailName, searchCocktailCallback);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace!.ToString());
            }
        }

        public void GetRandomCocktail(IGetCocktailCallback callback)
        {
            try
            {
              var getCocktailCallback = new GetRandomCocktailImp();
              getCocktailCallback.Callback = callback;
              CocktailManager.Instance!.GetRandomCocktail(getCocktailCallback);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace!.ToString());
            }
        }

        public void SearchIngredientByName(IingredientListener ilistener, string ingredientName)
        {
            //SearchIngredientService searchIngredientService = new SearchIngredientService();
            //searchIngredientService.IngredientsFounded += SearchIngredientService_IngredientsFounded;
            //var listener = new SearchIngredientsEventArgs();
            //CocktailManager.Instance!.SearchIngredientByName(listener, ingredientName);
            IngredientSearchListener listener = new IngredientSearchListener();
            listener.Listener = ilistener;
           // IIngredientListener ingredientListener = new IIngredientListener();
            CocktailManager.Instance!.SearchIngredientByName(listener, ingredientName);
        }

        private void SearchIngredientService_IngredientsFounded(object? sender, IngredientEventArgs e)
        {
            if(e.Ingredients != null)
            {
                String num = e.Ingredients.ToString();
            }
           
        }

        public void StartSdk()
        {
            try
            {
                var context = Application.Context;
                CocktailManager.Instance!.StartSdk(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace!.ToString());
            }
            
        }
    }
}

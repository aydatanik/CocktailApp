using CocktailsApp.Callbacks;
using CocktailsApp.Dependency;
using CocktailsApp.Platforms.Android.Sdk;
using Com.Example.Myhttpsdk.Core;
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

        public void SearchCocktailByName(string cocktailName, ISearchCocktailsCallback callback)
        {
            var searchCocktailCallback = new SearchCocktailsByNameImp();
            searchCocktailCallback.Callback = callback;
            try
            {
                CocktailManager.Instance!.SearchCocktailsByName(cocktailName, searchCocktailCallback);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void StartSdk()
        {
            var context = Application.Context;
            VSdkManager.Instance!.StartSdk(context);
        }
    }
}

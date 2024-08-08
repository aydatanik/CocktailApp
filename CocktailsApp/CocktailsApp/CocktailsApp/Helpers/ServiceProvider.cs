using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Helpers
{
    public static class ServiceProvider
    {
        public static TService GetService<TService>() => Current.GetService<TService>();
        public static IServiceProvider Current =>
#if ANDROID
            MauiApplication.Current.Services;
#elif IOS
            MauiUIApplicationDelegate.Current.Services;
#else
            null;
#endif
    }
}

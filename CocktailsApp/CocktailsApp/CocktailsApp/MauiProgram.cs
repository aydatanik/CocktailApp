using CocktailsApp.Dependency;
using CocktailsApp.ViewModels;
using CocktailsApp.Views;
using Microsoft.Extensions.Logging;


namespace CocktailsApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ICocktailsSdk, Platforms.Dependecy.CocktailsSdk>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();


            //will be create and destroy
            builder.Services.AddTransient<SearchCocktailsPage>();
            builder.Services.AddTransient <SearchCocktailsViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

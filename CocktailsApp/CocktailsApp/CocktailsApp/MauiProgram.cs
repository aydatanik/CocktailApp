using CocktailsApp.Dependency;
using CocktailsApp.ViewModels;
using CocktailsApp.Views;
using CommunityToolkit.Maui;
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
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ICocktailsSdk, Platforms.Dependecy.CocktailsSdk>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddSingleton<SearchCocktailsPage>();
            builder.Services.AddSingleton<SearchCocktailsViewModel>();

            builder.Services.AddSingleton<GetRandomCoctailPage>();
            builder.Services.AddSingleton<GetRandomCocktailViewModel>();

            builder.Services.AddSingleton<SearchIngredientsPage>();
            builder.Services.AddSingleton<SearchIngredientsViewModel>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

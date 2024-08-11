using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Callbacks
{
    public interface IGetCocktailCallback
    {
        public void OnGetRandomCocktailResult(Model.Cocktail cocktail);
        public void OnGetRandomCocktailError();
    }
}

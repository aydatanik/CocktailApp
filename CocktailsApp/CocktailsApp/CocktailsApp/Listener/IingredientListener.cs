using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Listener
{
    public interface IingredientListener
    {
        void OnIngredientSearchCompleted(List<Model.Ingredient> ingredients);
        void OnIngredientSearchError();
    }
}

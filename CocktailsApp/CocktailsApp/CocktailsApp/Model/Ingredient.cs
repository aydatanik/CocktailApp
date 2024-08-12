using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Model
{
    public class Ingredient
    {
        public String? IdIngredient { get; set; }
        public String? StrIngredient { get; set; }
        public String? StrDescription { get; set; }
        public String? StrType { get; set; }
        public String? StrAlcohol { get; set; }
        public String? StrABV { get; set; }

        public override string ToString()
        {
            return $"IdIngredient: {IdIngredient} StrIngredient: {StrIngredient} StrDescription: {StrDescription} StrType: {StrType}  StrAlcohol: {StrAlcohol} StrABV: {StrABV}";
        }
    }
}

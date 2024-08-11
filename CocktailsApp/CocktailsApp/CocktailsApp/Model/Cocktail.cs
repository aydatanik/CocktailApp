using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsApp.Model    
{
    public class Cocktail 
    {
       /* private String? strDrink;
        public String? StrDrink
        {
            get => strDrink; 
            set => SetProperty(ref strDrink, value);
        }*/
        public String? IdDrink { get; set; }
        public String? StrDrink { get; set; }
        public String? StrDrinkAlternate { get; set; }
        public String? StrTags { get; set; }
        public String? StrVideo { get; set; }
        public String? StrCategory { get; set; }
        public String? StrIBA { get; set; }
        public String? StrAlcoholic { get; set; }
        public String? StrGlass { get; set; }
        public String? StrDrinkThumb { get; set; }
        public String? StrImageSource { get; set; }
        public String? StrImageAttribution { get; set; }
        public String? StrCreativeCommonsConfirmed { get; set; }
        public String? DateModified { get; set; }
        public Dictionary<string, string>? Ingredients { get; set; }
        public Dictionary<string, string>? Measures { get; set; }


        public override string ToString()
        {
            return $"IdDrink: {IdDrink} StrDrink: {StrDrink} StrAlcoholic: {StrAlcoholic} StrGlass: {StrGlass} \n  StrCategory: {StrCategory} DateModified: {DateModified}";
        }

    }
}

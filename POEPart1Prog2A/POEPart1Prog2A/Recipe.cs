using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1Prog2A
{
    internal class Recipe
    {

        List<string> RecipeList = new List<string>();

        // initalizing the ingredients
        string ingredientName;
        double ingredientQuanity;
        string unitOfMeasurement;

        public string IngredientName { get => ingredientName; set => ingredientName = value; }
        public double IngredientQuanity { get => ingredientQuanity; set => ingredientQuanity = value; }
        public string UnitOfMeasurement { get => unitOfMeasurement; set => unitOfMeasurement = value; }
        public List<string> RecipeList1 { get => RecipeList; set => RecipeList = value; }
    }
}

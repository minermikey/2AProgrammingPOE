using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1Prog2A
{
    internal class Scaled
    {
        public static void ScaledBy3() {

            Recipe recipe = new Recipe();

            foreach (var item in recipe.RecipeList1) 
            {

                Console.WriteLine(recipe.IngredientQuanity * 3);

            }

        }

                
    }
}

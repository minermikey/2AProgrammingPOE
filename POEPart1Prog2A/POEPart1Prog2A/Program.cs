using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1Prog2A
{
    internal class Program
    {

       
        static void Main(string[] args)
        {

            bool AskingTheUser = true;
            int choice;

            do
            {

                Console.WriteLine("PlEASE choose an option: \n1 : Add an ingredient\n2 : Review ingredient\n3 : Number of ingredients ");
                while (!int.TryParse(Console.ReadLine(), out choice)) 
                {
                    Console.WriteLine("Please enter a valid number for the quantity.");
                }

                switch (choice)
                {
                    case 1:
                        AddingInfoToTheList();
                        break;
                    case 2:
                        RetrevingInformation();
                        break;
                    case 3:
                        AmountOfItems();
                        break;

                    default:
                        break;
                }

            } while (true);

        }

        public static void RetrevingInformation() 
        {

            Recipe recipe = new Recipe();

            // this will read through every 
            foreach (var item in recipe.RecipeList1)
            {
                Console.WriteLine(item);
            }
           
        }

        public static void AddingInfoToTheList() 
        {
        
            // we are going to be creatign a small recipet storer 
            // some requirements is that this is for a single recipe
              
            // going to use a while loop to keep asking the user if they want add more, but to not pester them i will use an if statment to 

            Recipe recipe = new Recipe();

            double ingredientQuanity;

            bool addMoreItemsToRecipe = true;
            do
            {

                // going to populate the recipe in here 
                Console.WriteLine("What is the name of the ingreident that you are adding? : ");
                recipe.IngredientName = Console.ReadLine();
                 
                // we are going to convert this into a double, we will be using a 
                Console.WriteLine("How much is a specific measurement did you use? : (please use a number)");
                while (!double.TryParse(Console.ReadLine(), out ingredientQuanity)) // this while loop tries to convert the input into a double and if it is unsuccessful then the
                                                                                    // propgram will return a false value and ask you to try again until you put in the correct one
                {
                    Console.WriteLine("Please enter a valid number for the quantity.");
                }

                ingredientQuanity = recipe.IngredientQuanity;

                // you could add in  a try catch to make sure that a number is added and if not then it will reask for another number

                //what unit of measurement the user is adding
                Console.WriteLine("Please specify what unit of measurement you will be using (eg. teaspoon...) : ");
                recipe.UnitOfMeasurement = Console.ReadLine();

                // going to all of these values into list 

                recipe.RecipeList1.Add("Ingredient name is: " + recipe.IngredientName + "\nThe measurement is: " + recipe.UnitOfMeasurement + "\nThe quantityingredient " + recipe.IngredientQuanity);

                Console.WriteLine("Would you like to add another ingredient");
                string desision = Console.ReadLine().ToLower();

                // yes there is alot simplier way of doing this but i made the code extremely easy to understand for the student who will most likely look at it

                if (desision == "yes")// goes back to the do while
                {
                    addMoreItemsToRecipe = true;
                }
                else
                if (desision == "no") // this leaves the do while
                {
                    addMoreItemsToRecipe = false;
                }

                // this while statement will keep asking the user for a vaild answer before continuing to the next part of the program
                while (desision != "yes" && desision != "no")
                {
                    Console.WriteLine("Please choose a valid options");
                    desision = Console.ReadLine().ToLower();
                    // put int a check for the variable 
                    if (desision == "yes")// goes back to the do while
                    {
                        addMoreItemsToRecipe = true;
                    }
                    else
            if (desision == "no") // this leaves the do while
                    {
                        addMoreItemsToRecipe = false;
                    }
                }

                // for tommorow make the if statment that run the while loop

            }
            while (addMoreItemsToRecipe == true); // end of do while

            Console.WriteLine("You finish add information to the recipe.");

        }

        public static void AmountOfItems() 
        {

            Recipe recipe = new Recipe();
            Console.WriteLine(recipe.RecipeList1.Count);

        }

    }

}

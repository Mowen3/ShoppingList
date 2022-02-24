using System;
using System.Collections.Generic;

namespace ShoppingListLab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello. Welcome to my Co-op Market.");
            Console.WriteLine("");
            Console.WriteLine("*****************************************");
            Console.WriteLine("");
            Console.WriteLine("Create a shopping list from any of the items in the list below:");
            Console.WriteLine("");

            bool option = true;

            Dictionary<string, decimal> foods = new Dictionary<string, decimal>();
            foods.Add("pizza", 3.50m);
            foods.Add("chicken", 5.49m);
            foods.Add("butter", 2.49m);
            foods.Add("yogurt", 0.99m);
            foods.Add("sugar", 2.95m);
            foods.Add("bbq sauce", 4.20m);
            foods.Add("pickles", 3.65m);
            foods.Add("blackened seasoning", 2.76m);

            List<string> cart = new List<string>();

            decimal total = 0.00m; 

            while (option)
            {

                foreach (var pair in foods)
                {
                    Console.WriteLine($"Item: {pair.Key}   Price: ${pair.Value}");
                }

                Console.WriteLine("");

                    Console.WriteLine("What would you like to add to your list?");
                    var choice = Console.ReadLine();

                    if (foods.ContainsKey(choice))
                    {
                        cart.Add(choice);
                        Console.WriteLine($"{choice} costs  {foods[choice]}  and has been added to your list");
                        total += foods[choice];
                    }

                    else
                    {
                        Console.WriteLine("Sorry, but we do not carry that. Please try to list another item");
                        continue;
                    }

               
                Console.WriteLine("Would you like to add more to your list (y/n)");

                var yn = Console.ReadLine();

                if (yn == "y")
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Your shopping list contains:");
                    Console.WriteLine("");
                    foreach (string item in cart)
                    {
                        Console.WriteLine(item); 
                    }
                    Console.WriteLine("*****************************");
                    Console.WriteLine($"Your total is: ${total}");
                    break;
                }

            }

        }
    }
}

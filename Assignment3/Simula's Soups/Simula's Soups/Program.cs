//Written by Swornashabi
// 2/17/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simula_s_Soups
{
    public enum FoodType
    {
        Soup,
        Stew,
        Gumbo
    }

    public enum MainIngredient
    {
        Mushrooms,
        Chicken,
        Carrots,
        Potatoes
    }

    public enum Seasoning
    {
        Spicy,
        Salty,
        Sweet
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Choose a type: Soup, Stew, Gumbo");
                FoodType type = (FoodType)Enum.Parse(typeof(FoodType), Console.ReadLine(), true);

                Console.WriteLine("choose a main ingredient: Mushrooms, Chicken, Carrots, Potatoes");
                MainIngredient ingredient = (MainIngredient)Enum.Parse(typeof(MainIngredient), Console.ReadLine(), true);

                Console.WriteLine("Choose a seasoning: Spicy, Salty, Sweet");
                Seasoning seasoning = (Seasoning)Enum.Parse(typeof(Seasoning), Console.ReadLine(), true);

                var soup = (type, ingredient, seasoning);
                Console.WriteLine($"You made a {soup.seasoning} {soup.ingredient} {soup.type}.");

                Console.WriteLine("Do you want to make another soup? (yes/no)");
                if (Console.ReadLine() != "yes")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}

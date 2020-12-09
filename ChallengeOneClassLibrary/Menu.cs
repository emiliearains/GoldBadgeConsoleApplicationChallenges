using System;
using System.Collections.Generic;

namespace ChallengeOneClassLibrary
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal MealPrice { get; set; }

        public Menu(int mealNumber, string mealName, string mealDescription, List<string> ingredients, decimal mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            MealPrice = mealPrice;
        
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeOneClassLibrary
{
    public class MenuRepo
    {
        private List<Menu> Menu = new List<Menu>();
        // Create
        public void AddMenuItem(Menu menu)
        {
            Menu.Add(menu);
        }
        //public void SeedMenu()
        //{
        //    Menu.Add(new Menu(1, "Teriyaki Chicken", "Lunch", new List<string>() {"chicken", "rice", "vegetables", "teriyaki sauce","soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(2, "Orange Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "orange sauce", "soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(3, "Kung Pao Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "kung pao sauce", "soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(4, "Hunan Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "hunan sauce", "soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(5, "Sesame Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "sesame sauce", "soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(6, "Mongolian Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "mongolian sauce", "soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(7, "Szechuan Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "szechuan sauce", "soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(8, "Hot & Spicy Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "hot & spicy sauce", "soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(9, "Honey Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "honey sauce", "soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(10, "Garlic Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "garlic sauce", "soy sauce" }, 9.99m));
        //    Menu.Add(new Menu(11, "Curry Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "curry sauce", "soy sauce" }, 9.99m));
        //}
        // Read
        public List<Menu> GetMenu()
        {
            return Menu;
        }
        public Menu GetMenuByMenuNumber(int menuNumber)
        {
            foreach (Menu menu in Menu)
            {
                if (menu.MealNumber == menuNumber)
                {
                    return menu;
                }
            }
            return null;
        }

        //Update
        public bool UpdateMenuItem(int menuNumber, Menu newMenu)
        {
            Menu existingMenu = GetMenuByMenuNumber(menuNumber);
            if (existingMenu != null)
            {
                existingMenu.MealNumber = newMenu.MealNumber;
                existingMenu.MealName = newMenu.MealName;
                existingMenu.MealDescription = newMenu.MealDescription;
                existingMenu.Ingredients = newMenu.Ingredients;
                existingMenu.MealPrice = newMenu.MealPrice;
                return true;
            }
            else
            {
                return false;
            }
        }
        // Delete
        public bool DeleteMenu(int menuNumber)
        {
            foreach (Menu menu in Menu)
            {
                if (menu.MealNumber == menuNumber)
                {
                    Menu.Remove(menu);
                    return true;
                }
            }
            return false;
        }
    }
}

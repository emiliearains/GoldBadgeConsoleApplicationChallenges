using ChallengeOneClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne
{
    public class ProgramUI
    {
        public MenuRepo Menu { get; set; }
        public void Run()
        {
            Menu = new MenuRepo();
            SeedMenu();
            MainMenu();
        }
        public void SeedMenu()
        {
            Menu.AddMenuItem(new Menu(1, "Teriyaki Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "teriyaki sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(2, "Orange Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "orange sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(3, "Kung Pao Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "kung pao sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(4, "Hunan Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "hunan sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(5, "Sesame Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "sesame sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(6, "Mongolian Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "mongolian sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(7, "Szechuan Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "szechuan sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(8, "Hot & Spicy Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "hot & spicy sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(9, "Honey Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "honey sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(10, "Garlic Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "garlic sauce", "soy sauce" }, 9.99m));
            Menu.AddMenuItem(new Menu(11, "Curry Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "curry sauce", "soy sauce" }, 9.99m));
        }
        public void MainMenu()
        {
            bool isAcceptingInput = true;
            while (isAcceptingInput == true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add new menu item.");
                Console.WriteLine("2. Update menu item.");
                Console.WriteLine("3. Delete menu item.");
                Console.WriteLine("4. See entire menu.");
                Console.WriteLine("5. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        SubMenuAdd();
                        break;
                    case "2":
                        SubMenuUpdate();
                        break;
                    case "3":
                        SubMenuDelete();
                        break;
                    case "4":
                        SubMenuGet();
                        break;
                    default:
                        Console.WriteLine("That is not an accepted input.");
                        break;
                }
            }

        }
        public void SubMenuAdd()
        {
            Console.Clear();
            Menu newSubMenuItem = new Menu();

            Console.WriteLine("Enter new meal number:" );
            newSubMenuItem.MealNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter new meal name:");
            newSubMenuItem.MealName = Console.ReadLine();

            Console.WriteLine("Enter new meal description:");
            newSubMenuItem.MealDescription = Console.ReadLine();

            Console.WriteLine("Enter new meal price:");
            newSubMenuItem.MealPrice = decimal.Parse(Console.ReadLine());

            Menu.AddMenuItem(newSubMenuItem);
        }
        public void SubMenuUpdate()
        {
            Console.Clear();
            Console.WriteLine("Enter the meal number that you would like to update:");
            int mealNumber = Int32.Parse(Console.ReadLine());
            Menu updatedMeal = Menu.GetMenuByMenuNumber(mealNumber);

            bool isAcceptingInput = true;
            while (isAcceptingInput == true)
            {
                Console.Clear();
                Console.WriteLine($"Updating {updatedMeal.MealName}...what would you like to update?");
                Console.WriteLine("1. Update Meal Name");
                Console.WriteLine("2. Update Meal Price");
                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();

                //Evaluate user input and act accordingly
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter the updated meal name:");
                        string existingName = updatedMeal.MealName;
                        updatedMeal.MealName = Console.ReadLine();
                        Menu.UpdateMenuItem(mealNumber, updatedMeal);
                        Console.WriteLine($"{existingName} is changed to {updatedMeal.MealName}. Press any key to continue.");
                        Console.Read();
                        break;

                    case "2":
                        Console.WriteLine("Enter the updated meal price:");
                        Console.Write("$");
                        decimal mealPrice = updatedMeal.MealPrice;
                        updatedMeal.MealPrice = decimal.Parse(Console.ReadLine());
                        Menu.UpdateMenuItem(mealNumber, updatedMeal);
                        Console.WriteLine($"{updatedMeal.MealName} price changed to ${updatedMeal.MealPrice}. Press any key to continue.");
                        Console.Read();
                        break;

                    case "3":
                        isAcceptingInput = false;
                        break;

                } 
            } 
        }
        public void SubMenuDelete()
        {
            Console.Clear();
            Console.WriteLine("Enter the meal number to delete:");
            int mealNumber = Int32.Parse(Console.ReadLine());
            Menu selectedMeal = Menu.GetMenuByMenuNumber(mealNumber);
            
            Console.WriteLine($"Are you sure you want to delete meal number {mealNumber} ({selectedMeal.MealName}))? Y or N:");
            string deleteSubMenu = Console.ReadLine();
            
            if (deleteSubMenu == "Y")
            {
                Menu.DeleteMenu(mealNumber);
                Console.WriteLine("Meal has been deleted.");
                Console.Read();
            }
            else
            {
                SubMenuDelete();
            }
            Console.WriteLine("");
        }
        public void SubMenuGet()
        {
            Console.Clear();
            List<Menu> menuOfMeals = Menu.GetMenu();

            foreach (Menu menu in menuOfMeals)
            {
                Console.WriteLine($"Meal #: {menu.MealNumber}");
                Console.WriteLine($"Meal Name: {menu.MealName}");
                Console.WriteLine($"Price: ${menu.MealPrice}");
                Console.WriteLine("...........................");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }
}

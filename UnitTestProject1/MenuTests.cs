using ChallengeOneClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class MenuTests
    {
        private MenuRepo _repo;
        private Menu _menu;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepo();
            _menu = new Menu(1, "Teriyaki Chicken", "Lunch", new List<string>() {"chicken", "rice", "vegetables", "teriyaki sauce", "soy sauce"}, 9.99m);
            _repo.AddMenuItem(_menu);
        }
        [TestMethod]
        public void AddMenuItem_ShouldGetNotNull()
        {
            Menu menu = new Menu(12, "Teriyaki Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "teriyaki sauce", "soy sauce" }, 9.99m);
            //menu.MealNumber = 12;
            _repo.AddMenuItem(menu);
            Menu mealMenu = _repo.GetMenuByMenuNumber(12);

            Assert.IsNotNull(mealMenu);
        }

        [TestMethod]
        public void UpdateMenuItem_ShouldReturnTrue()
        {
            Menu newMealItem = new Menu(1, "Teriyaki Chicken", "Lunch", new List<string>() { "chicken", "rice", "vegetables", "teriyaki sauce", "soy sauce" }, 9.99m);
            //_repo.AddMenuItem(newMealItem);
            //newMealItem.MealName = "Yum Yum Chicken";
            bool updateItem = _repo.UpdateMenuItem(1, newMealItem);

            Assert.IsTrue(updateItem);
        }

        [TestMethod]
        public void DeleteMenu_ShouldReturnTrue()
        {
            bool deleteMealItem = _repo.DeleteMenu(_menu.MealNumber);

            Assert.IsTrue(deleteMealItem);
        }
    }
}

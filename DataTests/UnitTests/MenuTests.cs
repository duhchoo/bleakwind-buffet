/*
 * Author: Hutch Turner
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldHaveAllEntrees()
        {
            List<IOrderItem> list = (List<IOrderItem>)Menu.Entrees();
            Assert.Collection(list,
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString())
                );
        }

        [Fact]
        public void ShouldHaveAllDrinks()
        {
            List<IOrderItem> list = (List<IOrderItem>)Menu.Drinks();
            Assert.Collection(list,
                //Aretino Apple Juice
                item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),

                //Candlehearth Coffee
                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),

                //Markarth Milk
                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                item => Assert.Contains("Large Markarth Milk", item.ToString()),

                //Sailor Soda
                item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()),

                //Warrior Water
                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString())
            );
        }

        [Fact]
        public void ShouldHaveAllSides()
        {
            List<IOrderItem> list = (List<IOrderItem>)Menu.Sides();
            Assert.Collection(list,
                item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),

                item => Assert.Contains("Small Fried Miraak", item.ToString()),
                item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                item => Assert.Contains("Large Fried Miraak", item.ToString()),

                item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Large Mad Otar Grits", item.ToString()),

                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString())
                );
        }

        [Fact]
        public void ShouldHaveAllItemsInMenu()
        {
            List<IOrderItem> list = (List<IOrderItem>)Menu.FullMenu();
            Assert.Collection(list,
                //Entrees
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()),

                //Aretino Apple Juice
                item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),

                //Candlehearth Coffee
                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),

                //Markarth Milk
                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                item => Assert.Contains("Large Markarth Milk", item.ToString()),

                //Sailor Soda
                item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()),

                //Warrior Water
                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString()),

                //Sides
                item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),

                item => Assert.Contains("Small Fried Miraak", item.ToString()),
                item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                item => Assert.Contains("Large Fried Miraak", item.ToString()),

                item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Large Mad Otar Grits", item.ToString()),

                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString())
            );
        }


        [Fact]
        public void NullSearchReturnsFullMenu()
        {
            var search = Menu.Search(Menu.FullMenu(), null);

            Assert.Collection(search,
                //entrees
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()),

                //sides
                item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),

                item => Assert.Contains("Small Fried Miraak", item.ToString()),
                item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                item => Assert.Contains("Large Fried Miraak", item.ToString()),

                item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Large Mad Otar Grits", item.ToString()),

                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString()),

                //drinks
                item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),

                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),

                item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),

                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                item => Assert.Contains("Large Markarth Milk", item.ToString()),

                item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString())
                );
        }

        [Fact]
        public void SearchWillReturnAppropriateResults()
        {
            var search1 = Menu.Search(Menu.FullMenu(), "Briarheart Burger");
            Assert.Collection(search1,
                item => Assert.Contains("Briarheart Burger", item.ToString())
                );

            var search2 = Menu.Search(Menu.FullMenu(), "Water");
            Assert.Collection(search2,
                item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString())
                );
        }

        [Fact]
        public void FilterByCategoryReturnsFullMenuCategoryIsNull()
        {
            var category = Menu.FilterByCategory(Menu.FullMenu(), null);

            Assert.Collection(category,
                //entrees
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()),

                //sides
                item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),

                item => Assert.Contains("Small Fried Miraak", item.ToString()),
                item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                item => Assert.Contains("Large Fried Miraak", item.ToString()),

                item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Large Mad Otar Grits", item.ToString()),

                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString()),

                //drinks
                item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),

                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),

                item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),

                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                item => Assert.Contains("Large Markarth Milk", item.ToString()),

                item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString())
                );
        }

        [Fact]
        public void FilterByPriceReturnsFullMenuCategoryIsNull()
        {
            var price = Menu.FilterByPrice(Menu.FullMenu(), 0, 0);

            Assert.Collection(price,
                //entrees
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()),

                //sides
                item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),

                item => Assert.Contains("Small Fried Miraak", item.ToString()),
                item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                item => Assert.Contains("Large Fried Miraak", item.ToString()),

                item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Large Mad Otar Grits", item.ToString()),

                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString()),

                //drinks
                item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),

                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),

                item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),

                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                item => Assert.Contains("Large Markarth Milk", item.ToString()),

                item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString())
                );
        }

        [Fact]
        public void FilterByCalorieReturnsFullMenuCategoryIsNull()
        {
            var calorie = Menu.FilterByCalories(Menu.FullMenu(), 0, 0);

            Assert.Collection(calorie,
                //entrees
                item => Assert.Contains("Briarheart Burger", item.ToString()),
                item => Assert.Contains("Double Draugr", item.ToString()),
                item => Assert.Contains("Garden Orc Omelette", item.ToString()),
                item => Assert.Contains("Philly Poacher", item.ToString()),
                item => Assert.Contains("Smokehouse Skeleton", item.ToString()),
                item => Assert.Contains("Thalmor Triple", item.ToString()),
                item => Assert.Contains("Thugs T-Bone", item.ToString()),

                //sides
                item => Assert.Contains("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Contains("Large Dragonborn Waffle Fries", item.ToString()),

                item => Assert.Contains("Small Fried Miraak", item.ToString()),
                item => Assert.Contains("Medium Fried Miraak", item.ToString()),
                item => Assert.Contains("Large Fried Miraak", item.ToString()),

                item => Assert.Contains("Small Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Contains("Large Mad Otar Grits", item.ToString()),

                item => Assert.Contains("Small Vokun Salad", item.ToString()),
                item => Assert.Contains("Medium Vokun Salad", item.ToString()),
                item => Assert.Contains("Large Vokun Salad", item.ToString()),

                //drinks
                item => Assert.Contains("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Contains("Large Aretino Apple Juice", item.ToString()),

                item => Assert.Contains("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Candlehearth Coffee", item.ToString()),

                item => Assert.Contains("Small Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Medium Decaf Candlehearth Coffee", item.ToString()),
                item => Assert.Contains("Large Decaf Candlehearth Coffee", item.ToString()),

                item => Assert.Contains("Small Markarth Milk", item.ToString()),
                item => Assert.Contains("Medium Markarth Milk", item.ToString()),
                item => Assert.Contains("Large Markarth Milk", item.ToString()),

                item => Assert.Contains("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Small Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Medium Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Contains("Large Watermelon Sailor Soda", item.ToString()),

                item => Assert.Contains("Small Warrior Water", item.ToString()),
                item => Assert.Contains("Medium Warrior Water", item.ToString()),
                item => Assert.Contains("Large Warrior Water", item.ToString())
                );
        }
    }
}

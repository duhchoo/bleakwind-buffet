/*
* Author: Hutch Turner
* Class name: ComboMealTests.cs
* Purpose: Tests for the combo meal.
*/
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboMealTests
    {

        [Fact]
        public void ShouldBeAbleToSetEntree()
        {
            ComboMeal comboMeal = new ComboMeal();

            comboMeal.Entree = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", comboMeal.Entree.ToString());

            comboMeal.Entree = new DoubleDraugr();
            Assert.Equal("Double Draugr", comboMeal.Entree.ToString());

            comboMeal.Entree = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", comboMeal.Entree.ToString());
        }

        [Fact]
        public void ShouldbeAbleToSetDrink()
        {
            ComboMeal comboMeal = new ComboMeal();

            comboMeal.Drink = new AretinoAppleJuice();
            Assert.Equal("Small Aretino Apple Juice", comboMeal.Drink.ToString());

            comboMeal.Drink = new SailorSoda();
            Assert.Equal("Small Cherry Sailor Soda", comboMeal.Drink.ToString());

            comboMeal.Drink = new WarriorWater();
            Assert.Equal("Small Warrior Water", comboMeal.Drink.ToString());
        }

        [Fact]
        public void ShouldbeAbleToSetSide()
        {
            ComboMeal comboMeal = new ComboMeal();

            comboMeal.Side = new DragonbornWaffleFries();
            Assert.Equal("Small Dragonborn Waffle Fries", comboMeal.Side.ToString());

            comboMeal.Side = new FriedMiraak();
            Assert.Equal("Small Fried Miraak", comboMeal.Side.ToString());

            comboMeal.Side = new VokunSalad();
            Assert.Equal("Small Vokun Salad", comboMeal.Side.ToString());
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ComboMeal comboMeal = new ComboMeal();

            comboMeal.Entree = new BriarheartBurger();
            Assert.Equal(5.32, comboMeal.Price);

            comboMeal.Drink = new AretinoAppleJuice();
            Assert.Equal(6.74, comboMeal.Price);

            comboMeal.Side = new DragonbornWaffleFries();
            Assert.Equal(7.16, comboMeal.Price);
        }

        [Fact]
        public void ShouldReturnCorrectPriceWithDifferentSize()
        {
            ComboMeal comboMeal = new ComboMeal();

            comboMeal.Entree = new BriarheartBurger();
            comboMeal.Drink = new AretinoAppleJuice();
            comboMeal.Drink.Size = Data.Enums.Size.Medium;
            Assert.Equal(6.19, comboMeal.Price);

            comboMeal.Side = new DragonbornWaffleFries();
            comboMeal.Side.Size = Data.Enums.Size.Large;
            Assert.Equal(7.15, comboMeal.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ComboMeal comboMeal = new ComboMeal();

            comboMeal.Entree = new BriarheartBurger();
            Assert.Equal((uint) 743, comboMeal.Calories);

            comboMeal.Drink = new AretinoAppleJuice();
            Assert.Equal((uint) 787, comboMeal.Calories);

            comboMeal.Side = new MadOtarGrits();
            Assert.Equal((uint) 892, comboMeal.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectCaloriesWithDifferentSize()
        {
            ComboMeal comboMeal = new ComboMeal();

            comboMeal.Entree = new BriarheartBurger();
            comboMeal.Drink = new AretinoAppleJuice();
            comboMeal.Drink.Size = Data.Enums.Size.Medium;
            Assert.Equal((uint) 831, comboMeal.Calories);

            comboMeal.Side = new VokunSalad();
            comboMeal.Side.Size = Data.Enums.Size.Large;
            Assert.Equal(904, comboMeal.Price);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ComboMeal comboMeal = new ComboMeal();

            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Bun = false;
            comboMeal.Entree = bhb;
            Assert.Contains("Briarheart Burger", comboMeal.SpecialInstructions);
            Assert.Contains(" - Hold bun", comboMeal.SpecialInstructions);

            AretinoAppleJuice aj = new AretinoAppleJuice();
            aj.Ice = true;
            comboMeal.Drink = aj;
            Assert.Contains("Small Aretino Apple Juice", comboMeal.SpecialInstructions);
            Assert.Contains(" - Add ice", comboMeal.SpecialInstructions);

            MadOtarGrits mog = new MadOtarGrits();
            mog.Size = Data.Enums.Size.Medium;
            comboMeal.Side = mog;
            Assert.Contains("Medium Mad Otar Grits", comboMeal.SpecialInstructions);
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            ComboMeal comboMeal = new ComboMeal();
            Assert.IsAssignableFrom<IOrderItem>(comboMeal);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            ComboMeal comboMeal = new ComboMeal();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(comboMeal);
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnPrice()
        {
            ComboMeal comboMeal = new ComboMeal();

            Assert.PropertyChanged(comboMeal, "Price", () =>
            {
                comboMeal.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(comboMeal, "Price", () =>
            {
                comboMeal.Drink = new AretinoAppleJuice();
            });

            Assert.PropertyChanged(comboMeal, "Price", () =>
            {
                comboMeal.Side = new VokunSalad();
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnCalories()
        {
            ComboMeal comboMeal = new ComboMeal();

            Assert.PropertyChanged(comboMeal, "Calories", () =>
            {
                comboMeal.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(comboMeal, "Calories", () =>
            {
                comboMeal.Drink = new AretinoAppleJuice();
            });

            Assert.PropertyChanged(comboMeal, "Calories", () =>
            {
                comboMeal.Side = new VokunSalad();
            });
        }

        [Fact]
        public void PropertyChangedShouldBeInvokedOnSpecialInstructions()
        {
            ComboMeal comboMeal = new ComboMeal();

            Assert.PropertyChanged(comboMeal, "SpecialInstructions", () =>
            {
                comboMeal.Entree = new BriarheartBurger();
            });

            Assert.PropertyChanged(comboMeal, "SpecialInstructions", () =>
            {
                comboMeal.Drink = new AretinoAppleJuice();
            });

            Assert.PropertyChanged(comboMeal, "SpecialInstructions", () =>
            {
                comboMeal.Side = new VokunSalad();
            });
        }
    }
}

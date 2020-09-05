/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.True(bhb.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Bun = true;
            Assert.True(bhb.Bun);
            bhb.Bun = false;
            Assert.False(bhb.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Ketchup = true;
            Assert.True(bhb.Ketchup);
            bhb.Ketchup = false;
            Assert.False(bhb.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Mustard = true;
            Assert.True(bhb.Mustard);
            bhb.Mustard = false;
            Assert.False(bhb.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Pickle = true;
            Assert.True(bhb.Pickle);
            bhb.Pickle = false;
            Assert.False(bhb.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Cheese = true;
            Assert.True(bhb.Cheese);
            bhb.Cheese = false;
            Assert.False(bhb.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.Equal(6.32, bhb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.Equal((uint)743, bhb.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger bhb = new BriarheartBurger();
            bhb.Bun = includeBun;
            bhb.Ketchup = includeKetchup;
            bhb.Mustard = includeMustard;
            bhb.Pickle = includePickle;
            bhb.Cheese = includeCheese;
            if (!includeBun) Assert.Contains("Hold bun", bhb.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", bhb.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", bhb.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", bhb.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", bhb.SpecialInstructions);
            else Assert.Empty(bhb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger bhb = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", bhb.ToString());
        }
    }
}
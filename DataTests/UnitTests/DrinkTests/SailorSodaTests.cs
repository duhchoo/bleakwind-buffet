﻿/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeFromIOrder()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<IOrderItem>(ss);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda ss = new SailorSoda();
            Assert.IsAssignableFrom<Drink>(ss);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.True(ss.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda ss = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = true;
            Assert.True(ss.Ice);
            ss.Ice = false;
            Assert.False(ss.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = Size.Large;
            Assert.Equal(Size.Large, ss.Size);
            ss.Size = Size.Medium;
            Assert.Equal(Size.Medium, ss.Size);
            ss.Size = Size.Small;
            Assert.Equal(Size.Small, ss.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda ss = new SailorSoda();
            ss.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, ss.Flavor);
            ss.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, ss.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(price, ss.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda ss = new SailorSoda();
            ss.Size = size;
            Assert.Equal(cal, ss.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda ss = new SailorSoda();
            ss.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", ss.SpecialInstructions);
            else Assert.Empty(ss.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda ss = new SailorSoda();
            ss.Flavor = flavor;
            ss.Size = size;
            Assert.Equal(name, ss.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var SS = new SailorSoda();

            Assert.PropertyChanged(SS, "Size", () =>
            {
                SS.Size = Size.Medium;
            });

            Assert.PropertyChanged(SS, "Size", () =>
            {
                SS.Size = Size.Small;
            });

            Assert.PropertyChanged(SS, "Size", () =>
            {
                SS.Size = Size.Large;
            });
        }


        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var SS = new SailorSoda();

            Assert.PropertyChanged(SS, "Ice", () =>
            {
                SS.Ice = false;
            });

            Assert.PropertyChanged(SS, "Ice", () =>
            {
                SS.Ice = true;
            });
        }

        [Fact]
        public void ChangingFlavorNotifiesFlavorProperty()
        {
            var SS = new SailorSoda();

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Blackberry;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Cherry;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Grapefruit;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Lemon;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Peach;
            });

            Assert.PropertyChanged(SS, "Flavor", () =>
            {
                SS.Flavor = SodaFlavor.Watermelon;
            });
        }

        [Fact]
        public void HasCorrectDescription()
        {
            var item = new SailorSoda();
            Assert.Equal("An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.", item.Description);
        }
    }
}

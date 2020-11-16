﻿/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dbwf);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dbwf.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            dbwf.Size = Size.Large;
            Assert.Equal(Size.Large, dbwf.Size);
            dbwf.Size = Size.Medium;
            Assert.Equal(Size.Medium, dbwf.Size);
            dbwf.Size = Size.Small;
            Assert.Equal(Size.Small, dbwf.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            Assert.Empty(dbwf.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            dbwf.Size = size;
            Assert.Equal(price, dbwf.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            dbwf.Size = size;
            Assert.Equal(calories, dbwf.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            dbwf.Size = size;
            Assert.Equal(name, dbwf.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var dbwf = new DragonbornWaffleFries();

            Assert.PropertyChanged(dbwf, "Size", () =>
            {
                dbwf.Size = Size.Medium;
            });

            Assert.PropertyChanged(dbwf, "Size", () =>
            {
                dbwf.Size = Size.Small;
            });

            Assert.PropertyChanged(dbwf, "Size", () =>
            {
                dbwf.Size = Size.Large;
            });
        }

        [Fact]
        public void HasCorrectDescription()
        {
            var item = new DragonbornWaffleFries();
            Assert.Equal("Crispy fried potato waffle fries.", item.Description);
        }
    }
}
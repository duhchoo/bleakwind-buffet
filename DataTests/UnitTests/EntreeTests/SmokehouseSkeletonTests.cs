/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeFromIOrder()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(shs);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(shs);
        }

        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.True(shs.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.SausageLink = true;
            Assert.True(shs.SausageLink);
            shs.SausageLink = false;
            Assert.False(shs.SausageLink);

        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.Egg = true;
            Assert.True(shs.Egg);
            shs.Egg = false;
            Assert.False(shs.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.HashBrowns = true;
            Assert.True(shs.HashBrowns);
            shs.HashBrowns = false;
            Assert.False(shs.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.Pancake = true;
            Assert.True(shs.Pancake);
            shs.Pancake = false;
            Assert.False(shs.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal(5.62, shs.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal((uint)602, shs.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            shs.SausageLink = includeSausage;
            shs.Egg = includeEgg;
            shs.HashBrowns = includeHashbrowns;
            shs.Pancake = includePancake;
            if (!includeSausage) Assert.Contains("Hold sausage", shs.SpecialInstructions);
            else if (!includeEgg) Assert.Contains("Hold eggs", shs.SpecialInstructions);
            else if (!includeHashbrowns) Assert.Contains("Hold hash browns", shs.SpecialInstructions);
            else if (!includePancake) Assert.Contains("Hold pancakes", shs.SpecialInstructions);
            else Assert.Empty(shs.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", shs.ToString());
        }

        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();

            Assert.PropertyChanged(shs, "SausageLink", () =>
            {
                shs.SausageLink = false;
            });

            Assert.PropertyChanged(shs, "SausageLink", () =>
            {
                shs.SausageLink = true;
            });

        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();

            Assert.PropertyChanged(shs, "Egg", () =>
            {
                shs.Egg = false;
            });

            Assert.PropertyChanged(shs, "Egg", () =>
            {
                shs.Egg = true;
            });

        }

        [Fact]
        public void ChangingHashBrownsNotifiesHashBrownsProperty()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();

            Assert.PropertyChanged(shs, "HashBrowns", () =>
            {
                shs.HashBrowns = false;
            });

            Assert.PropertyChanged(shs, "HashBrowns", () =>
            {
                shs.HashBrowns = true;
            });

        }

        [Fact]
        public void ChangingPancakeNotifiesPancakeProperty()
        {
            SmokehouseSkeleton shs = new SmokehouseSkeleton();

            Assert.PropertyChanged(shs, "Pancake", () =>
            {
                shs.Pancake = false;
            });

            Assert.PropertyChanged(shs, "Pancake", () =>
            {
                shs.Pancake = true;
            });

        }

        [Fact]
        public void HasCorrectDescription()
        {
            var item = new SmokehouseSkeleton();
            Assert.Equal("Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.", item.Description);
        }
    }
}
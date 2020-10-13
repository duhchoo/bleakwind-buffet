using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ChangedCalorieCountWhenAddingJuice()
        {
            Order order = new Order();
            order.Add(new AretinoAppleJuice());
            Assert.Equal(order.Calories, (uint) 44);
        }

        [Fact]
        public void CanAddIOrderItem()
        {
            Order order = new Order();
            BriarheartBurger bhb = new BriarheartBurger();
            order.Add(bhb);
            Assert.Contains(bhb, order.orderItemsList);

            order.Add(new AretinoAppleJuice());
            Assert.Contains(bhb, order.orderItemsList);
        }

        [Fact]
        public void CanRemoveIOrderItem()
        {
            Order order = new Order();
            BriarheartBurger bhb = new BriarheartBurger();
            order.Add(bhb);
            order.Remove(bhb);
            Assert.Empty(order);
        }

        [Fact]
        public void ShouldBeAssignableToNotifyPropertyChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void ShouldBeAssignableToICollection()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<ICollection>(order);
        }

        [Fact]
        public void ShouldBeAssignableToINotifyCollectionChanged()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }
    }
}

/*
* Author: Hutch Turner
* Class name: CandlehearthCoffee.cs
* Purpose: Class used to represent the Candlehearth Coffee.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for changes in the properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.75;
                if (Size == Size.Medium) return 1.25;
                if (Size == Size.Large) return 1.75;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets and sets the calories of the drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 7;
                if (Size == Size.Medium) return 10;
                if (Size == Size.Large) return 20;
                throw new NotImplementedException();
            }
        }

        bool cream = false;

        /// <summary>
        /// Property is true when the cream is added.
        /// </summary>
        public bool RoomForCream
        {
            get => cream;
            set
            {
                if (cream != value)
                {
                    cream = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                }
            }
        }

        bool decaf = false;

        /// <summary>
        /// Property is true when the drink is decaf.
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                if (decaf != value)
                {
                    decaf = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                }
            }
        }

        bool ice = false;

        /// <summary>
        /// Ice in the drink
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                }
            }
        }

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                if (instructions.Count > 0) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!Decaf) return $"{Size} Candlehearth Coffee";
            else return $"{Size} Decaf Candlehearth Coffee";
        }

        Size size = Size.Small;

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                if (size != value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
            }
        }

    }
}

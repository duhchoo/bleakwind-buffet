/*
* Author: Hutch Turner
* Class name: CandlehearthCoffee.cs
* Purpose: Class used to represent the Candlehearth Coffee.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        private double _price = 0.75;

        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 0.75;
                if (Size == Size.Medium) _price = 1.25;
                if (Size == Size.Large) _price = 1.75;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        private uint _calories = 7;

        /// <summary>
        /// Gets and sets the calories of the drink.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 7;
                if (Size == Size.Medium) _calories = 10;
                if (Size == Size.Large) _calories = 20;
            }
        }

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size
        { get; set; } = Size.Small;

        /// <summary>
        /// Property is true when the ice is added.
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Property is true when the cream is added.
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Property is true when the drink is decaf.
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public List<string> SpecialInstruction
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Add Cream");
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

    }
}

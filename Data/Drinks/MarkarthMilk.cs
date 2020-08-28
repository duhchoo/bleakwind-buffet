/*
* Author: Hutch Turner
* Class name: MarkarthMilk.cs
* Purpose: Class used to represent the Markarth Milk.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        private double _price = 1.05;

        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 1.05;
                if (Size == Size.Medium) _price = 1.11;
                if (Size == Size.Large) _price = 1.22;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        private uint _calories = 56;

        /// <summary>
        /// Gets and sets the calories of the drink.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 56;
                if (Size == Size.Medium) _calories = 72;
                if (Size == Size.Large) _calories = 93;
            }
        }

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size
        { get; set; } = Size.Small;



        /// <summary>
        /// Property is true for the psychopaths who want ice in their MILK.
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public List<string> SpecialInstruction
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }

    }
}

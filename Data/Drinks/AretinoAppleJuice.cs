/*
* Author: Hutch Turner
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to represent the Aretino Apple Juice.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
    {
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        private double _price = 0.62;

        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 0.62;
                if (Size == Size.Medium) _price = 0.87;
                if (Size == Size.Large) _price = 1.01;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        private uint _calories = 44;

        /// <summary>
        /// Gets and sets the calories of the drink.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 44;
                if (Size == Size.Medium) _calories = 88;
                if (Size == Size.Large) _calories = 132;
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
            return $"{Size} Aretino Apple Juice";
        }

    }
}

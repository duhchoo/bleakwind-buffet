﻿/*
* Author: Hutch Turner
* Class name: SailorSoda.cs
* Purpose: Class used to represent the Sailor Soda.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        /// <summary>
        /// Gets the price of the drink.
        /// </summary>
        private double _price = 1.42;

        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 1.42;
                if (Size == Size.Medium) _price = 1.74;
                if (Size == Size.Large) _price = 2.07;
            }
        }

        /// <summary>
        /// Gets the calories of the drink.
        /// </summary>
        private uint _calories = 117;

        /// <summary>
        /// Gets and sets the calories of the drink.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 117;
                if (Size == Size.Medium) _calories = 153;
                if (Size == Size.Large) _calories = 205;
            }
        }

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size
        { get; set; } = Size.Small;

        /// <summary>
        /// The flavor of the drink.
        /// </summary>
        public SodaFlavor Flavor
        { get; set; } = SodaFlavor.Cherry;


        /// <summary>
        /// Property is true when the ice is added.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public List<string> SpecialInstruction
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }

    }
}
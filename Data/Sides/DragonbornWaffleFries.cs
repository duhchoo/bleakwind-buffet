﻿/*
* Author: Hutch Turner
* Class name: DragonbornWaffleFries.cs
* Purpose: Class used to represent the Dragonborn Waffle Fries side.
*/
using System;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        private double _price = 0.42;

        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 0.42;
                if (Size == Size.Medium) _price = 0.76;
                if (Size == Size.Large) _price = 0.96;
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        private uint _calories = 77;

        /// <summary>
        /// Gets and sets the calories of the side.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 77;
                if (Size == Size.Medium) _calories = 89;
                if (Size == Size.Large) _calories = 100;
            }
        }

        /// <summary>
        /// The size of the side.
        /// </summary>
        public Size Size
        { get; set; } = Size.Small;

        /// <summary>
        /// Returns an empty list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of side.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dragonborn Waffle Fries";
        }

    }
}

/*
* Author: Hutch Turner
* Class name: VokunSalad.cs
* Purpose: Class used to represent the Vokun Salad side.
*/
using System;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        private double _price = 0.93;

        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 0.93;
                if (Size == Size.Medium) _price = 1.28;
                if (Size == Size.Large) _price = 1.82;
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        private uint _calories = 41;

        /// <summary>
        /// Gets and sets the calories of the side.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 41;
                if (Size == Size.Medium) _calories = 52;
                if (Size == Size.Large) _calories = 73;
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
        public List<string> SpecialInstruction
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
            return "VokunSalad";
        }

    }
}

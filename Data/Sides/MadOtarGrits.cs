/*
* Author: Hutch Turner
* Class name: MadOtarGrits.cs
* Purpose: Class used to represent the Mad Otar Grits side.
*/
using System;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        private double _price = 1.22;

        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 1.22;
                if (Size == Size.Medium) _price = 1.58;
                if (Size == Size.Large) _price = 1.93;
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        private uint _calories = 105;

        /// <summary>
        /// Gets and sets the calories of the side.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 105;
                if (Size == Size.Medium) _calories = 142;
                if (Size == Size.Large) _calories = 179;
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
            return "Mad Otar Grits";
        }

    }
}

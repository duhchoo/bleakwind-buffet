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
            get
            {
                if (Size == Size.Small) return 0.93;
                if (Size == Size.Medium) return 1.28;
                if (Size == Size.Large) return 1.82;
                throw new NotImplementedException();
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
            get
            {
                if (Size == Size.Small) return 41;
                if (Size == Size.Medium) return 52;
                if (Size == Size.Large) return 73;
                throw new NotImplementedException();
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
            return $"{Size} Vokun Salad";
        }

    }
}

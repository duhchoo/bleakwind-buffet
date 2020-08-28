/*
* Author: Hutch Turner
* Class name: FriedMiraak.cs
* Purpose: Class used to represent the Fried Miraak side.
*/
using System;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        /// <summary>
        /// Gets the price of the side.
        /// </summary>
        private double _price = 1.78;

        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public double Price
        {
            get => _price;
            private set
            {
                if (Size == Size.Small) _price = 1.78;
                if (Size == Size.Medium) _price = 2.01;
                if (Size == Size.Large) _price = 2.88;
            }
        }

        /// <summary>
        /// Gets the calories of the side.
        /// </summary>
        private uint _calories = 151;

        /// <summary>
        /// Gets and sets the calories of the side.
        /// </summary>
        public uint Calories
        {
            get => _calories;
            private set
            {
                if (Size == Size.Small) _calories = 151;
                if (Size == Size.Medium) _calories = 236;
                if (Size == Size.Large) _calories = 306;
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
            return "Fried Miraak";
        }

    }
}

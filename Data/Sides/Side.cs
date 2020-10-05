using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// The size of the side.
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the side.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value> 
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
/*
* Author: Hutch Turner
* Class name: PhillyPoacher.cs
* Purpose: Class used to represent the Philly Poacher entree.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the sandwich.
        /// </summary>
        public double Price => 7.23;

        /// <summary>
        /// Gets the calories of the sandwich.
        /// </summary>
        public uint Calories => 784;

        /// <summary>
        /// Property is true when the sirloin is added.
        /// </summary>
        public bool Sirloin { get; set; } = true;

        /// <summary>
        /// Property is true when the onion is added.
        /// </summary>
        public bool Onion { get; set; } = true;

        /// <summary>
        /// Property is true when the roll is added.
        /// </summary>
        public bool Roll { get; set; } = true;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public List<string> SpecialInstruction
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold Sirloin");
                if (!Onion) instructions.Add("Hold Onion");
                if (!Roll) instructions.Add("Hold Roll");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}

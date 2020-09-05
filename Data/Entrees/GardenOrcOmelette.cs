/*
* Author: Hutch Turner
* Class name: GardenOrcOmelette.cs
* Purpose: Class used to represent the Garden Orc Omelette entree.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the omelette.
        /// </summary>
        public double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette.
        /// </summary>
        public uint Calories => 404;

        /// <summary>
        /// Property is true when the broccoli is added.
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Property is true when the mushrooms are added.
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Property is true when the tomato is added.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Property is true when the cheddar is added.
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}

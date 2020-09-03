/*
* Author: Hutch Turner
* Class name: ThalmorTriple.cs
* Purpose: Class used to represent the Thalmor Triple entree.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public uint Calories => 943;

        /// <summary>
        /// Property is true when the bun is added.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Property is true when the ketchup is added.
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Property is true when the ketchup is added.
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Property is true when the pickles are added.
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Property is true when the cheese is added.
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Property is true when the tomato is added.
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// Property is true when the lettuce is added.
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Property is true when the mayo is added.
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Property is true when the bacon is added.
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Property is true when the egg is added.
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold Bun");
                if (!Ketchup) instructions.Add("Hold Ketchup");
                if (!Mustard) instructions.Add("Hold Mustard");
                if (!Pickle) instructions.Add("Hold Pickle");
                if (!Cheese) instructions.Add("Hold Cheese");
                if (!Tomato) instructions.Add("Hold Tomato");
                if (!Lettuce) instructions.Add("Hold Lettuce");
                if (!Mayo) instructions.Add("Hold Mayo");
                if (!Bacon) instructions.Add("Hold Bacon");
                if (!Egg) instructions.Add("Hold Egg");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

    }
}

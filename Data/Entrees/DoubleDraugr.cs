/*
* Author: Hutch Turner
* Class name: DoubleDraugr.cs
* Purpose: Class used to represent the Double Draugr entree.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories => 843;

        /// <summary>
        /// Property is true when the bun is added.
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Property is true when the ketchup is added.
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Property is true when the mustard is added.
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
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }

    }
}

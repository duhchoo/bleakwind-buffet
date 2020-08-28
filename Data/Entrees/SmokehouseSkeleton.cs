/*
* Author: Hutch Turner
* Class name: SmokehouseSkeleton.cs
* Purpose: Class used to represent the Briarheart Burger entree.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the breakfast combo.
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Gets the calories of the breakfast combo.
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// Property is true when the sausage is added.
        /// </summary>
        public bool SausageLink { get; set; } = true;

        /// <summary>
        /// Property is true when the egg is added.
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// Property is true when the hash browns are added.
        /// </summary>
        public bool HashBrowns { get; set; } = true;

        /// <summary>
        /// Property is true when the pancake is added.
        /// </summary>
        public bool Pancake { get; set; } = true;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public List<string> SpecialInstruction
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold Sausage Link");
                if (!Egg) instructions.Add("Hold Egg");
                if (!HashBrowns) instructions.Add("Hold Hash Browns");
                if (!Pancake) instructions.Add("Hold Pancake");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

    }
}

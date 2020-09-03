/*
* Author: Hutch Turner
* Class name: WarriorWater.cs
* Purpose: Class used to represent the Warrior Water.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater
    {
        /// <summary>
        /// Gets price of the drink.
        /// </summary>
        public double Price => 0.00;

        /// <summary>
        /// Gets calories of the drink.
        /// </summary>
        public uint Calories => 0;

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public Size Size
        { get; set; } = Size.Small;



        /// <summary>
        /// Property is true when the ice is added.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Property is true when the lemon is added.
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Ice) instructions.Add("Add Lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} WarriorWater";
        }

    }
}

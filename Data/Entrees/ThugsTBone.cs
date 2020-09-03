/*
* Author: Hutch Turner
* Class name: ThugsTBone.cs
* Purpose: Class used to represent the Thugs T-Bone entree.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price of the t-bone.
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Gets the calories of the t-bone.
        /// </summary>
        public uint Calories => 982;

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
        /// Overrides ToString to return name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}

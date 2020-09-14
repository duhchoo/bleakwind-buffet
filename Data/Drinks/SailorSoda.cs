/*
* Author: Hutch Turner
* Class name: SailorSoda.cs
* Purpose: Class used to represent the Sailor Soda.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem
    { 
        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.42;
                if (Size == Size.Medium) return 1.74;
                if (Size == Size.Large) return 2.07;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets and sets the calories of the drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 117;
                if (Size == Size.Medium) return 153;
                if (Size == Size.Large) return 205;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// The flavor of the drink.
        /// </summary>
        public SodaFlavor Flavor
        { get; set; } = SodaFlavor.Cherry;


        /// <summary>
        /// Property is true when the ice is added.
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }

    }
}

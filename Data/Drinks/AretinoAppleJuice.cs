/*
* Author: Hutch Turner
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to represent the Aretino Apple Juice.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price of the drink.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.62;
                if (Size == Size.Medium) return 0.87;
                if (Size == Size.Large) return 1.01;
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
                if (Size == Size.Small) return 44;
                if (Size == Size.Medium) return 88;
                if (Size == Size.Large) return 132;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Property is true when the ice is added.
        /// </summary>
        public bool Ice { get; set; } = false;

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }

    }
}

/*
* Author: Hutch Turner
* Class name: DragonbornWaffleFries.cs
* Purpose: Class used to represent the Dragonborn Waffle Fries side.
*/
using System;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.42;
                if (Size == Size.Medium) return 0.76;
                if (Size == Size.Large) return 0.96;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets and sets the calories of the side.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 77;
                if (Size == Size.Medium) return 89;
                if (Size == Size.Large) return 100;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns an empty list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of side.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }

    }
}

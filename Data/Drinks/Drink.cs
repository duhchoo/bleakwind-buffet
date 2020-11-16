using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks.
    /// </summary>
    public abstract class Drink : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the drink.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value> 
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        private string description = "";
        public virtual string Description
        {
            get
            {
                if (ToString().Contains("Sailor Soda"))
                {
                    description = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
                }

                if (ToString().Contains("Markarth Milk"))
                {
                    description = "Hormone-free organic 2% milk.";
                }

                if (ToString().Contains("Aretino Apple Juice"))
                {
                    description = "Fresh squeezed apple juice.";
                }

                if (ToString().Contains("Candlehearth Coffee"))
                {
                    description = "Fair trade, fresh ground dark roast coffee.";
                }

                if (ToString().Contains("Warrior Water"))
                {
                    description = "It’s water. Just water.";
                }

                return description;
            }
        }
    }
}

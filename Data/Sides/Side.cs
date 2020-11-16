using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using System.Security.Cryptography;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides.
    /// </summary>
    public abstract class Side : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the side.
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the side.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value> 
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        private string description = "";

        public virtual string Description
        {
            get
            {
                if (ToString().Contains("Dragonborn Waffle Fries"))
                {
                    description = "Crispy fried potato waffle fries.";
                }

                if (ToString().Contains("Fried Miraak"))
                {
                    description = "Perfectly prepared hash brown pancakes.";
                }

                if (ToString().Contains("Mad Otar Grits"))
                {
                    description = "Cheesey Grits.";
                }

                if (ToString().Contains("Vokun Salad"))
                {
                    description = "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
                }

                return description;
            }
        }
    }
}
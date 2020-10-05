/*
* Author: Hutch Turner
* Class name: PhillyPoacher.cs
* Purpose: Class used to represent the Philly Poacher entree.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for changes in the properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the sandwich.
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Gets the calories of the sandwich.
        /// </summary>
        public override uint Calories => 784;

        bool sirloin = true;

        /// <summary>
        /// Property is true when the sirloin is added.
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                if (sirloin != value)
                {
                    sirloin = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                }
            }
        }

        bool onion = true;

        /// <summary>
        /// Property is true when the onion is added.
        /// </summary>
        public bool Onion
        {
            get => onion;
            set
            {
                if (onion != value)
                {
                    onion = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                }
            }
        }

        bool roll = true;

        /// <summary>
        /// Property is true when the roll is added.
        /// </summary>
        public bool Roll
        {
            get => roll;
            set
            {
                if (roll != value)
                {
                    roll = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                }
            }
        }

        /// <summary>
        /// Returns a list of instructions to add or remove toppings.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                if (instructions.Count > 0) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}

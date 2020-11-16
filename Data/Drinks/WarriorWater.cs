/*
* Author: Hutch Turner
* Class name: WarriorWater.cs
* Purpose: Class used to represent the Warrior Water.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for changes in the properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets price of the drink.
        /// </summary>
        public override double Price => 0.00;

        /// <summary>
        /// Gets calories of the drink.
        /// </summary>
        public override uint Calories => 0;

        bool ice = true;

        /// <summary>
        /// Ice in the drink
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                if (ice != value)
                {
                    ice = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        bool lemon = false;

        /// <summary>
        /// Property is true when the lemon is added.
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set
            {
                if (lemon != value)
                {
                    lemon = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                if (instructions.Count > 0) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }

        Size size = Size.Small;

        /// <summary>
        /// The size of the drink.
        /// </summary>
        public override Size Size
        {
            get => size;
            set
            {
                if (size != value)
                {
                    size = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
            }
        }
        public string Name
        {
            get => this.ToString();
        }

    }
}

/*
* Author: Hutch Turner
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to represent the Aretino Apple Juice.
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for changes in the properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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

        bool ice = false;

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

/*
* Author: Hutch Turner
* Class name: DoubleDraugr.cs
* Purpose: Class used to represent the Double Draugr entree.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for changes in the properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories => 843;

        bool bun = true;

        /// <summary>
        /// Property is true when the bun is added.
        /// </summary>
        public bool Bun
        {
            get => bun;
            set
            {
                if (bun != value)
                {
                    bun = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        bool ketchup = true;

        /// <summary>
        /// Property is true when the ketchup is added.
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                if (ketchup != value)
                {
                    ketchup = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        bool mustard = true;

        /// <summary>
        /// Property is true when the mustard is added.
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set
            {
                if (mustard != value)
                {
                    mustard = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        bool pickle = true;

        /// <summary>
        /// Property is true when the pickles are added.
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set
            {
                if (pickle != value)
                {
                    pickle = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        bool cheese = true;

        /// <summary>
        /// Property is true when the cheese is added.
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set
            {
                if (cheese != value)
                {
                    cheese = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        bool tomato = true;

        /// <summary>
        /// Property is true when the tomato is added.
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                if (tomato != value)
                {
                    tomato = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        bool lettuce = true;

        /// <summary>
        /// Property is true when the lettuce is added.
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                if (lettuce != value)
                {
                    lettuce = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        bool mayo = true;

        /// <summary>
        /// Property is true when the mayo is added.
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set
            {
                if (mayo != value)
                {
                    mayo = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
        public string Name
        {
            get => this.ToString();
        }

    }
}

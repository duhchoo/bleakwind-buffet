/*
* Author: Hutch Turner
* Class name: GardenOrcOmelette.cs
* Purpose: Class used to represent the Garden Orc Omelette entree.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for changes in the properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the omelette.
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Gets the calories of the omelette.
        /// </summary>
        public override uint Calories => 404;

        bool broccoli = true;

        /// <summary>
        /// Property is true when the broccoli is added.
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set
            {
                if (broccoli != value)
                {
                    broccoli = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        bool mushrooms = true;

        /// <summary>
        /// Property is true when the mushrooms are added.
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set
            {
                if (mushrooms != value)
                {
                    mushrooms = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
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

        bool cheddar = true;

        /// <summary>
        /// Property is true when the cheddar is added.
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set
            {
                if (cheddar != value)
                {
                    cheddar = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
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
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}

/*
* Author: Hutch Turner
* Class name: SmokehouseSkeleton.cs
* Purpose: Class used to represent the Briarheart Burger entree.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for changes in the properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the breakfast combo.
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Gets the calories of the breakfast combo.
        /// </summary>
        public override uint Calories => 602;

        bool sausageLink = true;

        /// <summary>
        /// Property is true when the sausage is added.
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                if (sausageLink != value)
                {
                    sausageLink = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                }
            }
        }

        bool egg = true;

        /// <summary>
        /// Property is true when the egg is added.
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                if (egg != value)
                {
                    egg = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                }
            }
        }

        bool hashBrowns = true;

        /// <summary>
        /// Property is true when the hash browns are added.
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                if (hashBrowns != value)
                {
                    hashBrowns = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                }
            }
        }

        bool pancake = true;

        /// <summary>
        /// Property is true when the pancake is added.
        /// </summary>
        public bool Pancake
        {
            get => pancake;
            set
            {
                if (pancake != value)
                {
                    pancake = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
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
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
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
            return "Smokehouse Skeleton";
        }

    }
}

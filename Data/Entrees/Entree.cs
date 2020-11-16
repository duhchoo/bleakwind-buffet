using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing the common properties of entrees.
    /// </summary>
    public abstract class Entree : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of the entree.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value> 
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree.
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        private string description = "";
        public virtual string Description
        {
            get
            {
                if (ToString().Contains("Briarheart Burger"))
                {
                    description = "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
                }

                if (ToString().Contains("Double Draugr"))
                {
                    description = "Double patty burger on a brioche bun. Comes with ketchup, mustard, pickle, cheese, tomato, lettuce, and mayo.";
                }

                if (ToString().Contains("Thalmor Triple"))
                {
                    description = "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty " +
                        "inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
                }

                if (ToString().Contains("Smokehouse Skeleton"))
                {
                    description = "Put some meat on those bones with a small stack of pancakes. Includes sausage links, " +
                        "eggs, and hash browns on the side. Topped with the syrup of your choice.";
                }

                if (ToString().Contains("Garden Orc Omelette"))
                {
                    description = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
                }
                if (ToString().Contains("Philly Poacher"))
                {
                    description = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
                }
                if (ToString().Contains("Thugs T-Bone"))
                {
                    description = "Juicy T-Bone, not much else to say.";
                }

                return description;
            }
        }
    }
}

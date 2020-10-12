/*
* Author: Hutch Turner
* Class name: ComboMeal.cs
* Purpose: Class used to represent a Combo Meal.
*/
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Represents the combo meal object.
    /// </summary>
    public class ComboMeal : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The entree for the combo.
        /// </summary>
        public Entree entree;
        public Entree Entree
        {
            get => entree;
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The drink for the combo.
        /// </summary>
        public Drink drink;
        public Drink Drink
        {
            get => drink;
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The side for the combo.
        /// </summary>
        public Side side;
        public Side Side
        {
            get => side;
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The price property
        /// </summary>
        public double Price
        {
            get
            {
                double price = 0;
                if (Entree != null)
                {
                    price += Entree.Price;
                }
                if (Drink != null)
                {
                    price += Drink.Price;
                }
                if (Side != null)
                {
                    price += Side.Price;
                }
                return price -1;
            }
        }

        /// <summary>
        /// The calories property
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                if (Entree != null)
                {
                    calories += Entree.Calories;
                }
                if (Drink != null)
                {
                    calories += Drink.Calories;
                }
                if (Side != null)
                {
                    calories += Side.Calories;
                }
                return calories - 1;
            }
        }

        /// <summary>
        /// The SpecialInstructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();
                if (Entree != null)
                {
                    list.Add(Entree.ToString());
                    foreach(string item in Entree.SpecialInstructions)
                    {
                        list.Add(" - " + item);
                    }
                }
                if (Drink != null)
                {
                    list.Add(Drink.ToString());
                    foreach (string item in Drink.SpecialInstructions)
                    {
                        list.Add(" - " + item);
                    }
                }
                if (Side != null)
                {
                    list.Add(Side.ToString());
                }
                return list;
            }
        }
    }
}

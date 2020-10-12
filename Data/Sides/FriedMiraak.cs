/*
* Author: Hutch Turner
* Class name: FriedMiraak.cs
* Purpose: Class used to represent the Fried Miraak side.
*/
using System;
using BleakwindBuffet.Data.Enums;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The event handler for changes in the properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets and sets the price of the side.
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.78;
                if (Size == Size.Medium) return 2.01;
                if (Size == Size.Large) return 2.88;
                throw new NotImplementedException();
            }
        }
        
        /// <summary>
        /// Gets and sets the calories of the side.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 151;
                if (Size == Size.Medium) return 236;
                if (Size == Size.Large) return 306;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Returns an empty list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overrides ToString to return name of side.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }

        Size size = Size.Small;

        /// <summary>
        /// The size of the side.
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

    }
}

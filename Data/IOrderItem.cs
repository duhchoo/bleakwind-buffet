using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface representing the common properties of items.
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the item.
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value> 
        double Price { get; }

        /// <summary>
        /// The calories of the item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the item.
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
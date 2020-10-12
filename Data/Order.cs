using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Xml.Schema;

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem>, ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// The total amount of calories
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// The next order number
        /// </summary>
        private static int nextOrderNumber = 1;

        /// <summary>
        /// The number of the order
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// The tax rate of the order
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// The subtotal of the order
        /// </summary>
        public double Subtotal { get; }

        /// <summary>
        /// Represents the subtotal
        /// </summary>
        public double Tax => Subtotal * SalesTaxRate;

        /// <summary>
        /// Total of the price.
        /// </summary>
        public double Total => Subtotal + Tax;

        /// <summary>
        /// Order constructor
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        /// <summary>
        /// The list holding all the IOrderItems
        /// </summary>
        private Collection<IOrderItem> orderItemsList = new Collection<IOrderItem>();

        /// <summary>
        /// Adds an IOrderItem to the list of ordered items.
        /// </summary>
        /// <param name="orderItem"></param>
        public void AddTo(IOrderItem orderItem)
        {
            orderItemsList.Add(orderItem);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Removes an IOrderItem to the list of ordered items.
        /// </summary>
        /// <param name="orderItem"></param>
        public void RemoveFrom(IOrderItem orderItem)
        {
            orderItemsList.Remove(orderItem);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

    }
}

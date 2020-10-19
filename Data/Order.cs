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
    public class Order : ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// The list holding all the IOrderItems
        /// </summary>
        public Collection<IOrderItem> orderItemsList = new Collection<IOrderItem>();

        /// <summary>
        /// The total amount of calories
        /// </summary>
        public uint Calories 
        { 
            get
            {
                uint number = 0;
                foreach (IOrderItem orderitem in this)
                {
                    number += orderitem.Calories;
                }
                return number;
            }
        }

        /// <summary>
        /// The next order number
        /// </summary>
        private static int nextOrderNumber = 1;

        /// <summary>
        /// The number of the order
        /// </summary>
        public int Number { get; }

        /// <summary>
        /// The tax rate of the order
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// The subtotal of the order
        /// </summary>
        public double Subtotal 
        {
            get
            {
                double number = 0;
                foreach (IOrderItem orderitem in this)
                {
                    number += orderitem.Price;
                }
                return Convert.ToDouble(String.Format("{0:000.00}", number));
            }
        }

        /// <summary>
        /// Represents the subtotal
        /// </summary>
        public double Tax
        {
            get
            {
                double tax = Subtotal * SalesTaxRate;
                return Convert.ToDouble(String.Format("{0:000.00}", tax));
            }
        }

        /// <summary>
        /// Total of the price.
        /// </summary>
        public double Total
        {
            get
            {
                double total = Subtotal + Tax;
                return Convert.ToDouble(String.Format("{0:000.00}", total));
            }
        }


        public int Count => orderItemsList.Count;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();



        /// <summary>
        /// Order constructor
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        public IEnumerable<IOrderItem> Items => orderItemsList.ToArray();

        /// <summary>
        /// Adds an IOrderItem to the list of ordered items.
        /// </summary>
        /// <param name="orderItem"></param>
        public void Add(IOrderItem orderItem)
        {
            orderItemsList.Add(orderItem);
            orderItem.PropertyChanged += ItemChangedListener;

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, orderItem));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Removes an IOrderItem to the list of ordered items.
        /// </summary>
        /// <param name="orderItem"></param>
        public void Remove(IOrderItem orderItem)
        {
            int index = orderItemsList.IndexOf(orderItem);

            orderItemsList.Remove(orderItem);
            orderItem.PropertyChanged -= ItemChangedListener;

            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, orderItem, index));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        void ItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }

        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return orderItemsList.GetEnumerator();
        }

    }
}

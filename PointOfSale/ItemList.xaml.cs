using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ItemList.xaml
    /// </summary>
    public partial class ItemList : UserControl
    {
        /// <summary>
        /// </summary>
        public ItemList()
        {
            InitializeComponent();
        }

        

        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order && sender is Button button && button.DataContext is IOrderItem orderItem)
            {
                order.Remove(orderItem);
            }
        }
    }
}

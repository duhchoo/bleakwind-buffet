using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for MoneyCountBox.xaml
    /// </summary>
    public partial class MoneyCountBox : UserControl, INotifyPropertyChanged
    {
        /// <summary>
        /// Property and dependency handlers.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(MoneyCountBox));

        /// <summary>
        /// Constructor for the class.
        /// </summary>
        public MoneyCountBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The value of how many bills/coins the customer gave.
        /// </summary>
        public int Value
        {
            get => (int) GetValue(ValueProperty);
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
                SetValue(ValueProperty, value);
            }
        }

        /// <summary>
        /// Button that adds a bill or coin to the drawer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void add_Click(object sender, RoutedEventArgs e)
        {
            Value++;
            e.Handled = true;
        }

        /// <summary>
        /// Button that removes a bill or coin from the drawer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void subtract_Click(object sender, RoutedEventArgs e)
        {
            if (Value > 0)
            {
                Value--;
                e.Handled = true;
            }
        }


    }

    
}

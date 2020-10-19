using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for FriedMiraakCustomization.xaml
    /// </summary>
    public partial class FriedMiraakCustomization : UserControl
    {
        MenuControl buttons;
        FriedMiraak fm = new FriedMiraak();

        public FriedMiraakCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            customList.DataContext = fm;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(fm);
            }
            buttons.Swap("");
        }
    }
}
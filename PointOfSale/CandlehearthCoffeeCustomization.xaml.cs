using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
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
    /// Interaction logic for CandlehearthCoffeeCustomization.xaml
    /// </summary>
    public partial class CandlehearthCoffeeCustomization : UserControl
    {
        MenuControl buttons;
        CandlehearthCoffee chc = new CandlehearthCoffee();

        public CandlehearthCoffeeCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            chc.Ice = false;
            chc.Size = BleakwindBuffet.Data.Enums.Size.Small;
            chc.RoomForCream = false;
            chc.Decaf = false;
            customList.DataContext = chc;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            
            if (DataContext is Order order)
            {
                order.Add(chc);
            }
            buttons.Swap("");
        }
    }
}
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
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
    /// Interaction logic for SailorSodaCustomization.xaml
    /// </summary>
    public partial class SailorSodaCustomization : UserControl
    {
        MenuControl buttons;

        SailorSoda ss = new SailorSoda();

        public SailorSodaCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            ss.Ice = true;
            ss.Size = BleakwindBuffet.Data.Enums.Size.Small;
            ss.Flavor = SodaFlavor.Cherry;
            buttons.DataContext = ss;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            buttons.Swap("");
            if (DataContext is Order order)
            {
                order.Add(ss);
            }
        }
    }
}

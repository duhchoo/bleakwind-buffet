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
            customList.DataContext = ss;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            
            if (DataContext is Order order)
            {
                order.Add(ss);
            }
            buttons.Swap("");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customList.DataContext is SailorSoda ss)
            {
                if (Box.SelectedItem == Small)
                {
                    ss.Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                if (Box.SelectedItem == Medium)
                {
                    ss.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                if (Box.SelectedItem == Large)
                {
                    ss.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }

            }
        }

        private void FlavorBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customList.DataContext is SailorSoda ss)
            {
                if (FlavorBox.SelectedItem == Cherry)
                {
                    ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
                }
                if (FlavorBox.SelectedItem == Lemon)
                {
                    ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
                }
                if (FlavorBox.SelectedItem == Blackberry)
                {
                    ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
                }
                if (FlavorBox.SelectedItem == Watermelon)
                {
                    ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
                }
                if (FlavorBox.SelectedItem == Grapefruit)
                {
                    ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
                }
                if (FlavorBox.SelectedItem == Peach)
                {
                    ss.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
                }


            }
        }
    }
}

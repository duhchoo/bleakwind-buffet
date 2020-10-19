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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AretinoAppleJuiceCustomization.xaml
    /// </summary>
    public partial class AretinoAppleJuiceCustomization : UserControl
    {
        MenuControl buttons;

        AretinoAppleJuice aj = new AretinoAppleJuice();

        public AretinoAppleJuiceCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            customList.DataContext = aj;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(aj);
            }
            buttons.Swap("");
        }

        private void Size(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is AretinoAppleJuice aj)
            {
                foreach (ComboBoxItem size in e.AddedItems)
                {
                    if (size.Name == "Small") aj.Size = BleakwindBuffet.Data.Enums.Size.Small;
                    if (size.Name == "Medium") aj.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                    if (size.Name == "Large") aj.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }
            }
        }
    }
}

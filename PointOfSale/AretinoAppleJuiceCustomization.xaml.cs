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
            aj.Size = BleakwindBuffet.Data.Enums.Size.Small;
            buttons.DataContext = aj;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            buttons.Swap("");
            if (DataContext is Order order)
            {
                order.Add(aj);
            }
        }
    }
}

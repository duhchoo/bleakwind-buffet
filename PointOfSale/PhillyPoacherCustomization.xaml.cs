using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for PhillyPoacherCustomization.xaml
    /// </summary>
    public partial class PhillyPoacherCustomization : UserControl
    {
        MenuControl buttons;
        public PhillyPoacherCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            PhillyPoacher pp = new PhillyPoacher();
            buttons.DataContext = pp;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            buttons.Swap("");
        }
    }
}
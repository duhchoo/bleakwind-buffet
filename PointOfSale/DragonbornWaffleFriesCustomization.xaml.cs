using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
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
    /// Interaction logic for DragonbornWaffleFriesCustomization.xaml
    /// </summary>
    public partial class DragonbornWaffleFriesCustomization : UserControl
    {
        MenuControl buttons;
        public DragonbornWaffleFriesCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            buttons.DataContext = dbwf;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            buttons.Swap("");
        }
    }
}
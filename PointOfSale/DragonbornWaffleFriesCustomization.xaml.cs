using BleakwindBuffet.Data;
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
        DragonbornWaffleFries dbwf = new DragonbornWaffleFries();

        public DragonbornWaffleFriesCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            customList.DataContext = dbwf;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(dbwf);
            }
            buttons.Swap("");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customList.DataContext is DragonbornWaffleFries dbwf)
            {
                if (Box.SelectedItem == Small)
                {
                    dbwf.Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                if (Box.SelectedItem == Medium)
                {
                    dbwf.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                if (Box.SelectedItem == Large)
                {
                    dbwf.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }

            }
        }
    }
}
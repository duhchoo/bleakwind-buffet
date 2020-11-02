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
    /// Interaction logic for MarkarthMilkCustomization.xaml
    /// </summary>
    public partial class MarkarthMilkCustomization : UserControl
    {

        MenuControl buttons;
        MarkarthMilk mm = new MarkarthMilk();


        public MarkarthMilkCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            mm.Ice = false;
            mm.Size = BleakwindBuffet.Data.Enums.Size.Small;
            customList.DataContext = mm;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(mm);
            }
            buttons.Swap("");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customList.DataContext is MarkarthMilk mm)
            {
                if (Box.SelectedItem == Small)
                {
                    mm.Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                if (Box.SelectedItem == Medium)
                {
                    mm.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                if (Box.SelectedItem == Large)
                {
                    mm.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }

            }
        }
    }
}

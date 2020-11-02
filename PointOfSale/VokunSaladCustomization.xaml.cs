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
    /// Interaction logic for VokunSaladCustomization.xaml
    /// </summary>
    public partial class VokunSaladCustomization : UserControl
    {
        MenuControl buttons;
        VokunSalad vs = new VokunSalad();
        public VokunSaladCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            VokunSalad vs = new VokunSalad();
            customList.DataContext = vs;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(vs);
            }
            buttons.Swap("");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customList.DataContext is VokunSalad ww)
            {
                if (Box.SelectedItem == Small)
                {
                    vs.Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                if (Box.SelectedItem == Medium)
                {
                    vs.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                if (Box.SelectedItem == Large)
                {
                    vs.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }

            }
        }
    }
}
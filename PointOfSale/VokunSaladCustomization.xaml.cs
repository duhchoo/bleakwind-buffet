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
            buttons.DataContext = vs;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            buttons.Swap("");
            if (DataContext is Order order)
            {
                order.Add(vs);
            }
        }
    }
}
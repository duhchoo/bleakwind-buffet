using BleakwindBuffet.Data;
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
    /// Interaction logic for GardenOrcOmeletteCustomization.xaml
    /// </summary>
    public partial class GardenOrcOmeletteCustomization : UserControl
    {
        MenuControl buttons;
        GardenOrcOmelette goo = new GardenOrcOmelette();

        public GardenOrcOmeletteCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            customList.DataContext = goo;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(goo);
            }
            buttons.Swap("");
        }
    }
}
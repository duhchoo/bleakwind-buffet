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
    /// Interaction logic for WarriorWaterCustomization.xaml
    /// </summary>
    public partial class WarriorWaterCustomization : UserControl
    {
        MenuControl buttons;
        WarriorWater ww = new WarriorWater();

        public WarriorWaterCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            ww.Ice = true;
            ww.Lemon = false;
            ww.Size = BleakwindBuffet.Data.Enums.Size.Small;
            buttons.DataContext = ww;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            buttons.Swap("");
            if (DataContext is Order order)
            {
                order.Add(ww);
            }
        }
    }
}

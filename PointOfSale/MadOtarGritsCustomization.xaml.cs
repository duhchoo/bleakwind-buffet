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
    /// Interaction logic for MadOtarGritsCustomization.xaml
    /// </summary>
    public partial class MadOtarGritsCustomization : UserControl
    {
        MenuControl buttons;
        public MadOtarGritsCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            MadOtarGrits mog = new MadOtarGrits();
            buttons.DataContext = mog;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            buttons.Swap("");
        }
    }
}
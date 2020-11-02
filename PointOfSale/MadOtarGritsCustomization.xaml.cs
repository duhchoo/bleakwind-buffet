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
    /// Interaction logic for MadOtarGritsCustomization.xaml
    /// </summary>
    public partial class MadOtarGritsCustomization : UserControl
    {
        MenuControl buttons;
        MadOtarGrits mog = new MadOtarGrits();

        public MadOtarGritsCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            customList.DataContext = mog;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(mog);
            }
            buttons.Swap("");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (customList.DataContext is MadOtarGrits mog)
            {
                if (Box.SelectedItem == Small)
                {
                    mog.Size = BleakwindBuffet.Data.Enums.Size.Small;
                }
                if (Box.SelectedItem == Medium)
                {
                    mog.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                }
                if (Box.SelectedItem == Large)
                {
                    mog.Size = BleakwindBuffet.Data.Enums.Size.Large;
                }

            }
        }
    }
}
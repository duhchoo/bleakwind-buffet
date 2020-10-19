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
    /// Interaction logic for ThugsTBoneCustomization.xaml
    /// </summary>
    public partial class ThugsTBoneCustomization : UserControl
    {
        MenuControl buttons;
        ThugsTBone ttb = new ThugsTBone();

        public ThugsTBoneCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            customList.DataContext = ttb;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(ttb);
            }
            buttons.Swap("");
        }
    }
}
﻿using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for BriarheartBurgerCustomization.xaml
    /// </summary>
    public partial class BriarheartBurgerCustomization : UserControl
    {
        MenuControl buttons;
        public BriarheartBurgerCustomization(MenuControl butt)
        {
            InitializeComponent();
            buttons = butt;
            BriarheartBurger bhb = new BriarheartBurger();
            buttons.DataContext = bhb;
        }

        public void add_Click(Object sender, RoutedEventArgs e)
        {
            buttons.Swap("");
        }
    }
}
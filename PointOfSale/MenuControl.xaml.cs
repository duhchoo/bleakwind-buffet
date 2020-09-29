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
    /// Interaction logic for MenuControl.xaml
    /// </summary>
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
        }

        public void Click(Object sender, RoutedEventArgs e)
        {
            Button send = (Button)sender;
            string name = send.Name;
            Swap(name);
        }

        public void Swap (string sendy)
        {

            if (sendy == "briarheartButton" || sendy == "draugrButton" || sendy == "omeletteButton" || sendy == "phillyButton" ||
                sendy == "skeletonButton" || sendy == "thalmorButton" || sendy == "thugsButton")
            {
                swapBorder.Child = new IngredientControl(this, "entree", sendy);
            }

            else if (sendy == "juiceButton" || sendy == "coffeeButton" || sendy == "milkButton" || sendy == "sodaButton" ||
                sendy == "waterButton")
            {
                swapBorder.Child = new IngredientControl(this, "drink", sendy);
            }

            else if (sendy == "friesButton" || sendy == "miraakButton" || sendy == "gritsButton" || sendy == "saladButton" ||
                sendy == "skeletonButton" || sendy == "thalmorButton" || sendy == "thugsButton")
            {
                swapBorder.Child = new IngredientControl(this, "side", sendy );
            }
            else
            {
                swapBorder.Child = new MenuControl();
            }
        }
    }
}

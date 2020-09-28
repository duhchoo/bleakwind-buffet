using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Click(object sender, RoutedEventArgs e)
        {
            Button butt = (Button)sender;

            if (butt.Name == "briarheartButton" || butt.Name == "draugrButton" || butt.Name == "omeletteButton" || butt.Name == "phillyButton" ||
                butt.Name == "skeletonButton" || butt.Name == "thalmorButton" || butt.Name == "thugsButton")
            {
                ingredientBorder.Child = new IngredientControl("entree", butt.Name);
            }

            else if (butt.Name == "juiceButton" || butt.Name == "coffeeButton" || butt.Name == "milkButton" || butt.Name == "sodaButton" ||
                butt.Name == "waterButton")
            {
                ingredientBorder.Child = new IngredientControl("drink", butt.Name);
            }

            else if (butt.Name == "friesButton" || butt.Name == "miraakButton" || butt.Name == "gritsButton" || butt.Name == "saladButton" ||
                butt.Name == "skeletonButton" || butt.Name == "thalmorButton" || butt.Name == "thugsButton")
            {
                ingredientBorder.Child = new IngredientControl("side", butt.Name);
            }
            else
            {
                MessageBox.Show("Nothing");
            }
        }


    }
}

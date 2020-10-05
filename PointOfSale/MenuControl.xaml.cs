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
            switch (sendy)
            {
                //Drinks
                case "juiceButton":
                    swapBorder.Child = new AretinoAppleJuiceCustomization(this);
                    break;

                case "waterButton":
                    swapBorder.Child = new WarriorWaterCustomization(this);
                    break;

                case "coffeeButton":
                    swapBorder.Child = new CandlehearthCoffeeCustomization(this);
                    break;

                case "sodaButton":
                    swapBorder.Child = new SailorSodaCustomization(this);
                    break;

                case "milkButton":
                    swapBorder.Child = new MarkarthMilkCustomization(this);
                    break;


                //Sides
                case "friesButton":
                    swapBorder.Child = new DragonbornWaffleFriesCustomization(this);
                    break;
                case "miraakButton":
                    swapBorder.Child = new FriedMiraakCustomization(this);
                    break;
                case "saladButton":
                    swapBorder.Child = new VokunSaladCustomization(this);
                    break;
                case "gritsButton":
                    swapBorder.Child = new MadOtarGritsCustomization(this);
                    break;


                //Entrees
                case "briarheartButton":
                    swapBorder.Child = new BriarheartBurgerCustomization(this);
                    break;
                case "draugrButton":
                    swapBorder.Child = new DoubleDraugrCustomization(this);
                    break;
                case "omeletteButton":
                    swapBorder.Child = new GardenOrcOmeletteCustomization(this);
                    break;
                case "phillyButton":
                    swapBorder.Child = new PhillyPoacherCustomization(this);
                    break;
                case "skeletonButton":
                    swapBorder.Child = new SmokehouseSkeletonCustomization(this);
                    break;
                case "thalmorButton":
                    swapBorder.Child = new ThalmorTripleCustomization(this);
                    break;
                case "thugsButton":
                    swapBorder.Child = new ThugsTBoneCustomization(this);
                    break;

                //End Case
                case "":
                    swapBorder.Child = new MenuControl();
                    break;
            }
        }
    }
}



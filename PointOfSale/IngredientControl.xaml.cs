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
    /// Interaction logic for IngredientControl.xaml
    /// </summary>
    public partial class IngredientControl : UserControl
    {

        MenuControl buttons;

        /// <summary>
        /// Finds which type of food it is.
        /// </summary>
        /// <param name="type"> The type of food. </param>
        /// <param name="food"> The name of the food. </param>
        public IngredientControl(MenuControl butt, string type, string food)
        {
            InitializeComponent();
            this.buttons = butt;

            string foodType = type;
            string foodItem = food;

            if (foodType.Equals("entree"))
            {
                FindEntree(foodItem);
            }
            else if (foodType.Equals("drink"))
            {
                FindDrink(foodItem);
            }
            else
            {
                FindSide(foodItem);
            }
        }

        /// <summary>
        /// Finds the correct entree and adds the following checkboxes for that entree.
        /// </summary>
        /// <param name="entree"> The entree. </param>
        public void FindEntree(string entree)
        {
            

            switch (entree)
            {
                case "briarheartButton":
                    CheckBox bhb0 = new CheckBox();
                    CheckBox bhb1 = new CheckBox();
                    CheckBox bhb2 = new CheckBox();
                    CheckBox bhb3 = new CheckBox();
                    CheckBox bhb4 = new CheckBox();

                    bhb0.Content = "Bun";
                    checkboxList.Items.Add(bhb0);

                    bhb1.Content = "Ketchup";
                    checkboxList.Items.Add(bhb1);

                    bhb2.Content = "Mustard";
                    checkboxList.Items.Add(bhb2);

                    bhb3.Content = "Pickle";
                    checkboxList.Items.Add(bhb3);

                    bhb4.Content = "Cheese";
                    checkboxList.Items.Add(bhb4);
                    break;

                case "draugrButton":
                    CheckBox dd0 = new CheckBox();
                    CheckBox dd1 = new CheckBox();
                    CheckBox dd2 = new CheckBox();
                    CheckBox dd3 = new CheckBox();
                    CheckBox dd4 = new CheckBox();
                    CheckBox dd5 = new CheckBox();
                    CheckBox dd6 = new CheckBox();
                    CheckBox dd7 = new CheckBox();

                    dd0.Content = "Bun";
                    checkboxList.Items.Add(dd0);

                    dd1.Content = "Ketchup";
                    checkboxList.Items.Add(dd1);

                    dd2.Content = "Mustard";
                    checkboxList.Items.Add(dd2);

                    dd3.Content = "Pickle";
                    checkboxList.Items.Add(dd3);

                    dd4.Content = "Cheese";
                    checkboxList.Items.Add(dd4);

                    dd5.Content = "Tomato";
                    checkboxList.Items.Add(dd5);

                    dd6.Content = "Lettuce";
                    checkboxList.Items.Add(dd6);

                    dd7.Content = "Mayo";
                    checkboxList.Items.Add(dd7);
                    break;

                case "omeletteButton":
                    CheckBox goo0 = new CheckBox();
                    CheckBox goo1 = new CheckBox();
                    CheckBox goo2 = new CheckBox();
                    CheckBox goo3 = new CheckBox();

                    goo0.Content = "Broccoli";
                    checkboxList.Items.Add(goo0);

                    goo1.Content = "Mushrooms";
                    checkboxList.Items.Add(goo1);

                    goo2.Content = "Tomato";
                    checkboxList.Items.Add(goo2);

                    goo3.Content = "Cheddar";
                    checkboxList.Items.Add(goo3);
                    break;

                case "phillyButton":
                    CheckBox pp0 = new CheckBox();
                    CheckBox pp1 = new CheckBox();
                    CheckBox pp2 = new CheckBox();

                    pp0.Content = "Sirloin";
                    checkboxList.Items.Add(pp0);

                    pp1.Content = "Onions";
                    checkboxList.Items.Add(pp1);

                    pp2.Content = "Roll";
                    checkboxList.Items.Add(pp2);
                    break;

                case "skeletonButton":
                    CheckBox ss0 = new CheckBox();
                    CheckBox ss1 = new CheckBox();
                    CheckBox ss2 = new CheckBox();
                    CheckBox ss3 = new CheckBox();

                    ss0.Content = "Sausage Link";
                    checkboxList.Items.Add(ss0);

                    ss1.Content = "Egg";
                    checkboxList.Items.Add(ss1);

                    ss2.Content = "Hashbrowns";
                    checkboxList.Items.Add(ss2);

                    ss3.Content = "Pancake";
                    checkboxList.Items.Add(ss3);
                    break;

                case "thalmorButton":
                    CheckBox tt0 = new CheckBox();
                    CheckBox tt1 = new CheckBox();
                    CheckBox tt2 = new CheckBox();
                    CheckBox tt3 = new CheckBox();
                    CheckBox tt4 = new CheckBox();
                    CheckBox tt5 = new CheckBox();
                    CheckBox tt6 = new CheckBox();
                    CheckBox tt7 = new CheckBox();
                    CheckBox tt8 = new CheckBox();
                    CheckBox tt9 = new CheckBox();

                    tt0.Content = "Bun";
                    checkboxList.Items.Add(tt0);

                    tt1.Content = "Ketchup";
                    checkboxList.Items.Add(tt1);

                    tt2.Content = "Mustard";
                    checkboxList.Items.Add(tt2);

                    tt3.Content = "Pickle";
                    checkboxList.Items.Add(tt3);

                    tt4.Content = "Cheese";
                    checkboxList.Items.Add(tt4);

                    tt5.Content = "Tomato";
                    checkboxList.Items.Add(tt5);

                    tt6.Content = "Lettuce";
                    checkboxList.Items.Add(tt6);

                    tt7.Content = "Mayo";
                    checkboxList.Items.Add(tt7);

                    tt8.Content = "Bacon";
                    checkboxList.Items.Add(tt8);

                    tt9.Content = "Egg";
                    checkboxList.Items.Add(tt9);
                    break;

                case "thugsButton":
                    break;
            }
            


        }

        /// <summary>
        /// Finds the correct drink and adds the following checkboxes and radio buttons for that drink.
        /// </summary>
        /// <param name="drink"> The drink. </param>
        public void FindDrink(string drink)
        {
            checkboxList.Items.Add("Choose a Size:");
            RadioButton rad0 = new RadioButton();
            rad0.Content = "Small";
            checkboxList.Items.Add(rad0);

            RadioButton rad1 = new RadioButton();
            rad1.Content = "Medium";
            checkboxList.Items.Add(rad1);

            RadioButton rad2 = new RadioButton();
            rad2.Content = "Large";
            checkboxList.Items.Add(rad2);

            checkboxList.Items.Add("");

            CheckBox ice = new CheckBox();
            ice.Content = "Ice";
            checkboxList.Items.Add(ice);


            switch (drink)
            {
                case "juiceButton":
                    break;

                case "coffeeButton":

                    CheckBox chc00 = new CheckBox();
                    chc00.Content = "Cream";
                    checkboxList.Items.Add(chc00);

                    CheckBox chc000 = new CheckBox();
                    chc000.Content = "Decaf";
                    checkboxList.Items.Add(chc000);
                    break;

                case "milkButton":
                    break;

                case "sodaButton":
                    checkboxList.Items.Add("");
                    checkboxList.Items.Add("Choose a Flavor:");

                    RadioButton rad = new RadioButton();
                    rad.GroupName = "flavor";
                    rad.Content = "Cherry";
                    checkboxList.Items.Add(rad);

                    rad = new RadioButton();
                    rad.GroupName = "flavor";
                    rad.Content = "Blackberry";
                    checkboxList.Items.Add(rad);

                    rad = new RadioButton();
                    rad.GroupName = "flavor";
                    rad.Content = "Grapefruit";
                    checkboxList.Items.Add(rad);

                    rad = new RadioButton();
                    rad.GroupName = "flavor";
                    rad.Content = "Lemon";
                    checkboxList.Items.Add(rad);

                    rad = new RadioButton();
                    rad.GroupName = "flavor";
                    rad.Content = "Peach";
                    checkboxList.Items.Add(rad);

                    rad = new RadioButton();
                    rad.GroupName = "flavor";
                    rad.Content = "Watermelon";
                    checkboxList.Items.Add(rad);
                    break;

                case "waterButton":
                    CheckBox ww = new CheckBox();
                    ww.Content = "Lemon";
                    checkboxList.Items.Add(ww);
                    break;
            }
        }

        /// <summary>
        /// Finds the correct side and adds the following radio buttons for that side.
        /// </summary>
        /// <param name="side"> The side. </param>
        public void FindSide(string side)
        {
            checkboxList.Items.Add("Choose a Size:");
            RadioButton rad0 = new RadioButton();
            rad0.Content = "Small";
            checkboxList.Items.Add(rad0);

            RadioButton rad1 = new RadioButton();
            rad1.Content = "Medium";
            checkboxList.Items.Add(rad1);

            RadioButton rad2 = new RadioButton();
            rad2.Content = "Large";
            checkboxList.Items.Add(rad2);
        }

        /// <summary>
        /// Click event handler for exiting the ingredient control. I know I definitely did this wrong, but it's the closest I was able to do.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, RoutedEventArgs e)
        {
            buttons.Swap("");
            
        }
    }
}

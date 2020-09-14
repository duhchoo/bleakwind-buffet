using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Xml.Serialization;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Builds full menus for the entrees, sides, drinks, and the entire list of available items.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Returns full menu of entrees.
        /// </summary>
        /// <returns>Full menu of entrees.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeMenu = new List<IOrderItem>();
            entreeMenu.Add(new BriarheartBurger());
            entreeMenu.Add(new DoubleDraugr());
            entreeMenu.Add(new GardenOrcOmelette());
            entreeMenu.Add(new PhillyPoacher());
            entreeMenu.Add(new SmokehouseSkeleton());
            entreeMenu.Add(new ThalmorTriple());
            entreeMenu.Add(new ThugsTBone());

            return entreeMenu;
        }

        /// <summary>
        /// Returns full menu of sides.
        /// </summary>
        /// <returns>Full menu of sides.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideMenu = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sideMenu.Add(new DragonbornWaffleFries()
                {
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sideMenu.Add(new FriedMiraak()
                {
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sideMenu.Add(new MadOtarGrits()
                {
                    Size = size
                });
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                sideMenu.Add(new VokunSalad()
                {
                    Size = size
                });
            }

            return sideMenu;
        }

        /// <summary>
        /// Returns the full menu of drinks
        /// </summary>
        /// <returns>Full menu of drinks.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkMenu = new List<IOrderItem>();

            //Aretino Apple Juice
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinkMenu.Add(new AretinoAppleJuice()
                {
                    Size = size
                });
            }


            //Candlehearth Coffee
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinkMenu.Add(new CandlehearthCoffee()
                {
                    Decaf = false,
                    Size = size
                }) ;

                drinkMenu.Add(new CandlehearthCoffee()
                {
                    Decaf = true,
                    Size = size
                });
            }


            //Markarth Milk
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinkMenu.Add(new MarkarthMilk()
                {
                    Size = size
                });
            }


            //Sailor Soda
            SailorSoda ss = new SailorSoda();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinkMenu.Add(new SailorSoda()
                {
                    Flavor = SodaFlavor.Blackberry,
                    Size = size
                });

                drinkMenu.Add(new SailorSoda()
                {
                    Flavor = SodaFlavor.Cherry,
                    Size = size
                });

                drinkMenu.Add(new SailorSoda()
                {
                    Flavor = SodaFlavor.Grapefruit,
                    Size = size
                });

                drinkMenu.Add(new SailorSoda()
                {
                    Flavor = SodaFlavor.Lemon,
                    Size = size
                });

                drinkMenu.Add(new SailorSoda()
                {
                    Flavor = SodaFlavor.Peach,
                    Size = size
                });

                drinkMenu.Add(new SailorSoda()
                {
                    Flavor = SodaFlavor.Watermelon,
                    Size = size
                });
            }

            //Warrior Water
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinkMenu.Add(new WarriorWater()
                {
                    Size = size
                });
            }

            return drinkMenu;
        }

        /// <summary>
        /// Returns the full menu of items.
        /// </summary>
        /// <returns>Full menu of items.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = (List<IOrderItem>) Entrees();
            List<IOrderItem> drinks = (List<IOrderItem>) Drinks();
            List<IOrderItem> sides = (List<IOrderItem>) Sides();

            menu.AddRange(drinks);
            menu.AddRange(sides);

            return menu;
        }


    }
}

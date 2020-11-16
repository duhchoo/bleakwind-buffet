/* Author: Hutch Turner
 * Menu.cs
 * Purpose: Collects certain items from different data to create lists for searching on the website.
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Xml.Serialization;
using System.Linq;

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

        /// <summary>
        /// Filters the data by categories selected.
        /// </summary>
        /// <param name="OrderItems"> All the items being filtered. </param>
        /// <param name="categories"> The filters </param>
        /// <returns> A filtered OrderItems </returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> OrderItems, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0)
            {
                return OrderItems;
            }

            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in OrderItems)
            {
                if (categories.Contains("Entree") && item is Entree)
                {
                    results.Add(item);
                }
                if (categories.Contains("Side") && item is Side)
                {
                    results.Add(item);
                }
                if (categories.Contains("Drink") && item is Drink)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Searched through all food items.
        /// </summary>
        /// <param name="OrderItems"> All the items being filtered. </param>
        /// <param name="SearchTerms"> The term being looked-up</param>
        /// <returns> the food items with matching data. </returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> OrderItems, string SearchTerms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (SearchTerms == null)
            {
                return OrderItems;
            }

            foreach (IOrderItem item in OrderItems)
            {
                string upperName = item.ToString().ToUpper();
                string upperDescription = item.Description.ToUpper();

                //string search = SearchTerms.ToUpper();

                if (item.ToString().Contains(SearchTerms) /*|| upperDescription.Contains(search)*/)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the items by a price range.
        /// </summary>
        /// <param name="OrderItems"> the items being filtered. </param>
        /// <param name="min"> the min filter </param>
        /// <param name="max"> the max filter </param>
        /// <returns> all items inside that range.</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> OrderItems, double? min, double? max)
        {
            if (min == 0 && max == 0) return OrderItems;

            var results = new List<IOrderItem>();

            if (min == 0)
            {
                foreach (IOrderItem item in OrderItems)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if (max == 0)
            {
                foreach (IOrderItem item in OrderItems)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in OrderItems)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the items by a calorie range.
        /// </summary>
        /// <param name="OrderItems"> the items being filtered. </param>
        /// <param name="min"> the min filter </param>
        /// <param name="max"> the max filter </param>
        /// <returns> all items inside that range.</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> OrderItems, double? min, double? max)
        {
            if (min == 0 && max == 0) return OrderItems;

            var results = new List<IOrderItem>();
            if (min == 0)
            {
                foreach (IOrderItem item in OrderItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if (max == 0)
            {
                foreach (IOrderItem item in OrderItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in OrderItems)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

    }
}

/* Author: Hutch Turner
 * Index.cshtml.cs
 * Purpose: Holds all the searching and filtering data.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Holds all the items to be shown.
        /// </summary>
        public IEnumerable<IOrderItem> OrderItems { get; set; }

        /// <summary>
        /// Holds all the entrees to be shown.
        /// </summary>
        public IEnumerable<IOrderItem> _Entrees { get; set; }

        /// <summary>
        /// Holds all the sides to be shown.
        /// </summary>
        public IEnumerable<IOrderItem> _Sides { get; set; }

        /// <summary>
        /// Holds all the drinks to be shown.
        /// </summary>
        public IEnumerable<IOrderItem> _Drinks { get; set; }

        /// <summary>
        /// The string stored in the Search Bar
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The categories selected to filter.
        /// </summary>
        public string[] Categories { get; set; }

        /// <summary>
        /// The The minimum range for filtering price
        /// </summary>
        [BindProperty]
        public double PriceMin { get; set; }

        /// <summary>
        /// The max range for filtering price
        /// </summary>
        [BindProperty]
        public double PriceMax { get; set; }

        /// <summary>
        /// The minimum range for filtering calories
        /// </summary>
        [BindProperty]
        public double CaloriesMin { get; set; }

        /// <summary>
        /// The max range for filtering calories
        /// </summary>
        [BindProperty]
        public double CaloriesMax { get; set; }

        /// <summary>
        /// Creates the entire filtering system and checks everytime the web page is updated, I think
        /// </summary>
        /// <param name="PriceMin"></param>
        /// <param name="PriceMax"></param>
        /// <param name="CaloriesMin"></param>
        /// <param name="CaloriesMax"></param>
        public void OnGet(double PriceMin, double PriceMax, double CaloriesMin, double CaloriesMax)
        {
            SearchTerms = Request.Query["SearchItems"];
            Categories = Request.Query["Categories"];

            OrderItems = Menu.FullMenu();

            if (SearchTerms != null)
            {
                OrderItems = OrderItems.Where(item => item != null
                && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                || item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            
            if (Categories != null && Categories.Length > 0)
            {
                var results = new List<IOrderItem>();

                if (Categories.Contains("Entrees"))
                {
                    foreach (IOrderItem item in OrderItems.Where(item => item != null && item is Entree))
                    {
                        results.Add(item);
                    }
                }
                if (Categories.Contains("Sides"))
                {
                    foreach (IOrderItem item in OrderItems.Where(item => item != null && item is Side))
                    {
                        results.Add(item);
                    }
                }
                if (Categories.Contains("Drinks"))
                {
                    foreach (IOrderItem item in OrderItems.Where(item => item != null && item is Drink))
                    {
                        results.Add(item);
                    }
                }
                OrderItems = results;
            }
            OrderItems = Menu.FilterByPrice(OrderItems, PriceMin, PriceMax);
            OrderItems = Menu.FilterByCalories(OrderItems, CaloriesMin, CaloriesMax);

            List<IOrderItem> entrees = new List<IOrderItem>();
            List<IOrderItem> sides = new List<IOrderItem>();
            List<IOrderItem> drinks = new List<IOrderItem>();

            foreach (IOrderItem item in OrderItems)
            {
                if (item is Entree)
                {
                    entrees.Add(item);
                }

                if (item is Side)
                {
                    sides.Add(item);
                }

                if (item is Drink)
                {
                    drinks.Add(item);
                }
            }
            _Entrees = entrees;
            _Sides = sides;
            _Drinks = drinks;

        }
    }
}

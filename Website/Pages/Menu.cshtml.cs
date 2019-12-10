using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using System.Linq;

namespace Website.Pages
{
    /// <summary>
    /// the model for the html to pull from 
    /// </summary>
    public class MenuModel : PageModel
    {
        /// <summary>
        /// all menu items
        /// </summary>
        public IEnumerable<IMenuItem> menuItems;
        /// <summary>
        /// all combos privatly used 
        /// </summary>
        private List<CretaceousCombo> combos= new List<CretaceousCombo>();
        /// <summary>
        /// all possible ingradients
        /// </summary>
        public List<string> possibleIngreadients = new List<string>();
        /// <summary>
        /// the bind for the search
        /// </summary>
        [BindProperty]
        public string search { get; set; }
        /// <summary>
        /// the bind for the excluded ingreadients
        /// </summary>
        [BindProperty]
        public List<string> excludedIngreadients { get; set; } = new List<string>();
        /// <summary>
        /// the bind for the excluded catagories
        /// </summary>
        [BindProperty]
        public List<string> excludedCatagory { get; set; } = new List<string>();
        /// <summary>
        /// bind for the minimun price
        /// </summary>
        [BindProperty]
        public float? minPrice { get; set; }
        /// <summary>
        /// bind for the maximum price
        /// </summary>
        [BindProperty]
        public float? maxPrice { get; set; }
        /// <summary>
        /// for when loading the original page
        /// </summary>
        public void OnGet()
        {
            menuItems = AllMenuItems();
        }
        /// <summary>
        /// for when you press search to find somthing
        /// </summary>
        public void OnPost()
        {
            menuItems = AllMenuItems();
            if (excludedCatagory.Contains("Entrees"))
            {
                menuItems = menuItems.Where(item => item is CretaceousCombo|| item is Side || item is Drink);
            }
            if (excludedCatagory.Contains("Combo"))
            {
                menuItems = menuItems.Where(item => item is Entree|| item is Side || item is Drink);
            }
            if (excludedCatagory.Contains("Sides"))
            {
                menuItems = menuItems.Where(item => item is Entree || item is CretaceousCombo || item is Drink);
            }
            if (excludedCatagory.Contains("Drinks"))
            {
                menuItems = menuItems.Where(item => item is Entree || item is Side || item is CretaceousCombo);
            }
            if (search != null)
            {
                menuItems = menuItems.Where(item => item.ToString().Contains(search, StringComparison.InvariantCultureIgnoreCase));
            }

            if (minPrice != null)
            {
                menuItems = menuItems.Where(item => item.Price != null && item.Price >= minPrice);
            }

            if (maxPrice != null)
            {
                menuItems = menuItems.Where(item => item.Price != null && item.Price <= maxPrice);
            }

            if (excludedIngreadients.Count > 0)
            {
                foreach (string s in excludedIngreadients)
                {
                    menuItems = menuItems.Where(item => !item.Ingredients.Contains(s));
                }
            }

        }
        /// <summary>
        /// poulates menuitems and possible ingreadients 
        /// </summary>
        /// <returns></returns> a list of all menu items
        private List<IMenuItem> AllMenuItems()
        {
            List<IMenuItem> items = new List<IMenuItem>();
            items.Add(new Brontowurst());
            items.Add(new DinoNuggets());
            items.Add(new PrehistoricPBJ());
            items.Add(new PterodactylWings());
            items.Add(new SteakosaurusBurger());
            items.Add(new TRexKingBurger());
            items.Add(new VelociWrap());

            items.Add(new Triceritots());
            items.Add(new MeteorMacAndCheese());
            items.Add(new Fryceritops());
            items.Add(new MezzorellaSticks());
            items.Add(new JurassicJava());
            items.Add(new Sodasaurus());
            items.Add(new Tyrannotea());
            items.Add(new Water());

            foreach (IMenuItem item in items)
            {
                if (item is Entree e)
                {
                    combos.Add(new CretaceousCombo(e));
                }
            }
            items.AddRange(combos);
            foreach (IMenuItem menuItem in items)
            {
                foreach (String s in menuItem.Ingredients)
                {
                    if (!possibleIngreadients.Contains(s))
                    {
                        possibleIngreadients.Add(s);
                    }
                }
            }

            return items;
        }


    }
}
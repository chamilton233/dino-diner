using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// menu item pretty much chicken wings
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// constuctor sets basic info for the item
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
            ingreadients.Add("Chicken");
            ingreadients.Add("Wing Sauce");
        }
    }
}
//Implement a class to represent the Pterodactyl Wings entree.
//Its price is **$7.21**, it contains **318 calories**, and its 
//ingredients are:  **Chicken** and **Wing Sauce**.

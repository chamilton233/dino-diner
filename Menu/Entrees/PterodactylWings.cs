using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// menu item pretty much chicken wings
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// the price of it
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// the number of calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// gets the correct ingreadents
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };

                return ingredients;
            }
        }
        /// <summary>
        /// constuctor sets basic info for the item
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
//Implement a class to represent the Pterodactyl Wings entree.
//Its price is **$7.21**, it contains **318 calories**, and its 
//ingredients are:  **Chicken** and **Wing Sauce**.

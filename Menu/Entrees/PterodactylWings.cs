using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// menu item pretty much chicken wings inherits from entree
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
            
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
        /// <summary>
        /// gets the correct list of ingreadents
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingreadients = new List<string>();
                ingreadients.Add("Chicken");
                ingreadients.Add("Wing Sauce");
                return ingreadients;
            }
        }
        /// <summary>
        /// the description of this item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// describes all differnt than normal things the item has
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
//Implement a class to represent the Pterodactyl Wings entree.
//Its price is **$7.21**, it contains **318 calories**, and its 
//ingredients are:  **Chicken** and **Wing Sauce**.

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };

                return ingredients;
            }
        }

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

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// if you want to drink water 
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// backing for the lemon 
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// the consturtor gives default info
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingreadients.Add("Water");
        }
        /// <summary>
        /// returns the correct ingreadednts
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Lemon) ingreadients.Add("Lemon");
                return ingreadients;
            }
        }
        /// <summary>
        /// adds lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}

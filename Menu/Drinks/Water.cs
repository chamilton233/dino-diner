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
        /// backing for size
        /// </summary>
        private Size size;

        public override Size Size
        {
            set
            {
                size = value;
            }
            get
            {
                return size;
            }
        }
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
            
        }
        /// <summary>
        /// returns the correct ingreadednts
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingreadients = new List<string>();
                ingreadients.Add("Water");
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
        public override string ToString()
        {
            return $"{size} Water";
        }
    }
}

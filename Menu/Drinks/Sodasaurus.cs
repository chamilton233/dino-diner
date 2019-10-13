using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// soda has many flavors
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// backing for size
        /// </summary>
        private Size size;
        /// <summary>
        /// backing for flavor
        /// </summary>
        private SodasaurusFlavor flavor;
        /// <summary>
        /// functionality of flavor
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set { flavor = value; }
        }
        /// <summary>
        /// how setting size works
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// constuctor for the soda
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
        }
        /// <summary>
        /// gets the correct list of ingreadents
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingreadients = new List<string>();
                ingreadients.Add("Water");
                ingreadients.Add("Natural Flavors");
                ingreadients.Add("Cane Sugar");
                return ingreadients;
            }
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
            return $"{size} {flavor} Sodasaurus";
        }
    }
}

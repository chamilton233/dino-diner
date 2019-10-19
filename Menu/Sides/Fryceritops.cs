using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// a side item that is french fries inherits from side
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// the size of the side is a Enum of Size
        /// </summary>
        private Size size;
        /// <summary>
        /// geters and seters for size 
        /// </summary>
        public override Size Size{
            set{
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
                NotifyParentPropertyChanged("Description");
                NotifyParentPropertyChanged("Calories");
                NotifyParentPropertyChanged("Price");
            }
            get {
                return size;
            }
        }
        /// <summary>
        /// constucts basic info for the item
        /// </summary>
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
        }
        /// <summary>
        /// gets the correct list of ingreadents
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingreadients = new List<string>();
                ingreadients.Add("Potato");
                ingreadients.Add("Salt");
                ingreadients.Add("Vegetable Oil");
                return ingreadients;
            }
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
           return $"{size} Fryceritops";            
        }

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

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
//Implement a class to represent the Fryceritops Side that inherits from the Side base class.  It’s price is **$0.99 (small)**, **$1.45 (medium)**, or **$1.95 (large)**.  Its calories are **222 (small)**, **365 (medium)**, and **480 (large)**.  Its ingredients are **potatoes, salt, **and **vegtable oil**.

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// a side item that is moterella sticks inherits from side
    /// </summary>
    public class MezzorellaSticks : Side  
    {
        /// <summary>
        /// the size of the side is a Enum of Size
        /// </summary>
        private Size size;
        /// <summary>
        /// geters and seters for size 
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// constucts basic info for the item
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;

        }

        public override List<string> Ingredients
        {
            get
            {
                ingreadients = new List<string>();
                ingreadients.Add("Cheese Product");
                ingreadients.Add("Breading");
                ingreadients.Add("Vegetable Oil");
                return ingreadients;
            }
        }
        public override string ToString()
        {
            return $"{size} Mezzorella Sticks";
        }
    }


}
//Implement a class to represent the MezzorellaSticks Side that inherits from the Side base class.
//It’s price is **$0.99 (small) **, **$1.45 (medium) **, or**$1.95 (large) **.  Its calories are**540 (small) **,
//**610 (medium) **, and**720 (large) **.  Its ingredients are** cheese product, breading, ** and ** vegtable oil**. 

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// a side item that is tatertots inherits from side
    /// </summary>
    public class Triceritots : Side
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
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
        public Triceritots()
        {
            Price = 0.99;
            Calories = 352;
            ingreadients.Add("Potato");
            ingreadients.Add("Salt");
            ingreadients.Add("Vegetable Oil");
        }
    }
}
//Implement a class to represent the Triceritots Side that inherits from the Side base class.  
//It’s price is **$0.99 (small)**, **$1.45 (medium)**, or **$1.95 (large)**.  Its calories are **352 (small)**,
//**410 (medium)**, and **590 (large)**.  Its ingredients are **potatoes, salt, **and **vegtable oil**. 

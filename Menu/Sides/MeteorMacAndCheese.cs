using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// a side item that is mac and cheese inherits from side
    /// </summary>
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
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
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
        }
        public override List<string> Ingredients
        {
            get
            {
                ingreadients = new List<string>();
                ingreadients.Add("Macaroni Noodles");
                ingreadients.Add("Cheese Product");
                ingreadients.Add("Pork Sausage");
                return ingreadients;
            }
        }
        public override string ToString()
        {
            return $"{size} Meteor Mac and Cheese";
        }
    }
}
//Implement a class to represent the MeteorMacAndCheese Side that inherits from the Side base class. 
//It’s price is **$0.99 (small)**, **$1.45 (medium)**, or **$1.95 (large)**.  Its calories are **420 (small)**, 
//**490 (medium)**, and **520 (large)**.  Its ingredients are **macaroni noodles, cheese product, **and **pork sausage**. 

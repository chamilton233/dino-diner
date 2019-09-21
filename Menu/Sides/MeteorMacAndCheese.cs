using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
        private Size size;
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
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            ingreadients.Add("Macaroni Noodles");
            ingreadients.Add("Cheese Product");
            ingreadients.Add("Pork Sausage");
        }
    }
}
//Implement a class to represent the MeteorMacAndCheese Side that inherits from the Side base class. 
//It’s price is **$0.99 (small)**, **$1.45 (medium)**, or **$1.95 (large)**.  Its calories are **420 (small)**, 
//**490 (medium)**, and **520 (large)**.  Its ingredients are **macaroni noodles, cheese product, **and **pork sausage**. 

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        private Size size;
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
            }
            get {
                return size;
            }
        }
        public Fryceritops()
        {
            Price = 0.99;
            Calories = 222;
            ingreadients.Add("Potato");
            ingreadients.Add("Salt");
            ingreadients.Add("Vegetable Oil");
        }
    }
}
//Implement a class to represent the Fryceritops Side that inherits from the Side base class.  It’s price is **$0.99 (small)**, **$1.45 (medium)**, or **$1.95 (large)**.  Its calories are **222 (small)**, **365 (medium)**, and **480 (large)**.  Its ingredients are **potatoes, salt, **and **vegtable oil**.

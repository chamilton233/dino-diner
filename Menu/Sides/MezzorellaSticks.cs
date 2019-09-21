using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
   public class MezzorellaSticks : Side  
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
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            ingreadients.Add("Cheese Product");
            ingreadients.Add("Breading");
            ingreadients.Add("Vegetable Oil");
        }
    }

}
//Implement a class to represent the MezzorellaSticks Side that inherits from the Side base class.
//It’s price is **$0.99 (small) **, **$1.45 (medium) **, or**$1.95 (large) **.  Its calories are**540 (small) **,
//**610 (medium) **, and**720 (large) **.  Its ingredients are** cheese product, breading, ** and ** vegtable oil**. 

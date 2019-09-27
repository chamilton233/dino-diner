using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private Size size;

        private bool Sweet = false;

        private bool Lemon = false;

        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }
            get
            {
                return size;
            }
        }

        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            ingreadients.Add("Water");
            ingreadients.Add("Tea");
        }

        public override List<string> Ingredients
        {
            get
            {
                if (Sweet) ingreadients.Add("Cane Sugar");
                if (Lemon) ingreadients.Add("Lemon");
                return ingreadients;
            }
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        public void AddSweet()
        {
            Sweet = true;
        }
    }
}

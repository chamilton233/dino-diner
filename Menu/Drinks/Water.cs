using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        private bool Lemon = false;

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            ingreadients.Add("Water");
        }

        public override List<string> Ingredients
        {
            get
            {
                if (Lemon) ingreadients.Add("Lemon");
                return ingreadients;
            }
        }

        public void AddLemon()
        {
            Lemon = true;
        }
    }
}

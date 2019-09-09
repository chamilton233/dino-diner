using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnions()
        {
            this.onions = false;
        }
    }
}



/*
 * Each entree should be declared in the **DinoDiner.Menu.Entree** namepace.

Each entree should implement a property for: Price (a double), Calories (a uint), and Ingredients (a List<string>).  The list of ingredients depends on the class, and can be modified as described under each class heading.

Your code should pass all the tests  provided in the MenuTest project, and be documented using Visual Studio XML (as specified in the style guide).

### Brontowurst (15 points possible)

Implement a class to represent the Brontowurst entree.  Its price is **$5.36**, it contains **498 calories**, and its ingredients are: **brautwurst, whole-wheat bun, peppers**, and **onions.**  It should implement methods for holding the **bun, peppers**, and **onions.**

 * */

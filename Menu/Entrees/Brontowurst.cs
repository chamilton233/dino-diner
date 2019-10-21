using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// menu item pretty much a braut with the works on top inherits from entree
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// if we include the bun
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// if we include the peppers
        /// </summary>
        private bool Peppers = true;
        /// <summary>
        /// if we include the onions
        /// </summary>
        private bool Onions = true;
        /// <summary>
        /// gets the correct list of ingreadents
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Bun) ingreadients.Add("Whole Wheat Bun");
                if (Peppers) ingreadients.Add("Peppers");
                if (Onions) ingreadients.Add("Onion");
                return ingreadients;
            }
        }
        /// <summary>
        /// constuctor fills in basic infomation about this item
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
            ingreadients.Add("Brautwurst");
        }
        /// <summary>
        /// holds the bun
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// holds the peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// holds the onions
        /// </summary>
        public void HoldOnion()
        {
            this.Onions = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
            return "Brontowurst";
        }
        /// <summary>
        /// the description of this item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// describes all differnt than normal things the item has
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Bun) special.Add("Hold Whole Wheat Bun");
                if (!Peppers) special.Add("Hold Peppers");
                if (!Onions) special.Add("Hold Onion");
                return special.ToArray();
            }
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

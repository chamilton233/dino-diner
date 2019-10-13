using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// a menu item basicly a burger with more stuff inherits from entree
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// if we include the bun
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// if we include the lettuce
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// if we include the tomato
        /// </summary>
        private bool Tomato = true;
        /// <summary>
        /// if we include the onion
        /// </summary>
        private bool Onion = true;
        /// <summary>
        /// if we include the pickle
        /// </summary>
        private bool Pickle = true;
        /// <summary>
        /// if we include the ketchup
        /// </summary>
        private bool Ketchup = true;
        /// <summary>
        /// if we include the mustard
        /// </summary>
        private bool Mustard = true;
        /// <summary>
        /// if we include the mayo
        /// </summary>
        private bool Mayo = true;
        /// <summary>
        /// gets the correct list of ingreadents
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (Bun) ingreadients.Add("Whole Wheat Bun");
                if (Lettuce) ingreadients.Add("Lettuce");
                if (Tomato) ingreadients.Add("Tomato");
                if (Onion) ingreadients.Add("Onion");
                if (Pickle) ingreadients.Add("Pickle");
                if (Ketchup) ingreadients.Add("Ketchup");
                if (Mustard) ingreadients.Add("Mustard");
                if (Mayo) ingreadients.Add("Mayo");
                return ingreadients;
            }
        }
        /// <summary>
        /// constuctor fills in basic infomation about this item
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
            ingreadients.Add("Steakburger Pattie");
            ingreadients.Add("Steakburger Pattie");
            ingreadients.Add("Steakburger Pattie");
        }
        /// <summary>
        /// holds the bun
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false;
        }
        /// <summary>
        /// holds the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }
        /// <summary>
        /// holds the tomato
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
        }
        /// <summary>
        /// holds the onion
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
        }
        /// <summary>
        /// holds the pickle
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
        }
        /// <summary>
        /// holds the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }
        /// <summary>
        /// holds the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }
        /// <summary>
        /// holds the mayo
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
//Implement a class to represent the T-Rex King Burger entree.  Its price is **$8.45**, it contains **728 calories**, and its ingredients are:
//a **whole wheat bun, three steakburger patties, lettuce, tomato, onion, pickle, ketchup, mustard**, and **mayo**.  It should implement methods 
//for holding the **bun, lettuce, tomato, onion, pickle, ketchup, mustard**, and **mayo.**

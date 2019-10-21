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
                ingreadients = new List<string>();
                ingreadients.Add("Steakburger Pattie");
                ingreadients.Add("Steakburger Pattie");
                ingreadients.Add("Steakburger Pattie");
                if (Bun) ingreadients.Add("Whole Wheat Bun");
                if (Lettuce) ingreadients.Add("Lettuce");
                if (Tomato) ingreadients.Add("Tomato");
                if (Onion) ingreadients.Add("Onion");
                if (Pickle) ingreadients.Add("Pickle");
                if (Ketchup) ingreadients.Add("Ketchup");
                if (Mustard) ingreadients.Add("Mustard");
                if (Mayo) ingreadients.Add("Mayonnaise");
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
        /// holds the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// holds the tomato
        /// </summary>
        public void HoldTomato()
        {
            this.Tomato = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// holds the onion
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// holds the pickle
        /// </summary>
        public void HoldPickle()
        {
            this.Pickle = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// holds the ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// holds the mustard
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// holds the mayo
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                if (!Pickle) special.Add("Hold Pickle");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Tomato) special.Add("Hold Tomato");
                if (!Onion) special.Add("Hold Onion");
                if (!Mayo) special.Add("Hold Mayonnaise");
                return special.ToArray();
            }
        }
    }
}
//Implement a class to represent the T-Rex King Burger entree.  Its price is **$8.45**, it contains **728 calories**, and its ingredients are:
//a **whole wheat bun, three steakburger patties, lettuce, tomato, onion, pickle, ketchup, mustard**, and **mayo**.  It should implement methods 
//for holding the **bun, lettuce, tomato, onion, pickle, ketchup, mustard**, and **mayo.**

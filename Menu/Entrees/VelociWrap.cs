using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// a menu item that is a chicken wrap inherits from entree
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// if we include the dressing
        /// </summary>
        private bool Dressing = true;
        /// <summary>
        /// if we include the lettuce
        /// </summary>
        private bool Lettuce = true;
        /// <summary>
        /// if we include the parmasan cheese
        /// </summary>
        private bool Cheese = true;     
        /// <summary>
        /// gets the correct ingreadents list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingreadients = new List<string>();
                ingreadients.Add("Flour Tortilla");
                ingreadients.Add("Chicken Breast");
                if (Dressing) ingreadients.Add("Ceasar Dressing");
                if (Lettuce) ingreadients.Add("Romaine Lettuce");
                if (Cheese) ingreadients.Add("Parmesan Cheese");
                return ingreadients;
            }
        }
        /// <summary>
        /// constotor fills in basic info about the item
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// holds the dressing
        /// </summary>
        public void HoldDressing()
        {
            this.Dressing = false;
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
        /// holds the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Dressing) special.Add("Hold Ceasar Dressing");
                if (!Cheese) special.Add("Hold Parmesan Cheese");
                if (!Lettuce) special.Add("Hold Romaine Lettuce");
                return special.ToArray();
            }
        }
    }
}
//Implement a class to represent the Veloci-Wrap entree.Its price is **$6.86**, it contains **356 calories**, and its ingredients are: a** flour tortilla, chicken breast, romaine lettuce, Ceasar dressing**
//, and** parmesan cheese**.  It should implement methods to hold the** dressing, lettuce**, and** cheese.**


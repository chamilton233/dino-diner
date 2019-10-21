using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// if you want to drink water 
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// backing for size
        /// </summary>
        private Size size;
        /// <summary>
        /// property to set the size
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                NotifyParentPropertyChanged("Description");
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// backing for the lemon 
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// the consturtor gives default info
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            
        }
        /// <summary>
        /// returns the correct ingreadednts
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingreadients = new List<string>();
                ingreadients.Add("Water");
                if (Lemon) ingreadients.Add("Lemon");
                return ingreadients;
            }
        }
        /// <summary>
        /// adds lemon to the water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
            return $"{size} Water";
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
                if (Lemon) special.Add("Add Lemon");
                if(!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }


    }
}

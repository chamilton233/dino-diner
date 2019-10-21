using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// its tea can have lemon or sweet
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// backing for size
        /// </summary>
        private Size size;
        /// <summary>
        /// backing for sweet
        /// </summary>
        private bool sweet =false;
        /// <summary>
        /// how sweet works when changed
        /// </summary>
        public bool Sweet {
            get {
                return sweet;
            }
            set {
                if (value)
                {
                    sweet = true;
                    switch (size)
                    {
                        case Size.Small:
                            Calories = 8 * 2;
                            break;
                        case Size.Medium:
                            Calories = 16 * 2;
                            break;
                        case Size.Large:
                            Calories = 32 * 2;
                            break;
                    }

                }
                else
                {
                    sweet = false;
                    switch (size)
                    {
                        case Size.Small:
                            Calories = 8;
                            break;
                        case Size.Medium:
                            Calories = 16;
                            break;
                        case Size.Large:
                            Calories = 32;
                            break;
                    }

                }
                NotifyParentPropertyChanged("Description");
                NotifyParentPropertyChanged("Calories");
                NotifyParentPropertyChanged("Ingredients");
            }
        }
        /// <summary>
        /// backing for lemon
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// how lemon is changed
        /// </summary>
        public bool Lemon
        {
            get {
                return lemon;
            }
            set {
                lemon = value;
            }
        }

        /// <summary>
        /// how size is changed
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = sweet ? 8 * 2 : Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = sweet ? 16 * 2 : Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = sweet ? 32 * 2 :Calories= 32;
                        break;
                }
                NotifyParentPropertyChanged("Description");
                NotifyParentPropertyChanged("Price");
                NotifyParentPropertyChanged("Calories");
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// basic constuctor puts in default info
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;

        }

        /// <summary>
        /// adds lemons to the tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// gets the correct list of ingreadents
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                ingreadients = new List<string>();
                ingreadients.Add("Water");
                ingreadients.Add("Tea");
                if (sweet) ingreadients.Add("Cane Sugar");
                if (lemon) ingreadients.Add("Lemon");
                return ingreadients;
            }
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
            if (sweet)
            {
                return $"{size} Sweet Tyrannotea";
            }
            else
            {
                return $"{size} Tyrannotea";
            }
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
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

    }
}

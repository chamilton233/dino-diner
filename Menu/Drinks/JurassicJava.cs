using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{/// <summary>
/// its coffee can be decaf and have room for cream
/// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// backing of the size 
        /// </summary>
        private Size size;

        private bool roomForCream = false;

        /// <summary>
        /// if there is room for cream in the cofee
        /// </summary>
        public bool RoomForCream {
            get {
                return roomForCream;
            }
            set {
                roomForCream = value;
                NotifyParentPropertyChanged("Special");
            }
        }

        private bool decaf = false;
        /// <summary>
        /// if it is decaf or not
        /// </summary>
        public bool Decaf {
            get { return decaf; }
            set
            {
                decaf = value;
                NotifyParentPropertyChanged("Description");
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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
                NotifyParentPropertyChanged("Description");
                NotifyParentPropertyChanged("Calories");
                NotifyParentPropertyChanged("Price");
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// the constuctor for this fills in basic info
        /// </summary>
        public JurassicJava()
        {
            Price = 0.59;
            Calories = 2;
            Ice = false;
            
        }
        /// <summary>
        /// adds ice
        /// </summary>
        public void AddIce()
        {
            Ice = true;
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// leaves room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
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
                ingreadients.Add("Coffee");
                return ingreadients;
            }
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string  ToString()
        {
            if (Decaf)
            {
                return $"{size} Decaf Jurassic Java";
            }
            else
            {
                return $"{size} Jurassic Java";
            }
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
                if (RoomForCream) special.Add("Leave Room For Cream");
                if (Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }
    }
}

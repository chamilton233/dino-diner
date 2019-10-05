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
        /// <summary>
        /// if there is room for cream in the cofee
        /// </summary>
        public bool RoomForCream = false;
        /// <summary>
        /// if it is decaf or not
        /// </summary>
        public bool Decaf = false;
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
        }
        /// <summary>
        /// leaves room for cream
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
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
    }
}

﻿using System;
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
                    ingreadients.Add("Cane Sugar");
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
                    ingreadients.Remove("Cane Sugar");
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
                if (lemon)
                {
                    ingreadients.Add("Lemon");
                }
                else
                {
                    ingreadients.Remove("Lemon");
                }
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
            ingreadients.Add("Water");
            ingreadients.Add("Tea");
        }

        /// <summary>
        /// adds lemons to the tea
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }



    }
}

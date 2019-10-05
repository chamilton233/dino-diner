﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// menu item pretty much a burger inherits from entree
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// if we include the bun
        /// </summary>
        private bool Bun = true;
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
        /// gets the correct ingreadent list
        /// </summary>
        public override List<string> Ingredients
        {
            get
            { 
                if (Bun) ingreadients.Add("Whole Wheat Bun");
                if (Pickle) ingreadients.Add("Pickle");
                if (Ketchup) ingreadients.Add("Ketchup");
                if (Mustard) ingreadients.Add("Mustard");
                return ingreadients;
            }
        }
        /// <summary>
        /// constuctor inputs basic info about the item
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
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
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

    }
}
//Implement a class to represent the Steakosaurus Burger entree.  
//Its price is **$5.15**, it contains **621 calories**, and its 
//ingredients are: **whole wheat bun, steakburger pattie, pickle, ketchup**,
//and **mustard.**  It should implement methods for holding the 
//**bun, pickle, ketchup,** and **mustard**.


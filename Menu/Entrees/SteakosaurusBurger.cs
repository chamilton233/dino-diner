using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "steakburger pattie" };
                if (bun) ingredients.Add("bun");
                if (pickle) ingredients.Add("pickle");
                if (ketchup) ingredients.Add("ketchup");
                if (mustard) ingredients.Add("mustard");
                return ingredients;
            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
//Implement a class to represent the Steakosaurus Burger entree.  
//Its price is **$5.15**, it contains **621 calories**, and its 
//ingredients are: **whole wheat bun, steakburger pattie, pickle, ketchup**,
//and **mustard.**  It should implement methods for holding the 
//**bun, pickle, ketchup,** and **mustard**.


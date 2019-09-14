using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// menu item pretty much chicken nuggets
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// the price of the item
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// the number of calories it is
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// teh number of nuggets ordered default 6
        /// </summary>
        private uint NuggetCount = 6;
        /// <summary>
        /// gets the correct list of ingreadents
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {  };
                for (int i = 0; i < NuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }
        /// <summary>
        /// constuctor fills in basic infomation about this item
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }
        /// <summary>
        /// Adds an additional nugget to the meal costs $0.25 and 59 more calories
        /// </summary>
        public void AddNugget()
        {
            Price += 0.25;
            Calories += 59;
            NuggetCount++;
        }
    }
}
//Implement a class to represent the Dino Nuggest entree. 
//Its price is **$4.25**, it contains **59 calories** per nugget, 
//and its ingredients are: **6** **chicken nuggets**.  It should 
//implement methods for adding a nugget at an additional **$0.25**.
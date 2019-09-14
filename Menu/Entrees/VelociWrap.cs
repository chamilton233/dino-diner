using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// a menu item that is a chicken wrap
    /// </summary>
    public class VelociWrap
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
        /// the price of the item
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// the numvber of calories it has
        /// </summary>
        public uint Calories { get; set; }
        
        /// <summary>
        /// gets the correct ingreadents list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" , "Chicken Breast" };
                if (Dressing) ingredients.Add("Ceasar Dressing");
                if (Lettuce) ingredients.Add("Romaine Lettuce");
                if (Cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
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
        }
        /// <summary>
        /// holds the lettuce
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }
        /// <summary>
        /// holds the cheese
        /// </summary>
        public void HoldCheese()
        {
            this.Cheese = false;
        }
    }
}
//Implement a class to represent the Veloci-Wrap entree.Its price is **$6.86**, it contains **356 calories**, and its ingredients are: a** flour tortilla, chicken breast, romaine lettuce, Ceasar dressing**
//, and** parmesan cheese**.  It should implement methods to hold the** dressing, lettuce**, and** cheese.**


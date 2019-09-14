using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// menu item pretty much a peanut butter and jelly sandwitch
    /// </summary>
    public class PrehistoricPBJ
    {
        /// <summary>
        /// if we include the peanut butter
        /// </summary>
        private bool PeanutButter = true;
        /// <summary>
        /// if we include the jelly
        /// </summary>
        private bool Jelly = true;
        /// <summary>
        /// the price of the item
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// the number of calories it is
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// gets the correct list of ingreadents
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (PeanutButter) ingredients.Add("Peanut Butter");
                if (Jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// constuctor fills in basic infomation about this item
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// holds the peanut butter
        /// </summary>
        public void HoldPeanutButter()
        {
            this.PeanutButter = false;
        }
        /// <summary>
        /// holds the jelly
        /// </summary>
        public void HoldJelly()
        {
            this.Jelly = false;
        }
    }
}

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// menu item pretty much a peanut butter and jelly sandwitch inherits from entree
    /// </summary>
    public class PrehistoricPBJ : Entree
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
        /// gets the correct list of ingreadents
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                if (PeanutButter) ingreadients.Add("Peanut Butter");
                if (Jelly) ingreadients.Add("Jelly");
                return ingreadients;
            }
        }
        /// <summary>
        /// constuctor fills in basic infomation about this item
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
            ingreadients.Add("Bread");
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

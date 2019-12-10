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
                ingreadients = new List<string>();
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
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// holds the jelly
        /// </summary>
        public void HoldJelly()
        {
            this.Jelly = false;
            NotifyParentPropertyChanged("Ingredients");
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// overrides the default to string method
        /// </summary>
        /// <returns></returns> a string describing this class
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
        /// <summary>
        /// the description of this item
        /// </summary>
        public override string Description
        {
            get {
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
                if (!PeanutButter) special.Add("Hold Peanut Butter");
                if (!Jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}

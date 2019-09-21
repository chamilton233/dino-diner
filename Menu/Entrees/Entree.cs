using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// abstrct class for a entree
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// makes the protected ingreaddents list
        /// </summary>
        protected List<string> ingreadients = new List<string>();

        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients
        {
            get
            {
                return ingreadients;
            }
        }
    }
}

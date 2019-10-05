using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// enum of size where small=0 and large =2
    /// </summary>


    /// <summary>
    /// abstract class for a side
    /// </summary>
    public abstract class Side : IMenuItem
    {
        /// <summary>
        /// makes the protected ingreaddents list
        /// </summary>
        protected List<string> ingreadients = new List<string>(); 

        /// <summary>
        /// Gets and sets the price
        /// </summary>C:\Users\chami\cis400\dino-diner\Menu\Sides\Triceritots.cs
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
            get{
                return ingreadients;
            }
        }
        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}

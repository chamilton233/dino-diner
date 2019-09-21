using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// menu item pretty much chicken nuggets inherits from entree
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// the number of extranuggets ordered default 0
        /// </summary>
        private uint ExtraNuggetCount = 0;
        /// <summary>
        /// gets the correct list of ingreadents had issue with it adding extra nuggets. worked around it
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                for (int i = ingreadients.Count; i < 6 + ExtraNuggetCount; i++)
                {
                    ingreadients.Add("Chicken Nugget");
                }
                return ingreadients;
            }
        }
        /// <summary>
        /// constuctor fills in basic infomation about this item
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
            for (int i = 0; i < 6; i++)
            {
                ingreadients.Add("Chicken Nugget");
            }
        }
        /// <summary>
        /// Adds an additional nugget to the meal costs $0.25 and 59 more calories
        /// </summary>
        public void AddNugget()
        {
            Price += 0.25;
            Calories += 59;
            ExtraNuggetCount++;
        }
    }
}
//Implement a class to represent the Dino Nuggest entree. 
//Its price is **$4.25**, it contains **59 calories** per nugget, 
//and its ingredients are: **6** **chicken nuggets**.  It should 
//implement methods for adding a nugget at an additional **$0.25**.
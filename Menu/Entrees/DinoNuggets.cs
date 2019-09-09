using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public uint nuggetcount = 6;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {  };
                for (int i = 0; i < nuggetcount; i++)
                {
                    ingredients.Add("Nugget");
                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            Price += 0.25;
            Calories += 59;
        }
    }
}
//Implement a class to represent the Dino Nuggest entree. 
//Its price is **$4.25**, it contains **59 calories** per nugget, 
//and its ingredients are: **6** **chicken nuggets**.  It should 
//implement methods for adding a nugget at an additional **$0.25**.
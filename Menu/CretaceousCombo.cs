using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;
namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        public Entree Entree { get; set; }
        private Side side;
        public Side Side {
            get { return side; }
            set {
                this.side = value;
                this.side.Size = this.size;
            }
        }
        private Drink drink;
        public Drink Drink {
            get { return drink; }
            set
            {
                this.drink = value;
                this.drink.Size = this.size;
            }
        }

        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        private Size size = Size.Small;
        public Size Size
        {
            get {
                return size;
            }
            set {
                size = value;
                Side.Size = value;
                Drink.Size = value;
            }
        }

        public List<string> Ingredients
        {
            get {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }

        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
    }
}

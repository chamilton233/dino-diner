using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem , INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyParentPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Entree entree;
        public Entree Entree {
            get
            {
                return entree;
            }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyParentPropertyChanged(args.PropertyName);
                };
            }
        }
        //public Entree Entree { get; protected set; }

        private Side side;
        public Side Side {
            get { return side; }
            set {
                this.side = value;
                this.side.Size = this.size;
                NotifyParentPropertyChanged("Ingredients");
                NotifyParentPropertyChanged("Special");
                NotifyParentPropertyChanged("Price");
                NotifyParentPropertyChanged("Calories");
            }
        }
        private Drink drink;
        public Drink Drink {
            get { return drink; }
            set
            {
                this.drink = value;
                this.drink.Size = this.size;
                NotifyParentPropertyChanged("Ingredients");
                NotifyParentPropertyChanged("Special");
                NotifyParentPropertyChanged("Price");
                NotifyParentPropertyChanged("Calories");
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
                NotifyParentPropertyChanged("Special");
                NotifyParentPropertyChanged("Size");
                NotifyParentPropertyChanged("Price");
                NotifyParentPropertyChanged("Calories");
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
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }

        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                
                return special.ToArray();
            }
        }
    }
}

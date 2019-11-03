using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// the class for a combo of a entree side and drink
    /// </summary>
    public class CretaceousCombo : IMenuItem , INotifyPropertyChanged , IOrderItem
    {
        /// <summary>
        /// an notifing event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// notifyies all things about a property changing
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyParentPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// the entree
        /// </summary>
        private Entree entree;
        /// <summary>
        /// property the entree
        /// </summary>
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
        /// <summary>
        /// the side
        /// </summary>
        private Side side;
        /// <summary>
        /// property the side
        /// </summary>
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
        /// <summary>
        /// the drink with the combo
        /// </summary>
        private Drink drink;
        /// <summary>
        /// property of the drink with the combo
        /// </summary>
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
        /// <summary>
        /// gets the price
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }
        /// <summary>
        /// gets the calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        /// <summary>
        /// sets the size of everything
        /// </summary>
        private Size size = Size.Small;
        /// <summary>
        /// sets the size of everything
        /// </summary>
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
                NotifyParentPropertyChanged("Description");
            }
        }
        /// <summary>
        /// the ingeridients
        /// </summary>
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
        /// <summary>
        /// sets basic info about this object
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
        /// <summary>
        /// the name of this combo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
        /// <summary>
        /// the description of this item
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// describes all differnt than normal things the item has
        /// </summary>
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

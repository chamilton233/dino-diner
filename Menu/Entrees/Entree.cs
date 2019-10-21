using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// abstrct class for a entree
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem , INotifyPropertyChanged
    {
        /// <summary>
        /// makes the protected ingreaddents list
        /// </summary>
        protected List<string> ingreadients = new List<string>();
        /// <summary>
        /// a notfiing thing for an event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// if a property is changed call this it notifys everything
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyParentPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
        /// <summary>
        /// the description of this item
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// describes all differnt than normal things the item has
        /// </summary>
        public abstract string[] Special { get; }
    }
}

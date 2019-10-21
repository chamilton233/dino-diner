using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu.Sides
{


    /// <summary>
    /// abstract class for a side
    /// </summary>
    public abstract class Side : IMenuItem , IOrderItem, INotifyPropertyChanged
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

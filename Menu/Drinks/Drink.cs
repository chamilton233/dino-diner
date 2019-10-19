using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// abstract class for all drinks
    /// </summary>
    public abstract class Drink : IMenuItem ,IOrderItem , INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyParentPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// makes the protected ingreaddents list
        /// </summary>
        protected List<string> ingreadients = new List<string>();
        /// <summary>
        /// if there is ice or not default true
        /// </summary>
        public bool Ice { get; set; } = true;

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
        /// basic hold ice functionality as all drinks can have ice 
        /// </summary>
        public virtual void HoldIce()
        {
            Ice = false;
            NotifyParentPropertyChanged("Special");
        }
        /// <summary>
        /// the size of the drink default small
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        public abstract string Description { get; }

        public abstract string[] Special { get; }
    }
}

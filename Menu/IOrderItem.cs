using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// interface of an order item
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// teh price of the item
        /// </summary>
         double Price { get; }
        /// <summary>
        /// the discription  of the item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// anthing not normal about the item
        /// </summary>
        string[] Special { get; }
    }
}

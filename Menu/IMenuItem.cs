using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// interface for a menu item
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// the price of that item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// the calories of that item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// the ingredients of that item
        /// </summary>
        List<string> Ingredients { get; }
    }
}

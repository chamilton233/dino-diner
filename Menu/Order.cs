using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class of an order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// the obserable list of all items on the order
        /// </summary>
        private ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
        /// <summary>
        /// the property to set the items on the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items
        {
            get
            {
                if (items == null)
                {
                    items = new ObservableCollection<IOrderItem>();
                }
                return items;
            }
            set
            {
                items = value;
            }
        }
        /// <summary>
        /// the subtotal cost
        /// </summary>
        public double SubTotalCost {
            get
            {
                double price = 0;
                for (int i = 0; i < Items.Count; i++)
                {
                    price = price +Items[i].Price;
                }
                if (price < 0)
                {
                    price = 0;
                }
                price = Math.Truncate(price*100) / 100;
                return price;
            }
        }
        /// <summary>
        /// the tax rate
        /// </summary>
        private double salesTaxRate=0.2;
        /// <summary>
        /// the tax rate property
        /// </summary>
        public double SalesTaxRate {
            get
            {
                return salesTaxRate;
            }
            protected set
            {
                salesTaxRate = value;
            }
        }
        /// <summary>
        /// the cost of the sales tax
        /// </summary>
        public double SalesTaxCost {
            get
            {
                double cost = SubTotalCost * SalesTaxRate;
                cost = Math.Truncate(cost * 100) / 100;
                return cost;
            }
        }
        /// <summary>
        /// the total cost
        /// </summary>
        public double TotalCost {
            get
            {
                double cost = SubTotalCost + SalesTaxCost;
                cost = Math.Truncate(cost * 100) / 100;
                return cost;
            }
        }


    }
}

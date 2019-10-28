using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// class of an order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {

        /// <summary>
        /// if a property is changed call this it notifys everything
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyParentPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// the obserable list of all items on the order
        /// </summary>
        private List<IOrderItem> items;

        public IOrderItem[] Items { get { return items.ToArray(); } }
        /// <summary>
        /// the property to set the items on the order
        /// </summary>
        /*public ObservableCollection<IOrderItem> Items
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
        }*/
        /// <summary>
        /// the subtotal cost
        /// </summary>
        public double SubTotalCost {
            get
            {
                double price = 0;
                for (int i = 0; i < items.Count; i++)
                {
                    price = price +items[i].Price;
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

        public event PropertyChangedEventHandler PropertyChanged;

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
                NotifyParentPropertyChanged("SalesTaxCost");
                NotifyParentPropertyChanged("TotalCost");
                NotifyParentPropertyChanged("SalesTaxRate");
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

        public Order()
        {
            items = new List<IOrderItem>();
        }

        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs());
        }

        public bool Remove(IOrderItem item)
        {
            bool b=items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
            return b;

        }

        public void OnCollectionChanged(object sender, EventArgs args)
        {
            NotifyParentPropertyChanged("TotalCost");
            NotifyParentPropertyChanged("SalesTaxCost");
            NotifyParentPropertyChanged("SubTotalCost");
            NotifyParentPropertyChanged("Items");
        }

    }
}

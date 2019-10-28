using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        public NavigationService NavigationService { get; set; }
        public OrderList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// functionality for switching to the right page for a selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService.Navigate(new SideSelcetion(side));
            }
            if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService.Navigate(new DrinkSelection(drink));

            }
        }
        /// <summary>
        /// how to remove an item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement frame)
                {
                    if (frame.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }
    }
}

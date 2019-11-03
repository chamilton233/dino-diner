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
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        /// <summary>
        /// navigation service
        /// </summary>
        public NavigationService NavigationService { get; set; }
        /// <summary>
        /// constuctor
        /// </summary>
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
            if (OrderItems.SelectedItem is CretaceousCombo combo)
            {
                NavigationService.Navigate(new ComboCustomization(combo));
            }
            if(OrderItems.SelectedItem is Entree entree)
            {
                if (entree is Brontowurst brontowurst)
                {
                    NavigationService.Navigate(new BrontowerstCostomize(brontowurst));
                }
                if (entree is DinoNuggets dino)
                {
                    NavigationService.Navigate(new CostomizeDinoNuggets(dino));
                }
                if (entree is PrehistoricPBJ prehistoric)
                {
                    NavigationService.Navigate(new CostomizePBJ(prehistoric));
                }
                if (entree is SteakosaurusBurger steakosaurus)
                {
                    NavigationService.Navigate(new CostomizeSteak(steakosaurus));
                }
                if (entree is TRexKingBurger rex)
                {
                    NavigationService.Navigate(new CostmizeTrex(rex));
                }
                if (entree is VelociWrap wrap)
                {
                    NavigationService.Navigate(new CostomizeVelociWrap(wrap));
                }
                if (entree is PterodactylWings wings)
                {
                    NavigationService.Navigate(new CostomizeWings(wings));
                }
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

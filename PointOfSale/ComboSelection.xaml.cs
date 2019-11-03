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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// intializes this page
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// what happens when a combo is picked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Bronto_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo cretaceousCombo = new CretaceousCombo(new Brontowurst());
                order.Add(cretaceousCombo);
                NavigationService.Navigate(new ComboCustomization(cretaceousCombo));
            }
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dino_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo cretaceousCombo = new CretaceousCombo(new DinoNuggets());
                order.Add(cretaceousCombo);
                NavigationService.Navigate(new ComboCustomization(cretaceousCombo));
            }
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Prehis_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo cretaceousCombo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(cretaceousCombo);
                NavigationService.Navigate(new ComboCustomization(cretaceousCombo));
            }
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wings_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo cretaceousCombo = new CretaceousCombo(new PterodactylWings());
                order.Add(cretaceousCombo);
                NavigationService.Navigate(new ComboCustomization(cretaceousCombo));

            }
        }

        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Steak_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo cretaceousCombo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(cretaceousCombo);
                NavigationService.Navigate(new ComboCustomization(cretaceousCombo));

            }
        }

        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Trex_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo cretaceousCombo = new CretaceousCombo(new TRexKingBurger());
                order.Add(cretaceousCombo);
                NavigationService.Navigate(new ComboCustomization(cretaceousCombo));

            }
        }

        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Veloci_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo cretaceousCombo = new CretaceousCombo(new VelociWrap());
                order.Add(cretaceousCombo);
                NavigationService.Navigate(new ComboCustomization(cretaceousCombo));

            }
        }
    }
}

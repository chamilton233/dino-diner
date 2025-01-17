﻿using System;
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;
        /// <summary>
        /// intializes this page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bronto_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst entree = new Brontowurst();
                order.Add(entree);
                NavigationService.Navigate(new BrontowerstCostomize(entree));

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
                DinoNuggets entree = new DinoNuggets();
                order.Add(entree);
                NavigationService.Navigate(new CostomizeDinoNuggets(entree));

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
                PrehistoricPBJ entree = new PrehistoricPBJ();
                order.Add(entree);
                NavigationService.Navigate(new CostomizePBJ(entree));
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
                PterodactylWings entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new CostomizeWings(entree));

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
                SteakosaurusBurger entree = new SteakosaurusBurger();
                order.Add(entree);
                NavigationService.Navigate(new CostomizeSteak(entree));

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
                TRexKingBurger entree = new TRexKingBurger();
                order.Add(entree);
                NavigationService.Navigate(new CostmizeTrex(entree));

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
                VelociWrap entree = new VelociWrap();
                order.Add(entree);
                NavigationService.Navigate(new CostomizeVelociWrap(entree));

            }
        }
    }
}

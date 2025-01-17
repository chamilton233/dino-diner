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
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BrontowerstCostomize.xaml
    /// </summary>
    public partial class BrontowerstCostomize : Page
    {
        /// <summary>
        /// the brotowerst to be manipulated
        /// </summary>
        Brontowurst bronto;
        /// <summary>
        /// if it is part of a combo
        /// </summary>
        bool combo;
        /// <summary>
        /// the combo it might be part of 
        /// </summary>
        CretaceousCombo Cretaceous; 
        /// <summary>
        /// constuctor if not combo
        /// </summary>
        /// <param name="brontowurst"></param>
        public BrontowerstCostomize(Brontowurst brontowurst)
        {
            InitializeComponent();
            bronto = brontowurst;
            combo = false;
        }
        /// <summary>
        /// constuctor if combo
        /// </summary>
        /// <param name="brontowurst"></param>
        public BrontowerstCostomize(CretaceousCombo brontowurst)
        {
            InitializeComponent();
            Cretaceous = brontowurst;
            bronto = (Brontowurst)brontowurst.Entree;
            combo = true; 
        }
        /// <summary>
        /// holds onions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldOnions_Click(object sender, RoutedEventArgs e)
        {
            bronto.HoldOnion();
        }
        /// <summary>
        /// holds peppers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPeppers_Click(object sender, RoutedEventArgs e)
        {
            bronto.HoldPeppers();
        }
        /// <summary>
        /// holds bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBun_Click(object sender, RoutedEventArgs e)
        {
            bronto.HoldBun();
        }
        /// <summary>
        /// functionality for navigating away from this page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            if (combo)
            {
                NavigationService.Navigate(new ComboCustomization(Cretaceous));
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}

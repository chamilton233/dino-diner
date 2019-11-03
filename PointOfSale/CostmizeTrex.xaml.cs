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
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CostmizeTrex.xaml
    /// </summary>
    public partial class CostmizeTrex : Page
    {
        /// <summary>
        /// the buger being manipulated
        /// </summary>
        private TRexKingBurger Burger;
        /// <summary>
        /// if it is a combo
        /// </summary>
        private bool combo;
        /// <summary>
        /// the clombo it might be part of
        /// </summary>
        CretaceousCombo Cretaceous;
        /// <summary>
        ///  constuctor with out a combo
        /// </summary>
        public CostmizeTrex(TRexKingBurger trex)
        {
            InitializeComponent();
            Burger = trex;
            combo = false;
        }
        /// <summary>
        /// constuctor with a combo
        /// </summary>
        /// <param name="trex"></param>
        public CostmizeTrex(CretaceousCombo trex)
        {
            InitializeComponent();
            Burger = (TRexKingBurger)trex.Entree;
            Cretaceous = trex;
            combo = true;
        }
        /// <summary>
        /// holds the bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBun_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldBun();
        }
        /// <summary>
        /// holds the mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMustard_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldMustard();
        }
        /// <summary>
        /// holds the ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldKetchup_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldKetchup();
        }
        /// <summary>
        /// holds the pickles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPickle_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldPickle();
        }
        /// <summary>
        /// holds hte lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldLettuce_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldLettuce();
        }
        /// <summary>
        /// holds the mayo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMayo_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldMayo();
        }
        /// <summary>
        /// holds the onion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldOnion_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldOnion();
        }
        /// <summary>
        /// holds the tomato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldTomato_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldTomato();
        }
        /// <summary>
        /// done click functionality
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

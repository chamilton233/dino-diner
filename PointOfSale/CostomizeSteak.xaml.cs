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
    /// Interaction logic for CostomizeSteak.xaml
    /// </summary>
    public partial class CostomizeSteak : Page
    {
        /// <summary>
        /// the buger to be manipulated
        /// </summary>
        private SteakosaurusBurger Burger;
        /// <summary>
        /// if it is a part of a combo
        /// </summary>
        private bool combo;
        /// <summary>
        /// the combo that it might be a part of 
        /// </summary>
        private CretaceousCombo Cretaceous;
        /// <summary>
        /// the contsuctior without a combo
        /// </summary>
        /// <param name="steakosaurus"></param>
        public CostomizeSteak(SteakosaurusBurger steakosaurus)
        {
            InitializeComponent();
            Burger = steakosaurus;
            combo =false;
        }
        /// <summary>
        /// the contsuctior with a combo
        /// </summary>
        /// <param name="steakosaurus"></param>
        public CostomizeSteak(CretaceousCombo steakosaurus)
        {
            InitializeComponent();
            Cretaceous = steakosaurus;
            Burger =(SteakosaurusBurger) steakosaurus.Entree;
            combo = true;
        }
        /// <summary>
        /// holds bun
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBun_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldBun();
        }
        /// <summary>
        /// holds mustard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMustard_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldMustard();
        }
        /// <summary>
        /// holds ketchup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldKetchup_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldKetchup();
        }
        /// <summary>
        /// holds pickle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPickle_Click(object sender, RoutedEventArgs e)
        {
            Burger.HoldPickle();
        }
        /// <summary>
        /// done functionality
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

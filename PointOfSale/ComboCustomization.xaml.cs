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
using DDSize = DinoDiner.Menu.Size;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboCustomization.xaml
    /// </summary>
    public partial class ComboCustomization : Page
    {
        CretaceousCombo combo;
        /// <summary>
        /// intializes this page
        /// </summary>
        public ComboCustomization(CretaceousCombo cretaceous)
        {
            InitializeComponent();
            combo = cretaceous;
        }


        /// <summary>
        /// waht happens when drink is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }
        /// <summary>
        /// what happens when side is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Side_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelcetion(combo));
        }
        /// <summary>
        /// changes the size of the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChangeSize(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                combo.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
        /// <summary>
        /// navagates to the entere costomiation page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entre_Click(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is Brontowurst)
            {
                NavigationService.Navigate(new BrontowerstCostomize(combo));
            }
            if (combo.Entree is DinoNuggets)
            {
                NavigationService.Navigate(new CostomizeDinoNuggets(combo));
            }
            if (combo.Entree is PrehistoricPBJ)
            {
                NavigationService.Navigate(new CostomizePBJ(combo));
            }
            if (combo.Entree is SteakosaurusBurger)
            {
                NavigationService.Navigate(new CostomizeSteak(combo));
            }
            if (combo.Entree is PterodactylWings)
            {
                NavigationService.Navigate(new CostomizeWings(combo));
            }
            if (combo.Entree is TRexKingBurger)
            {
                NavigationService.Navigate(new CostmizeTrex(combo));
            }
            if (combo.Entree is VelociWrap)
            {
                NavigationService.Navigate(new CostomizeVelociWrap(combo));
            }
        }
    }
}

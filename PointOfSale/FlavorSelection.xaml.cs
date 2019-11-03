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
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        Sodasaurus sodasaurus;
        CretaceousCombo Cretaceous;
        bool combo = false;
        /// <summary>
        /// intializes this page
        /// </summary>
        public FlavorSelection(Sodasaurus soda)
        {
            sodasaurus = soda;
            InitializeComponent();
        }
        /// <summary>
        /// constuctor for combo 
        /// </summary>
        /// <param name="soda"></param>
        public FlavorSelection(CretaceousCombo soda)
        {
            Cretaceous = soda;
            combo = true;
            sodasaurus = (Sodasaurus)soda.Drink;
            InitializeComponent();
        }
        /// <summary>
        /// functionality for switching the flavor on the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Falvor_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                sodasaurus.Flavor = (SodasaurusFlavor)Enum.Parse(typeof(SodasaurusFlavor), element.Tag.ToString());
                if (!combo)
                {
                }
                else
                {
                    Cretaceous.Drink = sodasaurus;
                }
            }

        }
        /// <summary>
        /// functionality for the done click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            if (!combo)
            {
                NavigationService.Navigate(new DrinkSelection(sodasaurus));
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection(Cretaceous));
            }
        }
    }
}

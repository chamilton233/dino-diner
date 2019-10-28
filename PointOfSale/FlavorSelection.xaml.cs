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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        Sodasaurus sodasaurus;
        /// <summary>
        /// intializes this page
        /// </summary>
        public FlavorSelection(Sodasaurus soda)
        {
            sodasaurus = soda;
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
                NavigationService.Navigate(new DrinkSelection(sodasaurus));
            }

        }
    }
}

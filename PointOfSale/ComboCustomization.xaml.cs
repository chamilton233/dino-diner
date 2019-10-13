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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboCustomization.xaml
    /// </summary>
    public partial class ComboCustomization : Page
    {
        /// <summary>
        /// intializes this page
        /// </summary>
        public ComboCustomization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// waht happens when drink is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
        /// <summary>
        /// what happens when side is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Side_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelcetion());
        }
    }
}

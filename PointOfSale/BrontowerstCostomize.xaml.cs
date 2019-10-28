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
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BrontowerstCostomize.xaml
    /// </summary>
    public partial class BrontowerstCostomize : Page
    {
        Brontowurst bronto;
        bool combo;
        public BrontowerstCostomize(Brontowurst brontowurst, bool comb)
        {
            InitializeComponent();
            bronto = brontowurst;
            combo = comb;
        }

        private void HoldOnions_Click(object sender, RoutedEventArgs e)
        {
            bronto.HoldOnion();
        }
        private void HoldPeppers_Click(object sender, RoutedEventArgs e)
        {
            bronto.HoldPeppers();
        }
        private void HoldBun_Click(object sender, RoutedEventArgs e)
        {
            bronto.HoldBun();
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            if (combo)
            {
                NavigationService.Navigate(new ComboCustomization());
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}

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
    /// Interaction logic for CostomizePBJ.xaml
    /// </summary>
    public partial class CostomizePBJ : Page
    {
        private PrehistoricPBJ pbj;
        bool combo;
        public CostomizePBJ(PrehistoricPBJ prehistoricPBJ, bool comb)
        {
            InitializeComponent();
            pbj = prehistoricPBJ;
            combo = comb;
        }

        private void OnHoldJelly_Click(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }

        private void OnHoldPeanutButter_Click(object sender, RoutedEventArgs e)
        {
            pbj.HoldPeanutButter();
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

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
    /// Interaction logic for CostomizePBJ.xaml
    /// </summary>
    public partial class CostomizePBJ : Page
    {
        /// <summary>
        /// the pbj to be manipulated
        /// </summary>
        private PrehistoricPBJ pbj;
        /// <summary>
        /// if it is a combo
        /// </summary>
        bool combo;
        /// <summary>
        /// the combo it might be a part of
        /// </summary>
        CretaceousCombo Cretaceous;
        /// <summary>
        /// the constuctor if it is not a combo
        /// </summary>
        /// <param name="prehistoricPBJ"></param>
        public CostomizePBJ(PrehistoricPBJ prehistoricPBJ)
        {
            InitializeComponent();
            pbj = prehistoricPBJ;
            combo = false;
        }
        /// <summary>
        /// the constuctor if it is a combod
        /// </summary>
        /// <param name="prehistoricPBJ"></param>
        public CostomizePBJ(CretaceousCombo prehistoricPBJ)
        {
            InitializeComponent();
            Cretaceous = prehistoricPBJ;
            pbj = (PrehistoricPBJ)prehistoricPBJ.Entree;
            combo = true;
        }
        /// <summary>
        /// holds the jelly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnHoldJelly_Click(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }
        /// <summary>
        /// holds the peanut butter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPeanutButter_Click(object sender, RoutedEventArgs e)
        {
            pbj.HoldPeanutButter();
        }
        /// <summary>
        /// the functionality on done click
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

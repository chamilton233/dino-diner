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
    /// Interaction logic for CostomizeVelociWrap.xaml
    /// </summary>
    public partial class CostomizeVelociWrap : Page
    {
        /// <summary>
        /// the wrap to be manipulated
        /// </summary>
        private VelociWrap Wrap;
        /// <summary>
        /// if it part of a combo
        /// </summary>
        bool combo;
        /// <summary>
        /// the combo if it part of ne
        /// </summary>
        CretaceousCombo Cretaceous;
        /// <summary>
        /// if it is not a combo constuctor
        /// </summary>
        /// <param name="veloci"></param>
        public CostomizeVelociWrap(VelociWrap veloci)
        {
            InitializeComponent();
            Wrap = veloci;
            combo = false;
        }
        /// <summary>
        /// the constuctior if it is a combo
        /// </summary>
        /// <param name="veloci"></param>
        public CostomizeVelociWrap(CretaceousCombo veloci)
        {
            InitializeComponent();
            Wrap = (VelociWrap)veloci.Entree;
            Cretaceous = veloci;
            combo = true;
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
        /// <summary>
        /// the hold cheese functioality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldCheese_Click(object sender, RoutedEventArgs e)
        {
            Wrap.HoldCheese();
        }
        /// <summary>
        /// holds the dressing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldDressing_Click(object sender, RoutedEventArgs e)
        {
            Wrap.HoldDressing();
        }
        /// <summary>
        /// holds the lettuce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldLettuce_Click(object sender, RoutedEventArgs e)
        {
            Wrap.HoldLettuce();
        }
    }
}

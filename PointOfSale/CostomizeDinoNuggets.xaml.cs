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
    /// Interaction logic for CostomizeDinoNuggets.xaml
    /// </summary>
    public partial class CostomizeDinoNuggets : Page
    {
        /// <summary>
        /// the nuggets to be manipulated
        /// </summary>
        private DinoNuggets Nuggets;
        /// <summary>
        /// if it is a combo
        /// </summary>
        bool combo;
        /// <summary>
        /// the combo it might be part of
        /// </summary>
        CretaceousCombo Cretaceous;
        /// <summary>
        /// constuctor with out combo
        /// </summary>
        /// <param name="dino"></param>
        public CostomizeDinoNuggets(DinoNuggets dino)
        {
            InitializeComponent();
            Nuggets = dino;
            combo = false;
        }
        /// <summary>
        /// constuctior with combo
        /// </summary>
        /// <param name="dino"></param>
        public CostomizeDinoNuggets(CretaceousCombo dino)
        {
            InitializeComponent();
            Cretaceous = dino;
            Nuggets = (DinoNuggets)dino.Entree;
            combo = true;
        }
        /// <summary>
        /// addss a nugget
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNugget_Click(object sender, RoutedEventArgs e)
        {
            Nuggets.AddNugget();
        }
        /// <summary>
        /// functionality on doen click
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

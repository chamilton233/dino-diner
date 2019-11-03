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
    /// Interaction logic for CostomizeWings.xaml
    /// </summary>
    public partial class CostomizeWings : Page
    {
        /// <summary>
        /// the wings to be maniplutated
        /// </summary>
        private PterodactylWings wings;
        /// <summary>
        /// the combo if it part of one
        /// </summary>
        private CretaceousCombo Cretaceous;
        /// <summary>
        /// if it is part of a combo
        /// </summary>
        bool combo;
        /// <summary>
        /// the constuctor without a combo
        /// </summary>
        /// <param name="pterodactyl"></param>
        public CostomizeWings(PterodactylWings pterodactyl)
        {
            InitializeComponent();
            wings = pterodactyl;
            combo = false;
        }
        /// <summary>
        /// the constuctor with the combo
        /// </summary>
        /// <param name="pterodactyl"></param>
        public CostomizeWings(CretaceousCombo pterodactyl)
        {
            InitializeComponent();
            wings =(PterodactylWings) pterodactyl.Entree;
            Cretaceous = pterodactyl;
            combo = true;
        }
        /// <summary>
        /// the done finctionality
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

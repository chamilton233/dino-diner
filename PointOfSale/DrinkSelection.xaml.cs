﻿using System;
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
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using DDSize = DinoDiner.Menu.Size; 

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// the drink to be manipulated
        /// </summary>
        private Drink drink;
        /// <summary>
        /// if it is part of a combo
        /// </summary>
        private bool combo = false;
        /// <summary>
        /// the combo this may be a part of
        /// </summary>
        private CretaceousCombo Cretaceous;
        /// <summary>
        /// intializes this page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            drink = new Water();
        }
        /// <summary>
        /// constuctor that taken in a drink for a parameter 
        /// </summary>
        /// <param name="drnk"></param>
        public DrinkSelection(Drink drnk)
        {
            InitializeComponent();
            this.drink = drnk;
            if (drink is Sodasaurus soda)
            {
                S_D_F.IsEnabled = true;
                L_LRFC.IsEnabled = false;
            }
            if (drink is Tyrannotea tyrannotea)
            {
                S_D_F.IsEnabled = true;
                L_LRFC.IsEnabled = true;
            }
            if (drink is JurassicJava java)
            {
                S_D_F.IsEnabled = true;
                L_LRFC.IsEnabled = true;
            }
            if (drink is Water wa)
            {
                S_D_F.IsEnabled = false;
                L_LRFC.IsEnabled = true;
            }
        }
        /// <summary>
        /// its the constuctor in case this is a part of a combo
        /// </summary>
        /// <param name="drnk"></param>
        public DrinkSelection(CretaceousCombo drnk)
        {
            InitializeComponent();
            Cretaceous = drnk;
            drink = Cretaceous.Drink;
            combo = true;
            if (drink is Sodasaurus soda)
            {
                S_D_F.IsEnabled = true;
                L_LRFC.IsEnabled = false;
            }
            if (drink is Tyrannotea tyrannotea)
            {
                S_D_F.IsEnabled = true;
                L_LRFC.IsEnabled = true;
            }
            if (drink is JurassicJava java)
            {
                S_D_F.IsEnabled = true;
                L_LRFC.IsEnabled = true;
            }
            if (drink is Water wa)
            {
                S_D_F.IsEnabled = false;
                L_LRFC.IsEnabled = true;
            }
        }
        /// <summary>
        /// what happens when flavor is clicked
        /// or decaf or sweet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decaf_Flavor_Sweet_Click(object sender, RoutedEventArgs e)
        {
            if (drink is Sodasaurus soda)
            {
                if (!combo)
                {
                    NavigationService.Navigate(new FlavorSelection(soda));
                }
                else
                {
                    NavigationService.Navigate(new FlavorSelection(Cretaceous));
                }
            }
            if (drink is Tyrannotea tyrannotea)
            {
                if (tyrannotea.Sweet)
                {
                    tyrannotea.Sweet = false;
                }
                else
                {
                    tyrannotea.Sweet = true;
                }
            }
            if (drink is JurassicJava java)
            {
                if (java.Decaf)
                {
                    java.Decaf = false;
                }
                else
                {
                    java.Decaf = true;
                }
            }
            if (combo)
            {
                Cretaceous.Drink = drink;
            }
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new Water();
                if (!combo)
                {
                    order.Add(drink);
                }
                else
                {
                    Cretaceous.Drink = drink;
                }
                S_D_F.IsEnabled = false;
                L_LRFC.IsEnabled = true;
            }
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Soda_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                if (!combo)
                {
                    order.Add(drink);
                }
                else
                {
                    Cretaceous.Drink = drink;
                }
                L_LRFC.IsEnabled = false;
                S_D_F.IsEnabled = true;
            }
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Java_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                if (!combo)
                {
                    order.Add(drink);
                }
                else
                {
                    Cretaceous.Drink = drink;
                }
                S_D_F.IsEnabled = true;
                L_LRFC.IsEnabled = true;

            }
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                if (!combo)
                {
                    order.Add(drink);
                }
                else
                {
                    Cretaceous.Drink = drink;
                }
                S_D_F.IsEnabled = true;
                L_LRFC.IsEnabled = true;
            }
        }
        /// <summary>
        /// functionality for changng the size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChangeSize(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                if (combo)
                {
                    Cretaceous.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                }
            }

        }

        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomForCream_Lemon_Click(object sender, RoutedEventArgs e)
        {
            if (drink is JurassicJava java)
            {
                if (java.RoomForCream)
                {
                    java.RoomForCream = false;
                }
                else
                {
                    java.RoomForCream = true;
                }
            }
            if (drink is Water water)
            {
                if (water.Lemon)
                {
                    water.Lemon = false;
                }
                else
                {
                    water.Lemon = true;
                }
            }
            if (drink is Tyrannotea tea)
            {
                if (tea.Lemon)
                {
                    tea.Lemon = false;
                }
                else
                {
                    tea.Lemon = true;
                }
            }
            if (combo)
            {
                Cretaceous.Drink = drink;
            }
        }
        /// <summary>
        /// functionality for toggling if there is ice or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ice_Click(object sender, RoutedEventArgs e)
        {
            if (drink.Ice)
            {
                drink.Ice = false;
            }
            else {
                drink.Ice = true;
            }
            if (combo)
            {
                Cretaceous.Drink = drink;
            }
        }
        /// <summary>
        /// finishes the drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            if (!combo)
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
            else
            {
                NavigationService.Navigate(new ComboCustomization(Cretaceous));

            }
        }

    }
}

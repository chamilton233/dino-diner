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
using DinoDiner.Menu.Sides;
using DDSize =DinoDiner.Menu.Size;



namespace PointOfSale
{

    /// <summary>
    /// Interaction logic for SideSelcetion.xaml
    /// </summary>
    public partial class SideSelcetion : Page
    {
        /// <summary>
        /// the side currently being worked on
        /// </summary>
        private Side side;
        /// <summary>
        /// a combo in case this is part of a combo
        /// </summary>
        private CretaceousCombo Cretaceous;
        /// <summary>
        /// if it is part of a combo
        /// </summary>
        private bool combo =false;
        /// <summary>
        /// a constuctor where you pass in the side and set the starting one
        /// </summary>
        /// <param name="side"></param>
        public SideSelcetion(Side side)
        {
            InitializeComponent();
            this.side = side;
        }
        /// <summary>
        /// intializes this page
        /// </summary>
        public SideSelcetion()
        {
            InitializeComponent();
            side = new Fryceritops();
        }

        public SideSelcetion(CretaceousCombo cretaceousCombo)
        {
            InitializeComponent();
            combo = true;
            side = cretaceousCombo.Side;
            Cretaceous = cretaceousCombo;
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fry_click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                if (combo != true)
                {
                    order.Add(side);
                }
                else {
                    Cretaceous.Side = side;
                }
            }
        }
        /// <summary>
        /// functionality for switching the size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChangeSize(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                side.Size =(DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                if (combo != true)
                {
                    NavigationService.Navigate(new MenuCategorySelection());
                }
                else
                {
                    Cretaceous.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                    Cretaceous.Side = side;
                    NavigationService.Navigate(new ComboCustomization(Cretaceous));
                }
            }
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Metor_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                if (combo != true)
                {
                    order.Add(side);
                }
                else
                {
                    Cretaceous.Side = side;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mezzor_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                if (combo != true)
                {
                    order.Add(side);
                }
                else
                {
                    Cretaceous.Side = side;
                }
            }
        }
        /// <summary>
        /// functionality for adding the given thing to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tots_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                if (combo != true)
                {
                    order.Add(side);
                }
                else
                {
                    Cretaceous.Side = side;
                }
            }
        }
    }
}

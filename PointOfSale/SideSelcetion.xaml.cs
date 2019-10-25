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
using DinoDiner.Menu;
using DinoDiner.Menu.Sides;
using DDSize =DinoDiner.Menu.Size ;


namespace PointOfSale
{

    /// <summary>
    /// Interaction logic for SideSelcetion.xaml
    /// </summary>
    public partial class SideSelcetion : Page
    {
        private Side side;

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

        private void Fry_click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(side);
            }
        }

        private void OnChangeSize(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                side.Size =(DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString()); 
            }
        }

        private void Metor_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                order.Add(side);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(side);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                order.Add(side);
            }
        }
    }
}

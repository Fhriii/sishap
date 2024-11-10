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

namespace cobachart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new home());
    
            
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new about2());
        }private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new home());
        }private void Booking_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new booking());
        }

        private void Room_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new roommanagement());
        }
    }
}

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
    /// Interaction logic for booking.xaml
    /// </summary>
    public partial class booking : Page
    {
        public booking()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Akses MainWindow dan navigasi ke Page baru
            NavigationService?.Navigate(new payment());
            //var mainwindow = (MainWindow)Application.Current.MainWindow;
            //mainwindow.MainFrame.Navigate(new payment());
        }
    }
}

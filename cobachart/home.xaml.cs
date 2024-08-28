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
    /// Interaction logic for home.xaml
    /// </summary>
    public partial class home : Page
    {
        public home()
        {
            InitializeComponent();
            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30, Occupation = "Engineer" },
                new Person { Name = "Bob", Age = 25, Occupation = "Designer" },
                new Person { Name = "Charlie", Age = 35, Occupation = "Manager" }
            };

            // Mengatur DataContext untuk DataGrid
            myDataGrid.ItemsSource = people;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
    }
}


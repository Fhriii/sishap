using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public partial class booking : Page, INotifyPropertyChanged
    {
        private ObservableCollection<WorkspaceItem> _workspaceItems;
        public ObservableCollection<WorkspaceItem> WorkspaceItems
        {
            get => _workspaceItems;
            set
            {
                _workspaceItems = value;
                OnPropertyChanged(nameof(WorkspaceItems));
            }
        }

        public booking()
        {
            InitializeComponent();
            LoadWorkspaceItems();
            DataContext = this; // Set DataContext di sini
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Navigasi ke halaman payment
            NavigationService?.Navigate(new payment());
        }

        private void LoadWorkspaceItems()
        {
            WorkspaceItems = new ObservableCollection<WorkspaceItem>
            {
                new WorkspaceItem
                {
                    Title = "Semi Private Co-Working Space",
                    ImagePath = "/Images/downl.jpg",
                    Capacity = "4 persons",
                    Size = "15m²",
                    Floor = "1st floor",
                    HasWifi = true,
                    HasAC = true,
                    PricePerHour = 5
                },
                new WorkspaceItem
                {
                    Title = "Meeting room",
                    ImagePath = "/Images/downl.jpg",
                    Capacity = "8 persons",
                    Size = "25m²",
                    Floor = "2nd floor",
                    HasWifi = true,
                    HasAC = true,
                    PricePerHour = 15
                },
                new WorkspaceItem
                {
                    Title = "Desk",
                    ImagePath = "/Images/downl.jpg",
                    Capacity = "1 person",
                    Size = "5m²",
                    Floor = "1st floor",
                    HasWifi = true,
                    HasAC = true,
                    PricePerHour = 10
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

       
    }

    public class WorkspaceItem
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Capacity { get; set; }
        public string Size { get; set; }
        public string Floor { get; set; }
        public bool HasWifi { get; set; }
        public bool HasAC { get; set; }
        public decimal PricePerHour { get; set; }

        public string Description =>
            $"Capacity: {Capacity} • Size: {Size} • Floor: {Floor}" +
            $"{(HasWifi ? " • WiFi" : "")}{(HasAC ? " • Air conditioning" : "")}";

        public string Price => $"${PricePerHour}/Hour";
    }
}

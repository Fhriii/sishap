using System;
using System.Linq;
using System.Windows;


namespace cobachart
{
    
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            var authserv = new authService();

            // Dapatkan nilai kembalian berupa tuple (isLoggedIn, userId)
            var (isLoggedIn, userId) = await authserv.LoginAsync(userText.Text, passText.Text);

            if (isLoggedIn)
            {
                // Jika login berhasil, tampilkan ID user
                MessageBox.Show($"Login berhasil! User ID: {userId}");

                var mainwindow = new MainWindow();
                mainwindow.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ada yang salah");
            }
        }
    }
}

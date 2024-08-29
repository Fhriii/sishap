using System;
using System.Linq;
using System.Windows;
// Ganti dengan namespace yang sesuai dengan file .dbml Anda

namespace cobachart
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Buat instance konteks LINQ to SQL
                using (var db = new DataClasses1DataContext()) // Ganti dengan nama konteks LINQ to SQL Anda
                {
                    // Ambil username dari textbox
                    string userValue = userText.Text;

                    // Cari pengguna dengan username tersebut
                    var user = db.users.SingleOrDefault(u => u.username == userValue); // Ganti 'Users' dengan nama tabel di .dbml Anda

                    if (user != null)
                    {
                        // Bandingkan password
                        string passValue = passText.Text;
                        if (user.password == passValue) // Ini hanya jika password disimpan sebagai teks biasa
                        {
                            this.Hide();
                            var main = new MainWindow();
                            main.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Password Salah");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Salah");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}

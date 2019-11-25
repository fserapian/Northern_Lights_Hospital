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

namespace NLH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Focus on username
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Password;

            if (username.Equals("admin") && password.Equals("admin"))
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                Close();
            }
            else if (username.Equals("medecin") && password.Equals("medecin"))
            {
                MedecinWindow medecinWindow = new MedecinWindow();
                medecinWindow.Show();
                Close();
            }
            else if (username.Equals("prepose") && password.Equals("prepose"))
            {
                PreposeWindow preposeWindow = new PreposeWindow();
                preposeWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Username ou mot de passe incorrect !", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

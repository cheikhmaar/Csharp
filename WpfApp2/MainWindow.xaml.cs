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
using WpfApp2.Service;

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonConnexion_Click(object sender, RoutedEventArgs e)
        {
           IUser iuser = new UserRepository();
            utilisateur u = iuser.GetUtilisateur(TextBoxLogin.Text, PasswordBoxLogin.Password);
            if (u!=null)
            {
                MessageBox.Show("Bienvenue");
            }
            else
            {
                MessageBox.Show("Login ou password incorrect");
            }
        }
    }
}

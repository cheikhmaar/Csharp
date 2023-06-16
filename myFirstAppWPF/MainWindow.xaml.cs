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
using System.Data.SqlClient;

namespace myFirstAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonConnexion_Click(object sender, RoutedEventArgs e)
        {
          /*  SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.;Initial Catalog=coursDotNet;Integrated Security=True";
            cnx.Open();
            string sql = "Select * from utilisateur where username=@username and password=@pwd";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@username", TextBoxLogin.Text));
            cmd.Parameters.Add(new SqlParameter("@pwd", PasswordBoxLogin.Password));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bienvenue");
            }
            else
            {
                MessageBox.Show("Login ou password incorrect");
            }
            dr.Close();
            cmd.Dispose();
            cmd = null;
            cnx.Dispose();
            cnx.Close();*/

        }
    }
}

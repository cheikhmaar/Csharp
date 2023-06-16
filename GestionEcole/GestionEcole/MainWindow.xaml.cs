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

namespace GestionEcole
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

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = @"Data Source=MY-DESKTOP-MOUH\MSSQLSERVER01;Initial Catalog=Dotnet2;Integrated Security=True";
                cnx.Open();
                string sql = "insert into Promo(libelle,datedebut,datefin) values(@libelle,@datedebut,@datefin)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = sql;
                SqlParameter p1 = new SqlParameter("@libelle",libelle.Text);
                cmd.Parameters.Add(p1);
                SqlParameter p2 = new SqlParameter("@datedebut", datedebut.SelectedDate);
                cmd.Parameters.Add(p2);
                SqlParameter p3 = new SqlParameter("@datefin", datefin.SelectedDate);
                cmd.Parameters.Add(p3);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                MessageBox.Show("Promo Enregistrée ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

       
    }
}

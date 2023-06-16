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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace GestionEcole
{
    /// <summary>
    /// Logique d'interaction pour FormModule.xaml
    /// </summary>
    public partial class FormModule : Window
    {
        private BDContext db;
        public FormModule()
        {
            InitializeComponent();
            db = new BDContext();
            for(int i = 1; i<6; i++)
            {
                coef.Items.Add(i);
            }
        }
        
        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Module module = new Module();
                module.libelle = libelle.Text;
                module.coef = ((int)coef.SelectedItem);
                //module.coef = coef.SelectedItem.ToString();

                db.Module.Add(module);
                db.SaveChanges();
                MessageBox.Show("Module Enregistré ");
                libelle.Text = "";
                coef.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

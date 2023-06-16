using ExamenDotNet1.service;
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

namespace ExamenDotNet1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IParametre parametre;
        List<Ordinateur> ordinateurs;

        public MainWindow()
        {
            InitializeComponent();
            parametre = new ParametreRepository();
            ordinateurs = parametre.findAllOrdinateur();
            ordinateurDtg.ItemsSource = ordinateurs;
            List<Marque> marques = parametre.findAllMarque();
            marqueCbx.ItemsSource = marques;
            marqueCbx.DisplayMemberPath = "libelle";
            List<Os> os = parametre.findAllOs();
            osCbx.ItemsSource = os;
            osCbx.DisplayMemberPath = "libelle";
        }

        private bool verif()
        {
            if (refTbx.Text.Trim().Equals("") || ramTbx.Text.Trim().Equals("") ||
                disqueTbx.Text.Trim().Equals("") ||
                processeurTbx.Text.Trim().Equals("") ||
               marqueCbx.SelectedIndex == -1 || osCbx.SelectedIndex == -1)
            {
                MessageBox.Show("TOUS LES CHAMPS SONT OBLIGATOITES !");
                return false;
            }
            return true;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!verif())
            {
                return;
            }

            Ordinateur ordinateur = new Ordinateur();
            ordinateur.refOrdi = refTbx.Text.Trim();
            ordinateur.ram = ramTbx.Text.Trim();
            ordinateur.disque = disqueTbx.Text.Trim();
            ordinateur.processeur = processeurTbx.Text.Trim();            
            

            ordinateur.Marque = (Marque)marqueCbx.SelectedItem;
            ordinateur.Os = (Os)osCbx.SelectedItem;
            ordinateur = parametre.saveOrdinateur(ordinateur);
            MessageBox.Show("Ordinateur ajoutée !");
            Clear();
            ordinateurDtg.ItemsSource = parametre.findAllOrdinateur();

        }

        private void Clear()
        {
            refTbx.Text = "";
            ramTbx.Text = "";
            disqueTbx.Text = "";
            processeurTbx.Text = "";
            marqueCbx.SelectedIndex = -1;
            osCbx.SelectedIndex = -1;
        }
    }
}

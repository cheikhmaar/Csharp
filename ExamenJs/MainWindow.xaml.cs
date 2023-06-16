using ExamenJs.service;
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

namespace ExamenJs
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IParametre parametre;
        List<Cours> cours1; 
        public MainWindow()
        {
            InitializeComponent();
            parametre = new ParametreRepository();
            cours1 = parametre.findAllCours();
            List<Salle> salles = parametre.findAllSalle();
            salleCbx.ItemsSource = salles;
            salleCbx.DisplayMemberPath = "libelle";
            List<Matiere> matieres = parametre.findAllMatiere();
            matiereCbx.ItemsSource = matieres;
            matiereCbx.DisplayMemberPath = "libelle";

            joursCbx.Items.Add("Lundi");
            joursCbx.Items.Add("Mardi");
            joursCbx.Items.Add("Mercredi");
            joursCbx.Items.Add("Jeudi");
            joursCbx.Items.Add("Vendredi");
            joursCbx.Items.Add("Samedi");
            joursCbx.Items.Add("Vendredi");

        }

        private bool verif()
        {
            if(nomCoursTbx.Text.Trim().Equals("") || joursCbx.SelectedIndex == -1 ||
                heuredTbx.Text.Trim().Equals("") || heurefTbx.Text.Trim().Equals("") || coefTbx.Text.Trim().Equals("") ||
               salleCbx.SelectedIndex == -1 || matiereCbx.SelectedIndex == -1)
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

            Cours cours = new Cours();
            cours.nomCours = nomCoursTbx.Text.Trim();
            cours.jours = joursCbx.Text.Trim();
            cours.heureD = heuredTbx.Text.Trim();
            cours.heureF = heurefTbx.Text.Trim();
            try
            {
                cours.coef = int.Parse(coefTbx.Text.Trim());
            }
            catch (Exception)
            {

                MessageBox.Show("Coefficient non numérique !");
                return;
            }

            cours.Salle = (Salle)salleCbx.SelectedItem;
            cours.Matiere = (Matiere)matiereCbx.SelectedItem;
            cours = parametre.saveCours(cours);
            MessageBox.Show("Cours ajoutée !");
            Clear();

        }
        
        private void Clear()
        {
            nomCoursTbx.Text = "";
            joursCbx.SelectedIndex = -1;
            heuredTbx.Text = "";
            heurefTbx.Text = "";
            coefTbx.Text = "";
            salleCbx.SelectedIndex = -1;
            matiereCbx.SelectedIndex = -1;

        }
    }
}

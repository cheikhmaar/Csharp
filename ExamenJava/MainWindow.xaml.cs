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
using ExamenJava.service;

namespace ExamenJava
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IParametre parametre;
        private List<Personne> personnes;

        public MainWindow()
        {
            InitializeComponent();
            parametre = new ParametreRepository();
            personnes = parametre.findAllPersonne();
            List<Pays> pays = parametre.findAllPays();
            paysCbx.ItemsSource = pays;
            paysCbx.DisplayMemberPath = "libelle";
            List<Adresse> adresses = parametre.findAllAdresse();
            adresseCbx.ItemsSource = adresses;
            adresseCbx.DisplayMemberPath = "libelle1";
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(codeTbx.Text.Trim().Equals("") || nomTbx.Text.Trim().Equals("") || prenomTbx.Text.Trim().Equals("") ||
                emailTbx.Text.Trim().Equals("") || telTbx.Text.Trim().Equals("") || paysCbx.SelectedIndex == -1 ||
               adresseCbx.SelectedIndex == -1)
            {
                MessageBox.Show("TOUS LES CHAMPS SONT OBLIGATOIRES !");
                return;
            }

            Personne personne = new Personne();
            personne.code = codeTbx.Text.Trim();
            personne.nom = nomTbx.Text.Trim();
            personne.prenom = prenomTbx.Text.Trim();
            personne.email = emailTbx.Text.Trim();
            personne.tel = telTbx.Text.Trim();

            personne.Pays = (Pays)paysCbx.SelectedItem;
            personne.Adresse = (Adresse)adresseCbx.SelectedItem;

            personne = parametre.savePersonne(personne);
            MessageBox.Show("Classe ajoutée !");
            clear();
        }

        private void clear()
        {
            codeTbx.Text = "";
            nomTbx.Text = "";
            prenomTbx.Text = "";
            emailTbx.Text = "";
            telTbx.Text = "";
            paysCbx.SelectedIndex = -1;
            adresseCbx.SelectedIndex = -1;

        }
    }
}

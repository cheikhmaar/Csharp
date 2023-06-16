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
using Test.service;


namespace Test
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IParametre parametre;
        private List<Classe> classes;

        public MainWindow()
        {
            InitializeComponent();
            parametre = new ParametreRepository();
            classes = parametre.findAllClasse();
            ClasseDtg.ItemsSource = classes;
            List<Filiere> filiere = parametre.findAllFiliere();
            filiereCbx.ItemsSource = filiere;
            filiereCbx.DisplayMemberPath = "libelle";
        }

        private void SaveBnt_Click(object sender, RoutedEventArgs e)
        {
            if (codeTbx.Text.Trim().Equals("") || libelleTbx.Text.Trim().Equals("") ||
                fraisinscriptionTbx.Text.Trim().Equals("") || mensualiteTbx.Text.Trim().Equals("") ||
                filiereCbx.SelectedIndex == -1)
            {
                MessageBox.Show("Tous les champs sont obligatoires !");
                return;
            }

            Classe classe = new Classe();
            classe.code = codeTbx.Text.Trim();
            classe.libelle = libelleTbx.Text.Trim();

            try
            {
                classe.fraisinscription = int.Parse(fraisinscriptionTbx.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Frais d'inscription non numérique !");
                return;
            }
            try
            {
                classe.mensualite = int.Parse(mensualiteTbx.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Mensualite non numérique !");
                return;
            }

            classe.Filiere = (Filiere)filiereCbx.SelectedItem;

            classe = parametre.saveClasse(classe);
            MessageBox.Show("Classe ajoutée !");
            ClasseDtg.ItemsSource = parametre.findAllClasse();
        }
    }
}
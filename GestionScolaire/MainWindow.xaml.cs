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
using GestionScolaire.service;

namespace GestionScolaire
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
            classeDtg.ItemsSource = classes;
            List<Filiere> filiere = parametre.findAllFiliere();
            filiereCbx.ItemsSource = filiere;
            filiereCbx.DisplayMemberPath = "libelle";
            saveBtn.IsEnabled = false;
            updateBtn.IsEnabled = false;
            deleteBtn.IsEnabled = false;
        }

        private bool verif()
        {
            if (codeTbx.Text.Trim().Equals("") || libelleTbx.Text.Trim().Equals("") ||
                fraisinscriptionTbx.Text.Trim().Equals("") || mensualiteTbx.Text.Trim().Equals("") ||
                filiereCbx.SelectedIndex == -1)
            {
                MessageBox.Show("Tous les champs sont obligatoires !");
                return false;
            }
            return true;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!verif())
            {
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
            clear();
            classeDtg.ItemsSource = parametre.findAllClasse();
        }

        private void nouveauBtn_Click(object sender, RoutedEventArgs e)
        {
            saveBtn.IsEnabled = true;
            updateBtn.IsEnabled = false;
            deleteBtn.IsEnabled = false;
            classeDtg.SelectedIndex = -1;
            clear();
        }

        private void clear()
        {
            codeTbx.Text = "";
            libelleTbx.Text = "";
            fraisinscriptionTbx.Text = "";
            mensualiteTbx.Text = "";
            filiereCbx.SelectedIndex = -1;

        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            

        }

        Classe selectedClasse = null;
        private void classeDtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(classeDtg.SelectedIndex < classeDtg.Items.Count -1)
            {
                selectedClasse = (Classe)classeDtg.SelectedItem;
                if (selectedClasse != null)
                {
                    //MessageBox.Show(selectedClasse.libelle);
                    codeTbx.Text = selectedClasse.code;
                    libelleTbx.Text = selectedClasse.libelle;
                    fraisinscriptionTbx.Text = selectedClasse.fraisinscription+"";
                    mensualiteTbx.Text = selectedClasse.mensualite+ "";
                    filiereCbx.SelectedItem = selectedClasse.Filiere;

                }
                else
                {
                    MessageBox.Show(null);
                }
            }

            
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

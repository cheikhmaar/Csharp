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
using scolarite.service;

namespace scolarite
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IParametre parametre;
        private List<classe> classes;
        public MainWindow()
        {
            InitializeComponent();
            parametre = new ParametreRepository();
            classes = parametre.findAllClasse();
            classeDtg.ItemsSource = classes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(codeTbx.Text.Trim().Equals("") || libelleTbx.Text.Trim().Equals("") || 
                fraisinscriptionTbx.Text.Trim().Equals("") || mensualiteTbx.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tous les champs sont obligatoires !");
                return;
            }

            classe classe = new classe();
            classe.code = codeTbx.Text.Trim();
            classe.libelle = libelleTbx.Text.Trim();

            try
            {
                classe.fraisinscription = int.Parse(fraisinscriptionTbx.Text.Trim());
            }
            catch (Exception )
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

            
            classe = parametre.saveClasse(classe);
            MessageBox.Show("Classe ajoutée !");
            classeDtg.ItemsSource = parametre.findAllClasse();
        }
    }
}

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

namespace GestionEcole
{
    /// <summary>
    /// Logique d'interaction pour FormPromoModule.xaml
    /// </summary>
    public partial class FormPromoModule : Window
    {
        BDContext db;
        PromoModule promomodule;
     

        public FormPromoModule()
        {
            InitializeComponent();
            db = new BDContext();
            idPromo.ItemsSource = db.Promo.ToList();
            idPromo.DisplayMemberPath = "libelle";
            idModule.ItemsSource = db.Module.ToList();
            idModule.DisplayMemberPath = "libelle";

            for (int i = 2; i < 4; i++)
            {
                dureeseance.Items.Add(i);
            }
            for (int i = 10; i < 25; i=i+5)
            {
                nbseance.Items.Add(i);
            }
            jourseance.Items.Add("Lundi");
            jourseance.Items.Add("Mardi" );
            jourseance.Items.Add( "Mercredi");
            jourseance.Items.Add("Jeudi");
            jourseance.Items.Add("Vendredi");

            datefin.IsEnabled = false;
            datedebut.IsEnabled = false;
            coef.IsEnabled = false;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                promomodule = new PromoModule();
                promomodule.Module = ((Module)idModule.SelectedItem);
                promomodule.Promo = ((Promo)idPromo.SelectedItem);
                promomodule.idModule = ((Module)idModule.SelectedItem).idModule;
                promomodule.idPromo = ((Promo)idPromo.SelectedItem).idPromo;
                promomodule.nbseance = ((int)nbseance.SelectedItem);

                promomodule.dureeseance = ((int)dureeseance.SelectedItem);
                promomodule.jourseance = jourseance.Text;
                promomodule.notevalid = int.Parse(notevalid.Text);
                db.PromoModule.Add(promomodule);
                db.SaveChanges();
                MessageBox.Show("Programme Enregistré ");
                
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void idPromo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            datedebut.Text = ((Promo)idPromo.SelectedItem).datedebut.ToShortDateString ()+ "";
            datefin.Text = ((Promo)idPromo.SelectedItem).datefin.ToShortDateString()+"";
        }

        private void idModule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            coef.Text = ((Module)idModule.SelectedItem).coef + "";
        }
    }
}

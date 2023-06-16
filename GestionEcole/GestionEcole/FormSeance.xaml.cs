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
    /// Logique d'interaction pour FormSeance.xaml
    /// </summary>
    public partial class FormSeance : Window
    {
        private BDContext db;
        List<Seance> seances;
        PromoModule pm;
        public FormSeance()
        {
            InitializeComponent();
            db = new BDContext();
            idPromo.ItemsSource = db.Promo.ToList();
            idPromo.DisplayMemberPath = "libelle";
            seances =  new List<Seance>();
        }

        private void idPromo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Promo promo = (Promo)idPromo.SelectedItem;
            //List<PromoModule> promoModules = db.PromoModule.Where(pm => pm.idPromo == promo.idPromo).ToList();
            List<PromoModule> modules = (from pr in db.PromoModule
                           where pr.idPromo == promo.idPromo
                           select pr).ToList();
            idModule.ItemsSource = modules;
            idModule.DisplayMemberPath = "Module.libelle";
        }

        private void idModule_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             pm = (PromoModule)idModule.SelectedItem;

            jour.Text = pm.jourseance;
            duree.Text = pm.dureeseance+"";
            nbseance.Text = pm.nbseance+"";
            notevalid.Text = pm.notevalid+"";


        }

        private void ajouter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Seance s = new Seance();
                s.date = date.SelectedDate.Value;
                s.heuredebut = TimeSpan.Parse(heuredebut.Text);
                s.heurefin = TimeSpan.Parse(heurefin.Text);
                s.idPromoModule = pm.id;
                seances.Add(s);
                datagrid.Items.Add(s)  ;
                date.SelectedDate = DateTime.Now;
                heuredebut.Text = "";
                heurefin.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.Seance.AddRange(seances);
                db.SaveChanges();
                MessageBox.Show("Séance Enregistrée");
                seances = new List<Seance>();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

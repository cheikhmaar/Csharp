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
    /// Logique d'interaction pour FormApprenant.xaml
    /// </summary>
    public partial class FormApprenant : Window
    {
        private BDContext db;
        Apprenant apprenant ;
        public FormApprenant()
        {
            InitializeComponent();
            db = new BDContext();
            idPromo.ItemsSource = db.Promo.ToList();
            idPromo.DisplayMemberPath = "libelle";
            datagridApprenant.ItemsSource = db.Apprenant.ToList();
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //SqlConnection cnx = new SqlConnection();
                //cnx.ConnectionString = "Data Source=.;Initial Catalog=Dotnet2;Integrated Security=True";
                //cnx.Open();
                //string sql = "insert into Apprenant(matricule,nom,datenaissance,idPromo) values(@matricule,@nom,@datenaissance,@idPromo)";
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = cnx;
                //cmd.CommandText = sql;
                //SqlParameter p1 = new SqlParameter("@matricule", matricule.Text);
                //cmd.Parameters.Add(p1);
                //SqlParameter p2 = new SqlParameter("@nom", nom.Text);
                //cmd.Parameters.Add(p2);
                //SqlParameter p3 = new SqlParameter("@datenaissance", datenaissance.SelectedDate);
                //cmd.Parameters.Add(p3);

                //SqlParameter p4 = new SqlParameter("@idPromo", ((Promo)idPromo.SelectedItem).idPromo);
                //cmd.Parameters.Add(p4);

                //cmd.ExecuteNonQuery();
                //cmd.Parameters.Clear();
                apprenant = new Apprenant();
                apprenant.matricule = matricule.Text;
                setUpApprenant();
                //apprenant.Promo = (Promo)idPromo.SelectedItem;
                
                db.Apprenant.Add(apprenant);
                db.SaveChanges();
                initForm("Apprenant Enregistré");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void datagridApprenant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            if(datagridApprenant.SelectedIndex<datagridApprenant.Items.Count-1)
            {
               apprenant = (Apprenant)datagridApprenant.SelectedItem;
                if(apprenant !=null)
                {
           
                    matricule.Text = apprenant.matricule;
                    nom.Text = apprenant.nom;
                    datenaissance.SelectedDate = apprenant.datenaissance;
                    idPromo.SelectedItem = apprenant.Promo;
                    UpdateBtn.IsEnabled = true;
                    DeleteBtn.IsEnabled = true;
                    save.IsEnabled = false;
                }

            }
           
            
        }

      

        private void NouveauBtn_Click(object sender, RoutedEventArgs e)
        {
            matricule.Text = "";
            nom.Text = "";
            datenaissance.Text = "";
            idPromo.SelectedIndex = -1;
            UpdateBtn.IsEnabled = false;
            DeleteBtn.IsEnabled = false;
            save.IsEnabled = true;
            datagridApprenant.SelectedIndex = -1;
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            apprenant = db.Apprenant.Find(apprenant.id);
            setUpApprenant();
            db.SaveChanges();
            initForm("Apprenant Modifié");
            initButton();

        }
        private void setUpApprenant()
        {
            apprenant.nom = nom.Text;
            apprenant.datenaissance = datenaissance.SelectedDate.Value;
            apprenant.Promo = ((Promo)idPromo.SelectedItem);
            apprenant.idPromo = ((Promo)idPromo.SelectedItem).idPromo;
        }
        private void initForm(string msg)
        {
            MessageBox.Show(msg);
            matricule.Text = "";
            nom.Text = "";
            datenaissance.Text = "";
            idPromo.SelectedIndex = -1;
            datagridApprenant.ItemsSource = db.Apprenant.ToList();
        }
        private void initButton()
        {
            UpdateBtn.IsEnabled = false;
            DeleteBtn.IsEnabled = false;
            save.IsEnabled = true;
            datagridApprenant.SelectedIndex = -1;

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Etes-vous sur ?","Confirmation", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                try
                {
                    apprenant = db.Apprenant.Find(apprenant.id);
                    db.Apprenant.Remove(apprenant);
                    db.SaveChanges();
                    initForm("Apprenant Supprimé");
                    initButton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
    }
}

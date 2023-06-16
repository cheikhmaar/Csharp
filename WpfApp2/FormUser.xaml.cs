using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using WpfApp2.Service;

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour FormUser.xaml
    /// </summary>
    public partial class FormUser : Window
    {
        private IUser iuser;
        private List<utilisateur> users;
        private String Chemin = @"C:\Users\cheik\source\repos\WpfApp2\Images\admin.png";
        public FormUser()
        {
            InitializeComponent();
            ComboBoxProfil.DisplayMemberPath = "libelle";
            iuser = new UserRepository();
            users = iuser.FindAll();
            dataGridUsers.ItemsSource = users;
            IProfil iprofil = new ProfilRepository();
            List<profil> profils = iprofil.FindAll();
            ComboBoxProfil.ItemsSource = profils;
            LoadImage();
        }
        byte[] data = null;
        private void LoadImage()
        {
            data = null;
            ViewImage.Source = new BitmapImage(new Uri(Chemin));
            FileStream fs = new FileStream(Chemin,
            FileMode.Open, FileAccess.Read);
            data = new byte[fs.Length];
            fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
        }
        private bool PhotoChanged = false;
        private void ButtonChoixPhoto_Click(object sender, RoutedEventArgs e)
        {
            data = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Gestion des utilisateurs";
            dialog.Filter = "Fichiers image|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg|" +
                "Portable Network Graphic (*.png)|*.png";
            if (dialog.ShowDialog() == true)
            {
                PhotoChanged = true;
                ViewImage.Source = new BitmapImage(new Uri(dialog.FileName));
                FileStream fs = new FileStream(dialog.FileName,
                    FileMode.Open,FileAccess.Read);
                data = new byte[fs.Length];
                fs.Read(data, 0, System.Convert.ToInt32(fs.Length));
            }
        }

        private void ButtonEnregistrer_Click(object sender, RoutedEventArgs e)
        { 
            utilisateur user = new utilisateur();
            user.username = TextBoxUsername.Text;
            user.nomComplet = TextBoxNomComplet.Text;
            user.tel = TextBoxTelephone.Text;
            user.adresse = TextBoxAdresse.Text;
            user.profilId = ((profil)ComboBoxProfil.SelectedItem).id;
            user.profil = (profil)ComboBoxProfil.SelectedItem;
            user.photo = data;
            user.password = "passer";
            try
            {
                iuser.Save(user);
                
                MessageBox.Show("User saved ");
                LoadImage();
                Clear();
                dataGridUsers.ItemsSource = iuser.FindAll();
                PhotoChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :"+ ex.Message);
            }    
        }
        private void ActiveDesactiveBtn(bool active)
        {
            ButtonEnregistrer.IsEnabled = active;
            ButtonModifier.IsEnabled = !active;
            ButtonSupprimer.IsEnabled = !active;
        }
        private void ActiveDesactiveBtnEnregistrer(bool active)
        {
            ButtonEnregistrer.IsEnabled = !active;
            ButtonModifier.IsEnabled = active;
            ButtonSupprimer.IsEnabled = active;
        }
        private void ActiveDesactiveBtnAll(bool active)
        {
            ButtonEnregistrer.IsEnabled = active;
            ButtonModifier.IsEnabled = active;
            ButtonSupprimer.IsEnabled = active;
            ButtonNouveau.IsEnabled = active;
        }
        private void Clear()
        {
            TextBoxUsername.Text = "";
            TextBoxNomComplet.Text = "";
            TextBoxTelephone.Text = "";
            TextBoxAdresse.Text = "";
            ComboBoxProfil.SelectedIndex = -1;
        }
        private void Delete()
        {
            if (MessageBox.Show("Etes-vous sur de supprimer", "Delete Confirmation", MessageBoxButton.YesNo)==MessageBoxResult.Yes)
            {
                selectedUser = iuser.Find(selectedUser.id);
                BDContext.GetInstance().utilisateurs.Remove(selectedUser);
                BDContext.GetInstance().SaveChanges();
                ActiveDesactiveBtnAll(true);
            }
            else
            {
                System.Windows.MessageBox.Show("Delete operation Terminated");
            }
        }
        private void ButtonNouveau_Click(object sender, RoutedEventArgs e)
        {
            ActiveDesactiveBtn(true);
            Clear();
            dataGridUsers.SelectedIndex = -1;
            LoadImage();
            PhotoChanged = false;
        }
        private utilisateur selectedUser = null;
        private void dataGridUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dataGridUsers.SelectedIndex<dataGridUsers.Items.Count -1)
            selectedUser = (utilisateur)dataGridUsers.SelectedItem;
            if (selectedUser != null)
            {
                TextBoxUsername.Text = selectedUser.username;
                TextBoxNomComplet.Text = selectedUser.nomComplet;
                TextBoxTelephone.Text = selectedUser.tel;
                TextBoxAdresse.Text = selectedUser.adresse;
                ComboBoxProfil.SelectedItem = selectedUser.profil;
                if (selectedUser.photo != null)
                {
                    ViewImage.Source = Utilitaire.BitmapImageFromBytes(selectedUser.photo);
                }
                ActiveDesactiveBtnEnregistrer(true);
            }
        }

        private void ButtonModifier_Click(object sender, RoutedEventArgs e)
        {
            if (Verification())
            {
                MessageBox.Show("No Changes");
            }
            else
            {
                selectedUser = iuser.Find(selectedUser.id);
                selectedUser.username = TextBoxUsername.Text;
                selectedUser.nomComplet = TextBoxNomComplet.Text;
                selectedUser.tel = TextBoxTelephone.Text;
                selectedUser.adresse = TextBoxAdresse.Text;
                ComboBoxProfil.SelectedItem = selectedUser.profil;
                selectedUser.photo = data;
                BDContext.GetInstance().SaveChanges();
                ActiveDesactiveBtnAll(true);
            }
            LoadImage();
            Clear();
            dataGridUsers.ItemsSource = iuser.FindAll();
            PhotoChanged = false;
        }
        private bool Verification()
        {
            return TextBoxUsername.Text == selectedUser.username &&
                TextBoxNomComplet.Text == selectedUser.nomComplet
                && TextBoxTelephone.Text == selectedUser.tel &&
                TextBoxAdresse.Text == selectedUser.adresse &&
                ((profil)ComboBoxProfil.SelectedItem).id == selectedUser.profil.id &&
                !PhotoChanged;
            
        }

        private void ButtonSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Delete();
            LoadImage();
            Clear();
            dataGridUsers.ItemsSource = iuser.FindAll();
            PhotoChanged = false;
        }
    }
}

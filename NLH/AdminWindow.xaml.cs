using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace NLH
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();

            Clear();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {

            dataGridMedecins.Items.Clear();

            using (NLHContext context = new NLHContext())
            {
                context.Medecins.ToList().ForEach(medecin => dataGridMedecins.Items.Add(medecin));
            }
        }

        private void Clear()
        {
            txtPrenom.Text = txtNom.Text = txtSpecialite.Text = string.Empty;
            txtPrenom.Focus();
            btnAjouter.Content = "Ajouter";
            btnAjouter.Background = Brushes.MediumSeaGreen;
            btnSupprimer.IsEnabled = false;
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {

            using (NLHContext context = new NLHContext())
            {
                // validate if fields are empty
                if (txtPrenom.Text == string.Empty || txtNom.Text == string.Empty || txtSpecialite.Text == string.Empty)
                {
                    MessageBox.Show("Une ou plus des champs est vide", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if ((string)btnAjouter.Content == "Ajouter")
                {

                    Medecin medecin = new Medecin
                    {
                        Prenom = txtPrenom.Text.Trim(),
                        Nom = txtNom.Text.Trim(),
                        Specialite = txtSpecialite.Text.Trim()
                    };


                    context.Medecins.Add(medecin);

                    dataGridMedecins.Items.Add(medecin);

                    context.SaveChanges();

                    Clear();

                    MessageBox.Show("Nouveau médecin ajouté !", "Info", MessageBoxButton.OK, MessageBoxImage.Information);


                }
                else if ((string)btnAjouter.Content == "Modifier")
                {

                    var med = dataGridMedecins.SelectedItem as Medecin;

                    med.Prenom = txtPrenom.Text;
                    med.Nom = txtNom.Text;
                    med.Specialite = txtSpecialite.Text;

                    context.Entry(med).State = EntityState.Modified;

                    context.SaveChanges();

                    MessageBox.Show("Médecin modifié !", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

                    LoadDataGrid();
                }
            }

               

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void btnConsulter_Click(object sender, RoutedEventArgs e)
        {
            ConsultationWindow consultationWindow = new ConsultationWindow();
            consultationWindow.ShowDialog();
        }

        private void dataGridMedecins_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridMedecins.SelectedItem is Medecin medecin)
            {
                txtPrenom.Text = medecin.Prenom;
                txtNom.Text = medecin.Nom;
                txtSpecialite.Text = medecin.Specialite;
            }

            btnAjouter.Content = "Modifier";
            btnAjouter.Background = Brushes.DodgerBlue;
            btnSupprimer.IsEnabled = true;
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {

            using (NLHContext context = new NLHContext())
            {
                Medecin med = dataGridMedecins.SelectedItem as Medecin;
               
                var deleteMed = context.Medecins.Where(m => m.IdMedecin == med.IdMedecin).SingleOrDefault();

                var nbrDos = context.DossierAdmissions.Count(d => d.IdMedecin == deleteMed.IdMedecin);

                if (nbrDos > 0)
                {
                    MessageBox.Show("Ce médecin a déjà un patient", "Attention", MessageBoxButton.OK, MessageBoxImage.Warning);
                } 
                else
                {

                    MessageBoxResult messageBoxResult = MessageBox.Show("Êtes-vous sûr ?", "Confirmation de suppression", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (messageBoxResult == MessageBoxResult.Yes)
                    {
                        context.Medecins.Remove(deleteMed);

                        dataGridMedecins.Items.Remove(med);

                        context.SaveChanges();

                        Clear();

                        MessageBox.Show("Médecin supprimé !", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                }

               
            }
               
        }
    }
}

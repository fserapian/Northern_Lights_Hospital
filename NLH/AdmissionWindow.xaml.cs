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

namespace NLH
{
    /// <summary>
    /// Interaction logic for AdmissionWindow.xaml
    /// </summary>
    public partial class AdmissionWindow : Window
    {
        public AdmissionWindow()
        {
            InitializeComponent();

            ReadCompagnieAssurancesInCombo();
            ReadParentsInCombo();
        }

        private void ReadCompagnieAssurancesInCombo()
        {
            using (NLHContext context = new NLHContext())
            {
                comboAssurances.ItemsSource = context.CompagnieAssurances.Select(c => c.IdCompagnie + ") " + c.NomCompagnie).ToList();
            }
        }

        private void ReadParentsInCombo()
        {
            using (var context = new NLHContext())
            {
                comboParents.ItemsSource = context.Parents.Select(p => p.RefParent + ") " + p.Prenom + " " + p.Nom).ToList();
            }
        }

        private void btnSaveParent_Click(object sender, RoutedEventArgs e)
        {

            using (var context = new NLHContext())
            {
                var parent = new Parent
                {
                    Nom = txtNomPr.Text,
                    Prenom = txtPrenomPr.Text,
                    Adresse = txtAdressePr.Text,
                    Ville = txtVillePr.Text,
                    Province = txtProvincePr.Text,
                    CodePostal = txtCodePostalPr.Text,
                    Telephone = txtPhonePr.Text

                };

                context.Parents.Add(parent);
                context.SaveChanges();

                MessageBox.Show("Nouveau parent ajouté !", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnSavePatient_Click(object sender, RoutedEventArgs e)
        {
            string idComp = GetNumero(comboAssurances.Text);
            string refParent = GetNumero(comboParents.Text);


            using (var context = new NLHContext())
            {
                var patient = new Patient
                {
                    DateNaissance = datePickerBirthdate.SelectedDate,
                    Nom = txtNomPt.Text,
                    Prenom = txtPrenomPt.Text,
                    Adresse = txtAdressePt.Text,
                    Ville = txtVillePt.Text,
                    Province = txtProvincePt.Text,
                    CodePostal = txtCodePostalPt.Text,
                    Telephone = txtPhonePt.Text,
                    IdCompagnie = Convert.ToInt32(idComp),
                    RefParent = Convert.ToInt32(refParent)
                };

                context.Patients.Add(patient);
                context.SaveChanges();

                MessageBox.Show("Nouveau patient ajouté !", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private string GetNumero(string str)
        {
            string nss = string.Empty;
            foreach (char c in str)
            {
                if (c != ')')
                {
                    nss += c;

                }
                else
                {
                    break;
                }
            }
            return nss;
        }
    }
}
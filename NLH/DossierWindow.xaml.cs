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
    /// Interaction logic for DossierWindow.xaml
    /// </summary>
    public partial class DossierWindow : Window
    {
        public DossierWindow()
        {
            InitializeComponent();

            ReadNSSInCombo();
            ReadNumLitInCombo();
            ReadMedecinInCombo();
        }

        private void ReadNSSInCombo()
        {
            using (NLHContext context = new NLHContext())
            {
                var patients = context.Patients.ToList().Select(p => p.NSS + ") " + p.Prenom + " " + p.Nom);

                comboNSS.ItemsSource = patients;

            }
        }

        private void ReadNumLitInCombo()
        {
            using (NLHContext context = new NLHContext())
            {

                comboLit.ItemsSource = context.Lits.Where(l => l.Occupe == false).Select(l => l.NumLit).ToList();

            }
        }

        private void ReadMedecinInCombo()
        {
            using (NLHContext context = new NLHContext())
            {
                comboMedecin.ItemsSource = context.Medecins.Select(m => m.IdMedecin + ") " + m.Prenom + " " + m.Nom).ToList();
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {

            string nss = GetNumero(comboNSS.Text);
            string idMed = GetNumero(comboMedecin.Text);

            using (NLHContext context = new NLHContext())
            {
                DossierAdmission dossier = new DossierAdmission()
                {
                    Chirurgie = (bool)checkChirurgie.IsChecked,
                    NSS = Convert.ToInt32(nss),
                    DateAdmission = DateTime.Now,
                    NumLit = Convert.ToInt32(comboLit.Text),
                    IdMedecin = Convert.ToInt32(idMed)

                };

                context.DossierAdmissions.Add(dossier);

                context.SaveChanges();

                MessageBox.Show("Ajouter!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);

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

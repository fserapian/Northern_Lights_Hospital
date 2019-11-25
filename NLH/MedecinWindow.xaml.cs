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
    /// Interaction logic for MedecinWindow.xaml
    /// </summary>
    public partial class MedecinWindow : Window
    {
        public MedecinWindow()
        {
            InitializeComponent();

            ReadPatientsInCombo();
        }

        public void ReadPatientsInCombo()
        {
            using (NLHContext context = new NLHContext())
            {
                comboPatients.ItemsSource = context.DossierAdmissions.ToList();
            }
        }

        private void btnDonneConge_Click(object sender, RoutedEventArgs e)
        {
            using (NLHContext context = new NLHContext())
            {
                var idDossier = (comboPatients.SelectedItem as DossierAdmission).IdAdmission;

                var dos = context.DossierAdmissions.Include(d => d.Lit).Where(d => d.IdAdmission == idDossier).Single();

                dos.DateConge = DateTime.Now;
                dos.Lit.Occupe = false;

                context.Entry(dos).State = EntityState.Modified;

                context.SaveChanges();

                MessageBox.Show("Congé donné le " + dos.DateConge, "Info", MessageBoxButton.OK, MessageBoxImage.Information);

                MessageBox.Show("Lit " + dos.NumLit + " dans le département " + dos.Lit.IdDepartement + " est libéré !", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}

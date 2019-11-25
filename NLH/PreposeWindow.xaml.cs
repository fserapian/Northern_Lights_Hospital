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
    /// Interaction logic for PreposeWindow.xaml
    /// </summary>
    public partial class PreposeWindow : Window
    {
        public PreposeWindow()
        {
            InitializeComponent();

            LoadDossiersInGrid();
        }


        private void LoadDossiersInGrid()
        {

            using (NLHContext context = new NLHContext())
            {
                var results = context.DossierAdmissions.Join(context.Patients, d => d.NSS, p => p.NSS, (d, p) => new { d, p })
                                          .Join(context.Medecins, ds => ds.d.IdMedecin, m => m.IdMedecin, (ds, m) => new { ds, m })
                                          .Select(x => new
                                          {
                                              Dossier = x.ds.d,
                                              Patient = x.ds.p,
                                              Medecin = x.m
                                          });

                foreach (var r in results)
                {

                    gridDossiers.Items.Add(r);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            // clear datagrid
            gridDossiers.Items.Clear();

            using (NLHContext context = new NLHContext())
            {
                var filtered = context.DossierAdmissions
                                .Join(context.Patients, d => d.NSS, p => p.NSS, (d, p) => new { d, p })
                                .Join(context.Medecins, ds => ds.d.IdMedecin, m => m.IdMedecin, (ds, m) => new { ds, m })
                                .Select(x => new
                                {
                                    Dossier = x.ds.d,
                                    Patient = x.ds.p,
                                    Medecin = x.m,
                                })
                                .Where(elem => elem.Dossier.NSS.ToString().Contains(txtSearch.Text));


                foreach (var element in filtered)
                {

                    gridDossiers.Items.Add(element);
                }
            }
        }

        private void txtSearchName_TextChanged(object sender, TextChangedEventArgs e)
        {
            // clear datagrid
            gridDossiers.Items.Clear();

            using (NLHContext context = new NLHContext())
            {
                var filtered = context.DossierAdmissions
                                .Join(context.Patients, d => d.NSS, p => p.NSS, (d, p) => new { d, p })
                                .Join(context.Medecins, ds => ds.d.IdMedecin, m => m.IdMedecin, (ds, m) => new { ds, m })
                                .Select(x => new
                                {
                                    Dossier = x.ds.d,
                                    Patient = x.ds.p,
                                    Medecin = x.m,
                                })
                                .Where(elem => elem.Patient.Nom.Contains(txtSearchName.Text) || elem.Patient.Prenom.Contains(txtSearchName.Text));


                foreach (var element in filtered)
                {
                    gridDossiers.Items.Add(element);
                }
            }
        }

        private void txtSearchMed_TextChanged(object sender, TextChangedEventArgs e)
        {
            // clear datagrid
            gridDossiers.Items.Clear();

            using (NLHContext context = new NLHContext())
            {
                var filtered = context.DossierAdmissions
                                .Join(context.Patients, d => d.NSS, p => p.NSS, (d, p) => new { d, p })
                                .Join(context.Medecins, ds => ds.d.IdMedecin, m => m.IdMedecin, (ds, m) => new { ds, m })
                                .Select(x => new
                                {
                                    Dossier = x.ds.d,
                                    Patient = x.ds.p,
                                    Medecin = x.m,
                                })
                                .Where(elem => elem.Medecin.Nom.Contains(txtSearchMed.Text) || elem.Medecin.Prenom.Contains(txtSearchMed.Text));


                foreach (var element in filtered)
                {

                    gridDossiers.Items.Add(element);
                }

            }
        }

        private void btnEnregistrer_Click(object sender, RoutedEventArgs e)
        {

            AdmissionWindow admissionWindow = new AdmissionWindow();

            admissionWindow.ShowDialog();

        }

        private void btnAdmission_Click(object sender, RoutedEventArgs e)
        {
            DossierWindow dossierWindow = new DossierWindow();

            dossierWindow.ShowDialog();
        }
    }
}

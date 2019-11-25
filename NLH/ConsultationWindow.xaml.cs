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
    /// Interaction logic for ConsultationWindow.xaml
    /// </summary>
    public partial class ConsultationWindow : Window
    {
        public ConsultationWindow()
        {
            InitializeComponent();

            LoadPatientsInGrid();
        }

        private void LoadPatientsInGrid()
        {
            using (NLHContext context = new NLHContext())
            {

                var results = context.Patients.Join(context.CompagnieAssurances,
                                                        p => p.IdCompagnie,
                                                        c => c.IdCompagnie,
                                                        (p, c) => new { p, c })
                                                .Join(context.Parents,
                                                        pt => pt.p.RefParent,
                                                        pr => pr.RefParent,
                                                        (pt, pr) => new { pt, pr })
                                                .Select(x => new
                                                {
                                                    Patient = x.pt.p,
                                                    CompanyName = x.pt.c.NomCompagnie,
                                                    Parent = x.pr
                                                });




                foreach (var patient in results)
                {
                    dataGridPatients.Items.Add(patient);
                }

            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

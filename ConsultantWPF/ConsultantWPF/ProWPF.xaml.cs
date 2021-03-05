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

namespace ConsultantWPF
{
    /// <summary>
    /// Interaction logic for ProWPF.xaml
    /// </summary>
    public partial class ProWPF : Window
    {
        public ProWPF()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ConsultantWPF.consultantDataSet consultantDataSet = ((ConsultantWPF.consultantDataSet)(this.FindResource("consultantDataSet")));
            // Load data into the table project. You can modify this code as needed.
            ConsultantWPF.consultantDataSetTableAdapters.projectTableAdapter consultantDataSetprojectTableAdapter = new ConsultantWPF.consultantDataSetTableAdapters.projectTableAdapter();
            consultantDataSetprojectTableAdapter.Fill(consultantDataSet.project);
            System.Windows.Data.CollectionViewSource projectViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("projectViewSource")));
            projectViewSource.View.MoveCurrentToFirst();
        }
    }
}

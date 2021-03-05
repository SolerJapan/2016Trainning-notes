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
    /// Interaction logic for DivForm.xaml
    /// </summary>
    public partial class DivForm : Window
    {
        public DivForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ConsultantWPF.consultantDataSet consultantDataSet = ((ConsultantWPF.consultantDataSet)(this.FindResource("consultantDataSet")));
            // Load data into the table division. You can modify this code as needed.
            ConsultantWPF.consultantDataSetTableAdapters.divisionTableAdapter consultantDataSetdivisionTableAdapter = new ConsultantWPF.consultantDataSetTableAdapters.divisionTableAdapter();
            consultantDataSetdivisionTableAdapter.Fill(consultantDataSet.division);
            System.Windows.Data.CollectionViewSource divisionViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("divisionViewSource")));
            divisionViewSource.View.MoveCurrentToFirst();
        }
    }
}

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
    /// Interaction logic for WorkonWPF.xaml
    /// </summary>
    public partial class WorkonWPF : Window
    {
        public WorkonWPF()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ConsultantWPF.consultantDataSet consultantDataSet = ((ConsultantWPF.consultantDataSet)(this.FindResource("consultantDataSet")));
            // Load data into the table workon. You can modify this code as needed.
            ConsultantWPF.consultantDataSetTableAdapters.workonTableAdapter consultantDataSetworkonTableAdapter = new ConsultantWPF.consultantDataSetTableAdapters.workonTableAdapter();
            consultantDataSetworkonTableAdapter.Fill(consultantDataSet.workon);
            System.Windows.Data.CollectionViewSource workonViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("workonViewSource")));
            workonViewSource.View.MoveCurrentToFirst();
        }
    }
}

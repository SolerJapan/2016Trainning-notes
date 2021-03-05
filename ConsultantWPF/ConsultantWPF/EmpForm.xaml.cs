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
    /// Interaction logic for EmpForm.xaml
    /// </summary>
    public partial class EmpForm : Window
    {
        public EmpForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ConsultantWPF.consultantDataSet consultantDataSet = ((ConsultantWPF.consultantDataSet)(this.FindResource("consultantDataSet")));
            // Load data into the table employee. You can modify this code as needed.
            ConsultantWPF.consultantDataSetTableAdapters.employeeTableAdapter consultantDataSetemployeeTableAdapter = new ConsultantWPF.consultantDataSetTableAdapters.employeeTableAdapter();
            consultantDataSetemployeeTableAdapter.Fill(consultantDataSet.employee);
            System.Windows.Data.CollectionViewSource employeeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeeViewSource")));
            employeeViewSource.View.MoveCurrentToFirst();
        }
    }
}

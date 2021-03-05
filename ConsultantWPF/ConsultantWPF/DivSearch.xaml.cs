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
    /// Interaction logic for DivSearch.xaml
    /// </summary>
    public partial class DivSearch : Window
    {
        private CollectionViewSource x = null;
        private CollectionViewSource y = null;

        public DivSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.x = (CollectionViewSource)FindResource("divisionViewSource");
            this.x.View.MoveCurrentToPrevious();
            if (this.x.View.IsCurrentBeforeFirst)
            {
                this.x.View.MoveCurrentToLast();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.y = (CollectionViewSource)FindResource("divisionViewSource");
            this.y.View.MoveCurrentToNext();
            if (this.y.View.IsCurrentAfterLast)
            {
                this.y.View.MoveCurrentToFirst();
            }
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

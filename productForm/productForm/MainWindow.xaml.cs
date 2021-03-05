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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace productForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int ID;
            if (Int32.TryParse(textbox1.Text, out ID))
            {
                try
                {
                    grdPrdoductDetails.DataContext = App.DBAccess.GetProduct(ID);
                }
                catch
                {
                    MessageBox.Show("Error contacting database or error accessing data files ");
                }
            }
            else
            {
                MessageBox.Show("invalid Product ID");
            }
        }
    }
}

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

namespace buildingString
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

        private void RunCode(object sender, RoutedEventArgs e)
        {
            string hello = "Hello";
            string x = Convert.ToString(txtInput.Text);
            hello += ", World";
            Output(hello);
        }

        private void Output(object value)
        {
            txtOutput.Text += value + Environment.NewLine;
        }

        private void ClearOut(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
        }
    }
}

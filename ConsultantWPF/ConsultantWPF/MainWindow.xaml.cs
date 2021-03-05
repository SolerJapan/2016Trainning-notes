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

namespace ConsultantWPF
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem consultantTLi = (ListBoxItem)this.Listbox1.SelectedItem;
            string consultantStr = consultantTLi.Content.ToString();

            Window popWin = null;
            bool bModal = false;

            switch (consultantStr)
            {
                case "EmpForm Table":
                    popWin = new EmpForm();
                    break;

                case "EmpForm Search":
                    popWin = new EmpSearch();
                    break;

                case "Division Table":
                    popWin = new DivForm();
                    break;

                case "Division Search":
                    popWin = new DivSearch();
                    break;

                case "Project Table":
                    popWin = new ProWPF();
                    break;

                case "Project Search":
                    popWin = new ProjectSearch();
                    break;

                case "WorkonSearch Table":
                    popWin = new WorkonWPF();
                    break;

                case "WorkonSearch Search":
                    popWin = new WorkonSearch();
                    break;
            }
            if (popWin != null)
            {
                if (bModal)
                {
                    popWin.ShowDialog();//show child win as model

                }



                else
                {
                    popWin.Show();//show child window as modeless


                }
            }
        }
         


        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] consultantStr = {"EmpForm Table",
                                      "Division Table",
                                      "Project Table",
                                      "WorkonSearch Table",
                                      "EmpForm Search",
                                      "Division Search",
                                      "Project Search",
                                      "WorkonSearch Search",
                                     };


            Array.Sort(consultantStr);
            ListBoxItem consultantTLi = null; //define an object 

            foreach(string cStr in consultantStr)
            {
                consultantTLi = new ListBoxItem();
                consultantTLi.Content = cStr;
                this.Listbox1.Items.Add(consultantTLi);
                // adds  employee table

            }
            this.Listbox1.SelectedIndex = 0;//select first item on list
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


//List class is a collection and defined in system.collections.generic namespace-->project-- using statement
namespace listCollection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            List<string> colors = new List<string>();

            colors.Add("Red");
            colors.Add("Yellow");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Pink");

            //retrieve items or elements in a list collection by using a for each loop
            foreach(string color in colors)
            {
                MessageBox.Show(color);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labels
{
    public partial class LabelTextBoxButtonTestForm : Form
    {
        public LabelTextBoxButtonTestForm()
        {
            InitializeComponent();
        }

        private void displayPaswwordButton_Click(object sender, EventArgs e)
        {
            displayPasswordLabel.Text = inputPasswordTextBox.Text;
        }
    }
}

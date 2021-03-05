using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_TesterProject
{
    public partial class testerPrj : Form
    {

        private Point m_oPointRad1;
        private Point m_oPointRad2;
        private Point m_oPointRad3;
        private Point m_oPointRad4;


        public testerPrj()
        {
            InitializeComponent();
            this.m_oPointRad1 = this.orad1.Location;
            this.m_oPointRad2 = this.orad2.Location;
            this.m_oPointRad3 = this.orad3.Location;
            this.m_oPointRad4 = this.orad4.Location;
        }

        private void testerPrj_Load(object sender, EventArgs e)
        {

        }
    }
}

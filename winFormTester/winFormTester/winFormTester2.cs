using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormTester
{
    public partial class winFormTester2 : Form
    {

        private Point m_oPointRad1;
        private Point m_oPointRad2;
        private Point m_oPointRad3;
        private Point m_oPointRad4;

        public winFormTester2()
        {
            InitializeComponent();
            this.m_oPointRad1 = this.oRad1.Location;
            this.m_oPointRad2 = this.oRad2.Location;
            this.m_oPointRad3 = this.oRad3.Location;
            this.m_oPointRad4 = this.oRad4.Location;
        }


        private void winFormTester_Load(object sender, EventArgs e)
        {


        }

    

        private void winFormTester2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDatabaseDataSet.QA' table. You can move, or remove it, as needed.
            this.qATableAdapter.Fill(this.testDatabaseDataSet.QA);
            // TODO: This line of code loads data into the 'testDataDataSet.QA' table. You can move, or remove it, as needed.
            //     this.qATableAdapter.Fill(this.testDataDataSet.QA);

        }

        private void qABindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.qABindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.testDatabaseDataSet);

            }
            catch (Exception oExc)
            {
                MessageBox.Show(oExc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void oTsBtnEdit_Click(object sender, EventArgs e)
        {
            tFormInput objFormInput = new tFormInput();
            objFormInput.m_iAskId = int.Parse(this.AskIdText.Text);
            objFormInput.ShowDialog(this);
        }

        private void oBtnCheck_Click(object sender, EventArgs e)
        {
            string oStr = "Congratulations, Correct";
            Color sColor = Color.BlueViolet;
            if (!this.oRad1.Checked)
            {
                oStr = " 不世界　です";
                sColor = Color.Red;
            }

            this.oLabCheck.Text = oStr;
            this.oLabCheck.ForeColor = sColor;
        }
    }
}

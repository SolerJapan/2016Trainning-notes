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
    public partial class tFormInput : Form
    {
        public int m_iAskId = 0;
        public tFormInput()
        {
            InitializeComponent();
        }

        private void tFormInput_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataDataSet1.QA' table. You can move, or remove it, as needed.
            this.qATableAdapter.Fill(this.testDataDataSet1.QA);

        }

        private void qABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try            {                this.Validate();                this.qABindingSource.EndEdit();                this.tableAdapterManager.UpdateAll(this.testDataDataSet1);            }            catch (Exception oExc)            {                MessageBox.Show(oExc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // int askId = Convert.ToInt32(askIdTextBox.Text);
            // string Ask = Convert.ToString(this.askIdTextBox.Text);
            // string Ans1 = Convert.ToString(this.ans1TextBox.Text);
            //string Ans2 = Convert.ToString(this.ans2TextBox.Text);
            //string Ans3 = Convert.ToString(this.ans3TextBox.Text);
            // string Ans4 = Convert.ToString(this.ans4TextBox.Text);
            //testDataDataSet1.QA.Rows.Add(askId, Ask, Ans1, Ans2, Ans3, Ans4);
        
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            askIdTextBox.Text = askTextBox.Text = ans1TextBox.Text = ans2TextBox.Text = ans3TextBox.Text = ans4TextBox.Text = "";
        }
    }
}

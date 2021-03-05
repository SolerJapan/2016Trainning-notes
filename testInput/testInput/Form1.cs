using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testInput
{
    public partial class tFormInput : Form
    {
        public tFormInput()
        {
            InitializeComponent();
        }

        private void tFormInput_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // TODO: This line of code loads data into the 'testDataDataSet.QA' table. You can move, or remove it, as needed.
            this.qATableAdapter.Fill(this.testDataDataSet.QA);
           


        }

        private void qABingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}

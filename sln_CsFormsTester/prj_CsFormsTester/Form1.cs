using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace prj_CsFormsTester
{
    public partial class Form1 : Form
    {
        private tDbcxt m_oDbcxt = null;
       // private int m_iCorrect = 0;
        private Dictionary<int, bool> m_oDictOIntBool = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.m_oDbcxt = new tDbcxt();
            this.m_oDbcxt.Testers.Load();           
            this.testerBindingSource.DataSource = this.m_oDbcxt.Testers.Local.ToBindingList();

            oRadAns1.Checked = oRadAns1.Checked = oRadAns1.Checked = oRadAns1.Checked = false;

            this.m_oDictOIntBool = new Dictionary<int, bool>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton[] aoRads = new RadioButton[]
                { this.oRadAns1, this.oRadAns2, this.oRadAns3, this.oRadAns4 };
            int iRadChoice = 0;
            foreach (RadioButton oRad in aoRads)
            {
                if (oRad.Checked)
                {
                    iRadChoice = int.Parse(oRad.Tag.ToString());
                    break;
                }
            }
            Tester oTester = this.testerBindingSource.Current as Tester;
            bool bCorrect = false;
            if (oTester != null)
            {
                bCorrect = (iRadChoice == oTester.Choice);
            }
            string oStrMag = bCorrect ? "Correct" : "Sorry,Try Again..."; 
            MessageBoxIcon eMsgIcon = bCorrect ? MessageBoxIcon.Information : MessageBoxIcon.Warning;
            MessageBox.Show(oStrMag, "Tester", MessageBoxButtons.OK, eMsgIcon);

            int iQuestionID = oTester.QuestionId;
            if(!this.m_oDictOIntBool.ContainsKey(iQuestionID))
            {
                this.m_oDictOIntBool.Add(iQuestionID, bCorrect);
            }
            else
            {
                this.m_oDictOIntBool[iQuestionID] = bCorrect;
            }

            int iCorrect = 0;
            int iCount = this.m_oDictOIntBool.Count;//this.testerBindingSource.Count;
            foreach(bool bVal in this.m_oDictOIntBool.Values)
            {
                if(bVal)
                {
                    iCorrect++;
                }
            }
            //this.m_iCorrect += bCorrect ? 1 : 0;
            string oStrTally = String.Format("{0} of {1} answered correctly ",iCorrect, iCount );
            this.oTsLabTally.Text = oStrTally;

           }
        private void NavButton_Click()
        {
            Point[] aoPoint = new Point[]
             { oRadAns1.Location, oRadAns2.Location, oRadAns3.Location, oRadAns4.Location };

            Random oRand = new Random();
            int iRand = 0;
            Point oPointTemp = default(Point);
            for (int iNdx = 0; iNdx < 4; iNdx++)
            {
                iRand = oRand.Next(0, 4);
                oPointTemp = aoPoint[iNdx];
                aoPoint[iNdx] = aoPoint[iRand];
                aoPoint[iRand] = oPointTemp;
            }
            oRadAns1.Location = aoPoint[0];
            oRadAns2.Location = aoPoint[1];
            oRadAns3.Location = aoPoint[2];
            oRadAns4.Location = aoPoint[3];

            oRadAns1.Checked = false;
            oRadAns2.Checked = false;
            oRadAns3.Checked = false;
            oRadAns4.Checked = false;

        }

        private void testerBindingSource_PositionChanged(object sender, EventArgs e)
        {
            this.NavButton_Click();
        }
    }
}

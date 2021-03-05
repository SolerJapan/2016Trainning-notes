using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonsTest
{
    public partial class radioButtonsTestForm : Form
    {
        public radioButtonsTestForm()
        {
            InitializeComponent();
        }
        // variables that create user choice of system
        private MessageBoxIcon iconType1;
        private MessageBoxButtons buttonType1;
        // private void buttonType_Enter(object sender, EventArgs e)
        //{

        //}
       
        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == OKradioButton)// display ok button
            {
                buttonType1 = MessageBoxButtons.OK;

            }
            else if (sender == OkCancelradioButton)// display ok button
            {
                buttonType1 = MessageBoxButtons.OKCancel;

            }
            else if (sender == AbortRetryIgnoreRadioButton)// display ok button
            {
                buttonType1 = MessageBoxButtons.AbortRetryIgnore;

            }
            else if (sender == yesNoCancelRadioButton)// display ok button
            {
                buttonType1 = MessageBoxButtons.YesNoCancel;

            }
            else if (sender == yesNoRadioButton)// display ok button
            {
                buttonType1 = MessageBoxButtons.YesNo;

            }
            else
            {
                buttonType1 = MessageBoxButtons.RetryCancel;

            }
        }

        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == asteriskRadioButton)// display ok button
            {
                iconType1 = MessageBoxIcon.Asterisk;

            }
            else if (sender == errorRadioButton)// display ok button
            {
                iconType1 = MessageBoxIcon.Error;

            }
            else if (sender == exclaimationRadioButton)// display ok button
            {
                iconType1 = MessageBoxIcon.Exclamation;

            }
            else if (sender == handRadioButton)// display ok button
            {
                iconType1 = MessageBoxIcon.Hand;

            }
            else if (sender == informationRadioButton)// display ok button
            {
                iconType1 = MessageBoxIcon.None;

            }
            else if (sender == questionRadioButton)// display ok button
            {
                iconType1 = MessageBoxIcon.Question;

            }
            else if (sender == stopRadioButton)// display ok button
            {
                iconType1 = MessageBoxIcon.Stop;

            }
            else  // display ok button
            {
                iconType1 = MessageBoxIcon.Warning;

            }
          
        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            //Display MessageBox and store the value of the button presed
            //in other words, displaying a messagebox specified icon and button options
            DialogResult result = MessageBox.Show("This is your custom messageBox.", "Custom MessageBox", buttonType1, iconType1, 0, 0);

            switch (result)
            {
                case DialogResult.OK:
                    displayLabel.Text = "ok was pressed";
                    break;
                case DialogResult.Cancel:
                    displayLabel.Text = "Cancel was pressed";
                    break;
                case DialogResult.Abort:
                    displayLabel.Text = "Abort was pressed";
                    break;
                case DialogResult.Retry:
                    displayLabel.Text = "Retry was pressed";
                    break;
                case DialogResult.Ignore:
                    displayLabel.Text = "Ignore was pressed";
                    break;
                case DialogResult.Yes:
                    displayLabel.Text = "Yes was pressed";
                    break;
                case DialogResult.No:
                    displayLabel.Text = "No was pressed";
                    break;

            }

        }
    }
}

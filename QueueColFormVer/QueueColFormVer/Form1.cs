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

namespace QueueColFormVer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void QueueButton_Click(object sender, EventArgs e)
        {
            {
                Queue weekday = new Queue();

                weekday.Enqueue("Sunday");
                weekday.Enqueue("Monday");
                weekday.Enqueue("Tuesday");
                weekday.Enqueue("Wednesday");
                weekday.Enqueue("Thursday");
                weekday.Enqueue("Friday");
                weekday.Enqueue("Saturday");

                if (weekday.Contains("Tuesday"))
                {
                    MessageBox.Show("this queue contains tuesday");
                }
                else
                {
                    MessageBox.Show("this queue doesnt contain anything");
                }

                Console.WriteLine(weekday.Dequeue().ToString());

            }

        }
    }
}

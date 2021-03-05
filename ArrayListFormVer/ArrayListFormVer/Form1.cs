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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ArrayListButton_Click(object sender, EventArgs e)
        {
            {
                {
                    int i = 0;
                    //define an object through arrayList Class
                    ArrayList colors = new ArrayList();

                    colors.Add("Red");
                    colors.Add("green");
                    colors.Add("blue");
                    colors.Add("yellow");
                    colors.Add("purple");
                    colors.Add("Black");
                    colors.Add("White");

                    for (i = 0; i <= colors.Count - 1; i++)
                    {
                        MessageBox.Show(colors[i].ToString());
                    }

                }
            }
        }
    }
    }

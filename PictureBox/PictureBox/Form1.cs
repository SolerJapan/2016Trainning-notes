using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PictureBox
{
    //form to display different images when picturebox is clicked
    public partial class PictureBoxTestForm : Form
    {
        private int imageNum = -1;//determines which image is displayed
        string[] imageArray = new string[9];

    //    imageArray[0]="abc";
    //    imageArray[1]="def";

        
        //default constructor
        public PictureBoxTestForm()
        {
            InitializeComponent();
        }// end constructor
        //change image whenever next button is clicked
        private void nextButton_Click(object sender, EventArgs e)
        {
            imageNum = (imageNum + 1) % 3;
            //Retrieve image from resources and load into PictureBox
            //display an image from the projects resources
            //   imagePictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject
            //    (string.Format("image{0}", imageNum)));
            imagePictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject
                ("pic" + imageNum.ToString());

        }
    }
}

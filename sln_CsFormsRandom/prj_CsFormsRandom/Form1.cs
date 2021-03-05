using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_CsFormsRandom
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // seeded 

      Random oRndSeed1 = new Random( 123 );
      System.Threading.Thread.Sleep( 1000 );
      Random oRndSeed2 = new Random( 123 );

      int iSeed1 = oRndSeed1.Next( 0, 11 );  // min=inclusive, max=exclusive
      int iSeed2 = oRndSeed2.Next( 0, 11 );

      oTxtSeed1.Text = iSeed1.ToString();
      oTxtSeed2.Text = iSeed2.ToString();

      // unseeded 

      Random oRndUnseed1 = new Random();
      System.Threading.Thread.Sleep( 1000 );
      Random oRndUnseed2 = new Random();

      int iUnseed1 = oRndUnseed1.Next( 0, 11 );
      int iUnseed2 = oRndUnseed2.Next( 0, 11 );

      oTxtUnseed1.Text = iUnseed1.ToString();
      oTxtUnseed2.Text = iUnseed2.ToString();

      string oStrWithSeed1 = "";
      for( int iNdx = 0; iNdx < 10; iNdx++ )
      {
        oStrWithSeed1 += oRndSeed1.Next( 0, 11 ).ToString() + ", ";
      }

      string oStrWithSeed2 = "";
      for( int iNdx = 0; iNdx < 10; iNdx++ )
      {
        oStrWithSeed2 += oRndSeed2.Next( 0, 11 ).ToString() + ", ";
      }

      string oStrWithoutSeed1 = "";
      for( int iNdx = 0; iNdx < 10; iNdx++ )
      {
        oStrWithoutSeed1 += oRndUnseed1.Next( 0, 11 ).ToString() + ", ";
      }

      string oStrWithoutSeed2 = "";
      for( int iNdx = 0; iNdx < 10; iNdx++ )
      {
        oStrWithoutSeed2 += oRndUnseed2.Next( 0, 11 ).ToString() + ", ";
      }
      oTxtSeed1.Text = oStrWithSeed1;
      oTxtSeed2.Text = oStrWithSeed2;

      oTxtUnseed1.Text = oStrWithoutSeed1;
      oTxtUnseed2.Text = oStrWithoutSeed2;

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Point[] aoPoint = new Point[]
       { oLab1.Location, oLab2.Location, oLab3.Location, oLab4.Location };

      Random oRand = new Random();
      int iRand = 0; 
      Point oPointTemp = default( Point );  
      for( int iNdx = 0; iNdx < 4; iNdx++ )
      {
        iRand = oRand.Next( 0, 4 ); 
        oPointTemp = aoPoint[ iNdx ];
        aoPoint[ iNdx ] = aoPoint[ iRand ];
        aoPoint[ iRand ] = oPointTemp;
      }
      oLab1.Location = aoPoint[ 0 ];
      oLab2.Location = aoPoint[ 1 ];
      oLab3.Location = aoPoint[ 2 ];
      oLab4.Location = aoPoint[ 3 ];
    }
  }
}

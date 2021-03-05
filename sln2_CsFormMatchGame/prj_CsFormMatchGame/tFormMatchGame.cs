using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prj_CsFormMatchGame
{
  public partial class tFormMatchGame : Form
  {
    // fields
    private Random    m_oRand      = null;
    private List<int> m_oListOfInt = null;
    private Label     m_oLabClick1 = null;
    private Label     m_oLabClick2 = null;


    // ctor (default)
    public tFormMatchGame()
    {
      this.InitializeComponent();
    }


    // event handler (form is loaded and about to display on screen)
    private void tFormMatchGame_Load( object sender, EventArgs e )
    {
      this.m_oRand = new Random();

      this.vInitList();
      this.vInitCells();
    }


    // event handler (user clicked a cell label)
    private void oLab_Click( object sender, EventArgs e )
    {
      if( this.oTimer.Enabled )
      {
        return;
      }

      Label oLab = sender as Label;

      if( oLab != null )
      {
        if( oLab.ForeColor == oLab.BackColor )
        {
          oLab.ForeColor = SystemColors.ControlText;

          if( this.m_oLabClick1 == null )
          {
            this.m_oLabClick1 = oLab;
          }
          else if( this.m_oLabClick2 == null )
          {
            this.m_oLabClick2 = oLab;

            if( this.m_oLabClick1.Text == this.m_oLabClick2.Text )
            {
              this.m_oLabClick1 = null;
              this.m_oLabClick2 = null;

              this.bCheckWinner();
            }
            else
            {
              this.oTimer.Start();
            }
          }
        }
      }
    }


    // event handler (a timer interval has elapsed)
    private void oTimer_Tick( object sender, EventArgs e )
    {
      this.oTimer.Stop();
      
      this.m_oLabClick1.ForeColor = this.m_oLabClick1.BackColor;
      this.m_oLabClick2.ForeColor = this.m_oLabClick2.BackColor;

      this.m_oLabClick1 = null;
      this.m_oLabClick2 = null;
    }


    // utility method
    private void vInitList()
    {
      if( this.m_oListOfInt == null )
      {
        this.m_oListOfInt = new List<int>();
      }
      else
      {
        this.m_oListOfInt.Clear();
      }

      // note: for Webdings font symbols (non-Unicode) to show properly,
      // all cell labels must set these properties
      //   UseMnemonic FALSE
      //   UseCompatibleTextRendering TRUE
      
      //{ "!", "!", "N", "N", ",", ",", "k", "k", "b", "b", "v", "v", "w", "w", "z", "z" };

      int iVal = 0;

      while( this.m_oListOfInt.Count < 16 )
      {
        // Webdings font symbol values are valid from 0x21 (33) thru 0xFF (255)
        iVal = this.m_oRand.Next( 0x21, 0x100 );  // min=inclusive, max=exclusive

        if( iVal != 0xAD && ! this.m_oListOfInt.Contains( iVal ) )  // some PCs show 0xAD blank
        {
          this.m_oListOfInt.Add( iVal );
          this.m_oListOfInt.Add( iVal );
        }
      }
    }


    // utility method
    private void vInitCells()
    {
      int    iNdx  = 0;
      int    iVal = 0;
      char   cVal  = '0';
      string oStr  = null;
      Label  oLab  = null;

      foreach( Control oCtl in this.oTblLayPanel.Controls )
      {
        oLab = oCtl as Label;
        if( oLab != null )
        {
          iNdx = this.m_oRand.Next( 0, this.m_oListOfInt.Count );
          iVal = this.m_oListOfInt[ iNdx ];
          cVal = Convert.ToChar( iVal );
          oStr = cVal.ToString();
          this.m_oListOfInt.RemoveAt( iNdx );
          
          oLab.ForeColor = oLab.BackColor;
          oLab.Text = oStr;
          oLab.Tag  = iVal;
        }
      }
    }


    // utility method
    private bool bCheckWinner()
    {
      bool  bDone = true;
      Label oLab  = null;

      foreach( Control oCtl in this.oTblLayPanel.Controls )
      {
        oLab = oCtl as Label;

        if( oLab != null )
        {
          if( oLab.ForeColor == oLab.BackColor )
          {
            bDone = false;
            break;
          }
        }
      }

      if( bDone )
      {
        string oStrMsg = "Congratulations, you won!\n\nPlay another game?";

        DialogResult oDlgRes =  MessageBox.Show( oStrMsg, this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Information );

        if( oDlgRes == DialogResult.Yes )
        {
          this.vInitList();
          this.vInitCells();
        }
        else
        {
          this.Close();
        }
      }

      return bDone;
    }


  }
}

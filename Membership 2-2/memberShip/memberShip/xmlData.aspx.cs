using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace memberShip
{
    public partial class xmlData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String isbn = (String)GridView1.DataKeys[GridView1.SelectedIndex].Value;
            XmlDataSource2.XPath = String.Format("/bookstore/book[@ISBN='{0}']/comments/userComment", isbn);
            GridView2.Visible = true;
            DataList1.Visible = true;


        }


    }
}
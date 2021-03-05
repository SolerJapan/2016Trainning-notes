using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Membership_Ver2
{
    public partial class requestInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            nameTextbox.Text = companyTextbox.Text = phoneTextbox.Text = emailTextbox.Text = commentTextbox.Text = "";
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //create dictonary of parameters for inserting 
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            //add name,company, phone,email,services,and comment to  Dictionary of insert parameters
            parameters.Add("name", nameTextbox.Text);
            parameters.Add("company", companyTextbox.Text);
            parameters.Add("phone", phoneTextbox.Text);
            parameters.Add("email", emailTextbox.Text);
            parameters.Add("services", DropDownList1.SelectedValue);
            parameters.Add("comment", commentTextbox.Text);

            //Execute an insert Linq statement to add an new entry to requestData Table in request info database
            // requestdata datacontext class was generated  when dbml built
            LinqDataSource1.Insert(parameters);

            //clear the textboxes
            clearButton_Click(sender, e);
            //updare the gridview with the new database contents
            GridView1.DataBind();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace memberShip
{
    public partial class requestInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

           protected void submitButton_Click(object sender, EventArgs e)
        {
            //create dictionary of parameters for inserting
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            //Add name,company,phone, email,services, and comment to Dictionary of insert parameters
            parameters.Add("name", nameTextBox.Text);
            parameters.Add("company", companyTextBox.Text);
            parameters.Add("phone", phoneTextBox.Text);
            parameters.Add("email", emailTextBox.Text);
            parameters.Add("services", DropDownList1.SelectedValue);
            parameters.Add("comment", companyTextBox.Text);

            //Execute an insert Linq statement to add an new entry to the requestData table in requerstInfo Database
            //requestDataDataContext class was generated when dbml built
            LinqDataSource1.Insert(parameters);
            //Clear the TextBoxes
            clearButton_Click(sender, e);
            //Update teh GridView with the new database table contents
            GridView1.DataBind();



        }

        protected void clearButton_Click(object sender, EventArgs e)
        {

            nameTextBox.Text = companyTextBox.Text = phoneTextBox.Text = emailTextBox.Text = commentTextBox.Text = "";
        }
    }
}
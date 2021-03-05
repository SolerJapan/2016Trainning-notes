using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

// We try to use SQLConnection object o handle the part of physical communication between the C sharp and
//application and the SQL Server Database
namespace sqlServerConnection
{
    public partial class SQLServerConnectionTest : Form
    {
        public SQLServerConnectionTest()
        {
            InitializeComponent();
        }

        private void sqlServerButton_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection cnn;
            connectionString = "Data Source=.\\SSEXP2012;Initial Catalog=consultant;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            try
            {

                cnn.Open();
                MessageBox.Show("Connection Open!");
                cnn.Close();
            }

            catch(Exception )
            {
                MessageBox.Show("Cannot open connection!");

            }
        }
    }
}

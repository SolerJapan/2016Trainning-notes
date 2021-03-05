using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = null;
            SqlConnection cnn;
            connectionString = "Data Source=.\\SSEXP2012;Initial Catalog=consultant;Integrated Security=True";
            cnn = new SqlConnection(connectionString);

            try
            {

                cnn.Open();
                Console.WriteLine("Connection Open!");
                cnn.Close();
            }

            catch (Exception)
            {
                Console.WriteLine("Cannot open connection!");

            }
        }
    }
}

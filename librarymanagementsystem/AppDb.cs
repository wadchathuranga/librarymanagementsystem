using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementsystem
{
    public class AppDb
    {
        // connection
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=librarysystem;Integrated Security=True;Encrypt=False");


        // create function to get connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // create function to open connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }


        // create function to close connection
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

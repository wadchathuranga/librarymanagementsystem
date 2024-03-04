using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    public partial class IssueBooks : Form
    {
        // initialize the DB connection
        AppDb conn = new AppDb();

        public IssueBooks()
        {
            InitializeComponent();
        }

        private void findUserButton_Click(object sender, EventArgs e)
        {
            string userId = userIdTextBox.Text;

            conn.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserId = @UserId", conn.getConnection);
            cmd.Parameters.AddWithValue("@UserId", userId);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string userName = (string)reader["Name"];
            }
        }
    }
}

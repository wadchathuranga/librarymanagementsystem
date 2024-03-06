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
    public partial class ReturnBooks : Form
    {
        // initialize the DB connection
        AppDb conn = new AppDb();

        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void findUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = userIdTextBox.Text;

                conn.openConnection();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Users WHERE UserId = @UserId", conn.getConnection);
                cmd1.Parameters.AddWithValue("@UserId", userId);

                SqlDataReader reader = cmd1.ExecuteReader();

                // If data exists
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string userName = (string)reader["Name"];
                        string nic = (string)reader["NIC"];
                        string type = (string)reader["Type"];

                        userNameLabel.Text = userName;
                        nicLabel.Text = nic;
                        typeLabel.Text = type;
                    }
                    conn.closeConnection();

                    // GET CURRENT BORROWED BOOK DETAILS OF USER
                    findAllCurrentBorrowedBooks(userId);

                    // enable issue book text box & button
                    //bookIdTextBox.Enabled = true;
                    //bookIdTextBox.Focus();
                    //bookFindButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Data not found in the database.");
                }
                conn.closeConnection();
            }
            catch (Exception ex)
            {
                conn.closeConnection();
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // find all loaned out books by user
        private void findAllCurrentBorrowedBooks(string userId)
        {
            try
            {
                conn.openConnection();
                SqlCommand getCmd = new SqlCommand("SELECT * FROM IssueBooks WHERE UserId = @UserId", conn.getConnection);
                getCmd.Parameters.AddWithValue("@UserId", userId);
                SqlDataAdapter da = new SqlDataAdapter(getCmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["UserId"].Visible = false;
                conn.closeConnection();
            }
            catch (Exception ex)
            {
                conn.closeConnection();
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

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


        // when issue books loading
        private void IssueBooks_Load(object sender, EventArgs e)
        {
            bookIdTextBox.Enabled = false;
            bookIssueButton.Enabled = false;
        }


        // back button
        private void backButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }


        // find user button
        private void findUserButton_Click(object sender, EventArgs e)
        {
            string userId = userIdTextBox.Text;

            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserId = @UserId", conn.getConnection);
            cmd.Parameters.AddWithValue("@UserId", userId);

            try
            {
                conn.openConnection();
                SqlDataReader reader = cmd.ExecuteReader();

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

                    // enable issue book text box
                    bookIdTextBox.Enabled = true;
                    bookIdTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Data not found in the database.");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            conn.closeConnection();

            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    string userName = (string)reader["Name"];
            //    string nic = (string)reader["NIC"];
            //    string type = (string)reader["Type"];

            //    userNameLabel.Text = userName;
            //    nicLabel.Text = nic;
            //    typeLabel.Text = type; 
            //}
        }


        // find book button
        private void bookFindButton_Click(object sender, EventArgs e)
        {
            try
            {
                string bookId = bookIdTextBox.Text;
                
                conn.openConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE BookId = @BookId", conn.getConnection);
                cmd.Parameters.AddWithValue("@BookId", bookId);

                SqlDataReader reader = cmd.ExecuteReader();


                // If data exists
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string title = (string)reader["Title"];
                        string status = (string)reader["Status"];

                        bookTitleLabel.Text = title;
                        bookStatusLabel.Text = $"[{status}]";
                    }

                    // enable issue book text box
                    bookIssueButton.Enabled = true;
                    bookIdTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Book not found in the database.");
                }
                conn.closeConnection();
            }
            catch (Exception ex)
            {
                conn.closeConnection();
                MessageBox.Show("Error: " + ex.Message);

            }
        }


        // book issue button
        private void bookIssueButton_Click(object sender, EventArgs e)
        {
            //
        }
    }
}

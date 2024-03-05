﻿using System;
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
            bookFindButton.Enabled = false;

            // set issue date
            issueDateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd");

            // Add two weeks to the current date
            dueDateLabel.Text = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd");
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
            try
            {
                string userId = userIdTextBox.Text;

                conn.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserId = @UserId", conn.getConnection);
                cmd.Parameters.AddWithValue("@UserId", userId);

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

                    // GET CURRENT BORROWED BOOK DETAILS OF USER


                    // enable issue book text box & button
                    bookIdTextBox.Enabled = true;
                    bookIdTextBox.Focus();
                    bookFindButton.Enabled = true;

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

                    // enable issue book text box & button
                    bookIssueButton.Enabled = true;
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

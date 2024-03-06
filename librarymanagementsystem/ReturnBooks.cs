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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace librarymanagementsystem
{
    public partial class ReturnBooks : Form
    {
        // initialize the DB connection
        AppDb conn = new AppDb();

        // Declare variables to store data from the clicked row
        string bookId;
        string title;

        public ReturnBooks()
        {
            InitializeComponent();
        }


        // back button
        private void backButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
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


        // cell click method
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the clicked area is a cell and not a header or anything else
            if (e.RowIndex >= 0)
            {
                // Get data from the clicked row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string bookId = row.Cells["BookId"].Value.ToString();

                bookIdLabel.Text = bookId;
            }
        }


        // books return button
        private void returnBooksButton_Click(object sender, EventArgs e)
        {
            // update IssueBooks table


            // update book statu in Books table

        }
    }
}

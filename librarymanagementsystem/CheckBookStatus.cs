using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    public partial class CheckBookStatus : Form
    {
        // initialize the DB connection
        AppDb conn = new AppDb();

        public CheckBookStatus()
        {
            InitializeComponent();
        }

        private void CheckBookStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarysystemDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter1.Fill(this.librarysystemDataSet1.Books);

            bookIdRadioButton.Checked = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bool bookIdRadioBtn = bookIdRadioButton.Checked;
            bool otherRadioBtn = otherRadioButton.Checked;

            string bookIdText = bookIdSearchTextBox.Text;
            string otherSearchText = otherSearchTextBox.Text.ToString();


            if (bookIdRadioBtn) 
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE BookId = @BookId", conn.getConnection);
                cmd.Parameters.AddWithValue("@BookId", bookIdText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            } 
            
            else if (otherRadioBtn)
            {
                string query = "SELECT * FROM Books WHERE CONCAT(Title, Author) LIKE '%" + otherSearchText + "%'";
                SqlCommand cmd = new SqlCommand(query, conn.getConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            }  
             

            
        }

        private void bookIdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = true; // set button active
            otherSearchTextBox.Text = null; // text box clear
            otherSearchTextBox.Enabled = false; // set text box disable
            bookIdSearchTextBox.Enabled = true; // set text box active
        }

        private void otherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = false; // set button disable
            bookIdSearchTextBox.Text = null; // text box clear
            bookIdSearchTextBox.Enabled = false;// set text box disable
            otherSearchTextBox.Enabled = true; // set text box active
        }

        
    }
}

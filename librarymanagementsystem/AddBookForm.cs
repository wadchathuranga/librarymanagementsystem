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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace librarymanagementsystem
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            // initialized dropdown initial values
            statusComboBox.SelectedIndex = 0;
            copiesTextBox.Text = "0";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            // initialize the DB connection
            AppDb conn = new AppDb();

            // open DB connection
            conn.openConnection();

            // check book already exist
            SqlCommand bookExists = new SqlCommand("SELECT COUNT(*) FROM Books WHERE BookId = @BookId", conn.getConnection);
            bookExists.Parameters.AddWithValue("@BookId", bookIdTextBox.Text);
            int count = (int)bookExists.ExecuteScalar();

            // if book Id is already registered, program will not excute further
            if (count > 0) 
            {
                var result = MessageBox.Show("This book Id is already registered.", "Message");
                if (result == DialogResult.OK)
                {
                    return;
                }
            }

            //SqlDataReader reader = bookExists.ExecuteReader();

            //while (reader.Read())
            //{
            //    // Fetch data into variables
            //    int id = Convert.ToInt32(reader["Id"]);
            //    string name = reader["Title"].ToString();
            //    // Fetch other columns as needed

            //    // Use the fetched data
            //    Console.WriteLine($"ID: {id}, Name: {name}");
            //}

            // save book into db
            SqlCommand book = new SqlCommand("INSERT INTO Books VALUES (@Classification, @Title, @Publisher, @Status, @Author, @BookId)", conn.getConnection);
            book.Parameters.AddWithValue("@Classification", classificationTextBox.Text);
            book.Parameters.AddWithValue("@Title", titleTextBox.Text);
            book.Parameters.AddWithValue("@Publisher", publisherTextBox.Text);
            book.Parameters.AddWithValue("@Status", statusComboBox.SelectedItem.ToString());
            book.Parameters.AddWithValue("@Author", authorTextBox.Text);
            book.Parameters.AddWithValue("@BookId", bookIdTextBox.Text);
            book.ExecuteNonQuery();

            // get how many copies required
            int copies = Convert.ToInt32(copiesTextBox.Text);

            // check whether copies are available or not
            if (copies > 0)
            {
                // save book copies using loop
                for (int i = 1; i <= copies; i++)
                {
                    SqlCommand bookCopy = new SqlCommand("INSERT INTO Books VALUES (@Classification, @Title, @Publisher, @Status, @Author, @BookId)", conn.getConnection);
                    bookCopy.Parameters.AddWithValue("@Classification", classificationTextBox.Text);
                    bookCopy.Parameters.AddWithValue("@Title", titleTextBox.Text);
                    bookCopy.Parameters.AddWithValue("@Publisher", publisherTextBox.Text);
                    bookCopy.Parameters.AddWithValue("@Status", "Borrowable");
                    bookCopy.Parameters.AddWithValue("@Author", authorTextBox.Text);
                    bookCopy.Parameters.AddWithValue("@BookId", $"{bookIdTextBox.Text}{i}");
                    bookCopy.ExecuteNonQuery();
                }
            }

            // close db connection
            conn.closeConnection();

            // clear text boxes
            clearDataFields();
        }

        // validate copies count
        private void validateCopies(object sender, EventArgs e)
        {
            if (copiesTextBox.TextLength <= 0) {
                copiesTextBox.Text = "0";

            }
            
            if (int.Parse(copiesTextBox.Text) > 10) {
                copiesTextBox.Text = "10";
                MessageBox.Show("Should be less than 10.");

            }
        }

        // to clear fields
        private void clearDataFields()
        {
            classificationTextBox.Text = null;
            titleTextBox.Text = null;
            publisherTextBox.Text = null;
            statusComboBox.Text = null;
            authorTextBox.Text = null;
            bookIdTextBox.Text = null;
            copiesTextBox.Text = null;
        }
    }
}

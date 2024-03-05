using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagementsystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of AddUserForm
            AddUserForm addUserForm = new AddUserForm();

            // Show form
            addUserForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of AddBookForm
            AddBookForm addBookForm = new AddBookForm();

            // Show form
            addBookForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of CheckBookStatus
            CheckBookStatus checkBookStatus = new CheckBookStatus();

            // Show form
            checkBookStatus.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of IssueBooks
            IssueBooks issueBooks = new IssueBooks();

            // Show form
            issueBooks.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of ReturnBooks
            ReturnBooks returnBooks = new ReturnBooks();

            // Show form
            returnBooks.Show();
        }
    }
}

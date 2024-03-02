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

            // Show add user form
            addUserForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of AddBookForm
            AddBookForm addBookForm = new AddBookForm();

            // Show add user form
            addBookForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of CheckBookStatus
            CheckBookStatus checkBookStatus = new CheckBookStatus();

            // Show add user form
            checkBookStatus.Show();
        }
    }
}

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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace librarymanagementsystem
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            // initialized dropdown initial values
            sexComboBox.SelectedIndex = 0;
            typeComboBox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(userNameTextBox.Text)) { return; }
            //if (string.IsNullOrWhiteSpace(userIdTextBox.Text)) { return; }
            //if (string.IsNullOrWhiteSpace(nicTextBox.Text)) { return; }
            //if (string.IsNullOrWhiteSpace(addressTextBox.Text)) { return; }
            //if (sexComboBox.SelectedIndex == -1) { return; }
            //if (typeComboBox.SelectedIndex == -1) { return; }

            AppDb conn = new AppDb();
            conn.openConnection();
            SqlCommand cmd = new SqlCommand("insert into Users values (@Name, @UserId, @Sex, @Nic, @Address, @Type)", conn.getConnection);
            cmd.Parameters.AddWithValue("@Name", userNameTextBox.Text);
            cmd.Parameters.AddWithValue("@UserId", userIdTextBox.Text);
            cmd.Parameters.AddWithValue("@Sex", sexComboBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Nic", nicTextBox.Text);
            cmd.Parameters.AddWithValue("@Address", addressTextBox.Text);
            cmd.Parameters.AddWithValue("@Type", typeComboBox.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            conn.closeConnection();
            clearDataFields();
        }

        // to clear fields
        private void clearDataFields()
        {
            userNameTextBox.Text = null;
            userIdTextBox.Text = null;
            nicTextBox.Text = null;
            addressTextBox.Text = null;
            sexComboBox.Text = null;
            typeComboBox.Text = null;
        }
    }
}

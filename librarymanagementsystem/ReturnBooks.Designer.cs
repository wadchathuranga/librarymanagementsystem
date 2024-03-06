namespace librarymanagementsystem
{
    partial class ReturnBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.nicLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bookIdLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.returnBooksButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.todateDateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeLabel);
            this.groupBox1.Controls.Add(this.nicLabel);
            this.groupBox1.Controls.Add(this.userNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(37, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 96);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(25, 60);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(33, 16);
            this.typeLabel.TabIndex = 20;
            this.typeLabel.Text = "type";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nicLabel
            // 
            this.nicLabel.AutoSize = true;
            this.nicLabel.Location = new System.Drawing.Point(192, 29);
            this.nicLabel.Name = "nicLabel";
            this.nicLabel.Size = new System.Drawing.Size(45, 16);
            this.nicLabel.TabIndex = 19;
            this.nicLabel.Text = "nic no.";
            this.nicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(24, 29);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(67, 16);
            this.userNameLabel.TabIndex = 18;
            this.userNameLabel.Text = "username";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(124, 84);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(134, 22);
            this.userIdTextBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "User Id:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findUserButton
            // 
            this.findUserButton.Location = new System.Drawing.Point(264, 82);
            this.findUserButton.Name = "findUserButton";
            this.findUserButton.Size = new System.Drawing.Size(103, 28);
            this.findUserButton.TabIndex = 25;
            this.findUserButton.Text = "Find";
            this.findUserButton.UseVisualStyleBackColor = true;
            this.findUserButton.Click += new System.EventHandler(this.findUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Return Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 172);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(315, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "User\'s Loaned Out Books";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.todateDateLabel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bookIdLabel);
            this.groupBox2.Location = new System.Drawing.Point(411, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 85);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return Book Info";
            // 
            // bookIdLabel
            // 
            this.bookIdLabel.AutoSize = true;
            this.bookIdLabel.Location = new System.Drawing.Point(117, 29);
            this.bookIdLabel.Name = "bookIdLabel";
            this.bookIdLabel.Size = new System.Drawing.Size(53, 16);
            this.bookIdLabel.TabIndex = 16;
            this.bookIdLabel.Text = "book-id";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(411, 166);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(167, 46);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // returnBooksButton
            // 
            this.returnBooksButton.Location = new System.Drawing.Point(584, 166);
            this.returnBooksButton.Name = "returnBooksButton";
            this.returnBooksButton.Size = new System.Drawing.Size(195, 46);
            this.returnBooksButton.TabIndex = 31;
            this.returnBooksButton.Text = "Return Book";
            this.returnBooksButton.UseVisualStyleBackColor = true;
            this.returnBooksButton.Click += new System.EventHandler(this.returnBooksButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "BookId:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Return Date:";
            // 
            // todateDateLabel
            // 
            this.todateDateLabel.AutoSize = true;
            this.todateDateLabel.Location = new System.Drawing.Point(117, 53);
            this.todateDateLabel.Name = "todateDateLabel";
            this.todateDateLabel.Size = new System.Drawing.Size(90, 20);
            this.todateDateLabel.TabIndex = 24;
            this.todateDateLabel.Text = "today-date";
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnBooksButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findUserButton);
            this.Name = "ReturnBooks";
            this.Text = "ReturnBooks";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label nicLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label bookIdLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button returnBooksButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label todateDateLabel;
    }
}
namespace librarymanagementsystem
{
    partial class CheckBookStatus
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarysystemDataSet = new librarymanagementsystem.librarysystemDataSet();
            this.booksTableAdapter = new librarymanagementsystem.librarysystemDataSetTableAdapters.BooksTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.librarysystemDataSet1 = new librarymanagementsystem.librarysystemDataSet1();
            this.booksTableAdapter1 = new librarymanagementsystem.librarysystemDataSet1TableAdapters.BooksTableAdapter();
            this.bookIdSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.otherSearchTextBox = new System.Windows.Forms.TextBox();
            this.otherRadioButton = new System.Windows.Forms.RadioButton();
            this.bookIdRadioButton = new System.Windows.Forms.RadioButton();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarysystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarysystemDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.librarysystemDataSet;
            // 
            // librarysystemDataSet
            // 
            this.librarysystemDataSet.DataSetName = "librarysystemDataSet";
            this.librarysystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.bookIdDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn1,
            this.publisherDataGridViewTextBoxColumn1,
            this.classificationDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.booksBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(12, 146);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(776, 292);
            this.dataGridView3.TabIndex = 3;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.librarysystemDataSet1;
            // 
            // librarysystemDataSet1
            // 
            this.librarysystemDataSet1.DataSetName = "librarysystemDataSet1";
            this.librarysystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter1
            // 
            this.booksTableAdapter1.ClearBeforeFill = true;
            // 
            // bookIdSearchTextBox
            // 
            this.bookIdSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIdSearchTextBox.Location = new System.Drawing.Point(174, 30);
            this.bookIdSearchTextBox.Name = "bookIdSearchTextBox";
            this.bookIdSearchTextBox.Size = new System.Drawing.Size(185, 26);
            this.bookIdSearchTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(525, 59);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(156, 47);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.otherSearchTextBox);
            this.groupBox1.Controls.Add(this.otherRadioButton);
            this.groupBox1.Controls.Add(this.bookIdRadioButton);
            this.groupBox1.Controls.Add(this.bookIdSearchTextBox);
            this.groupBox1.Location = new System.Drawing.Point(80, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // otherSearchTextBox
            // 
            this.otherSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherSearchTextBox.Location = new System.Drawing.Point(174, 72);
            this.otherSearchTextBox.Name = "otherSearchTextBox";
            this.otherSearchTextBox.Size = new System.Drawing.Size(185, 26);
            this.otherSearchTextBox.TabIndex = 9;
            this.otherSearchTextBox.TextChanged += new System.EventHandler(this.searchButton_Click);
            // 
            // otherRadioButton
            // 
            this.otherRadioButton.AutoSize = true;
            this.otherRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherRadioButton.Location = new System.Drawing.Point(19, 70);
            this.otherRadioButton.Name = "otherRadioButton";
            this.otherRadioButton.Size = new System.Drawing.Size(136, 24);
            this.otherRadioButton.TabIndex = 8;
            this.otherRadioButton.TabStop = true;
            this.otherRadioButton.Text = "Title or Author";
            this.otherRadioButton.UseVisualStyleBackColor = true;
            this.otherRadioButton.CheckedChanged += new System.EventHandler(this.otherRadioButton_CheckedChanged);
            // 
            // bookIdRadioButton
            // 
            this.bookIdRadioButton.AutoSize = true;
            this.bookIdRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookIdRadioButton.Location = new System.Drawing.Point(19, 34);
            this.bookIdRadioButton.Name = "bookIdRadioButton";
            this.bookIdRadioButton.Size = new System.Drawing.Size(81, 24);
            this.bookIdRadioButton.TabIndex = 7;
            this.bookIdRadioButton.TabStop = true;
            this.bookIdRadioButton.Text = "BookId";
            this.bookIdRadioButton.UseVisualStyleBackColor = true;
            this.bookIdRadioButton.CheckedChanged += new System.EventHandler(this.bookIdRadioButton_CheckedChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bookIdDataGridViewTextBoxColumn1
            // 
            this.bookIdDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bookIdDataGridViewTextBoxColumn1.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn1.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bookIdDataGridViewTextBoxColumn1.Name = "bookIdDataGridViewTextBoxColumn1";
            this.bookIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bookIdDataGridViewTextBoxColumn1.Width = 79;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Width = 73;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn1.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn1
            // 
            this.authorDataGridViewTextBoxColumn1.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn1.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn1.Name = "authorDataGridViewTextBoxColumn1";
            this.authorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn1.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn1
            // 
            this.publisherDataGridViewTextBoxColumn1.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn1.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn1.Name = "publisherDataGridViewTextBoxColumn1";
            this.publisherDataGridViewTextBoxColumn1.ReadOnly = true;
            this.publisherDataGridViewTextBoxColumn1.Width = 125;
            // 
            // classificationDataGridViewTextBoxColumn1
            // 
            this.classificationDataGridViewTextBoxColumn1.DataPropertyName = "Classification";
            this.classificationDataGridViewTextBoxColumn1.HeaderText = "Classification";
            this.classificationDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.classificationDataGridViewTextBoxColumn1.Name = "classificationDataGridViewTextBoxColumn1";
            this.classificationDataGridViewTextBoxColumn1.ReadOnly = true;
            this.classificationDataGridViewTextBoxColumn1.Width = 125;
            // 
            // CheckBookStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Name = "CheckBookStatus";
            this.Text = "Check Book Status";
            this.Load += new System.EventHandler(this.CheckBookStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarysystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarysystemDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private librarysystemDataSet librarysystemDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private librarysystemDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private librarysystemDataSet1 librarysystemDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private librarysystemDataSet1TableAdapters.BooksTableAdapter booksTableAdapter1;
        private System.Windows.Forms.TextBox bookIdSearchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bookIdRadioButton;
        private System.Windows.Forms.RadioButton otherRadioButton;
        private System.Windows.Forms.TextBox otherSearchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classificationDataGridViewTextBoxColumn1;
    }
}
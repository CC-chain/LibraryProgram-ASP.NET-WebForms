
namespace LibraryProject
{
    partial class BorrowBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkBoxYear = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePickerYearMax = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerYearMin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBoxPublisher = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxISBN = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxPageMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPageMin = new System.Windows.Forms.TextBox();
            this.cmbBoxLanguage = new System.Windows.Forms.ComboBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BOOK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_YEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_STOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrow = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(209, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrow Book";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BOOK_ID,
            this.BOOK_TITLE,
            this.BOOK_ISBN,
            this.BOOK_YEAR,
            this.BOOK_STOCK,
            this.btnMore,
            this.btnBorrow});
            this.dataGridView1.Location = new System.Drawing.Point(54, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(549, 246);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chkBoxYear
            // 
            this.chkBoxYear.AutoSize = true;
            this.chkBoxYear.Location = new System.Drawing.Point(382, 122);
            this.chkBoxYear.Name = "chkBoxYear";
            this.chkBoxYear.Size = new System.Drawing.Size(15, 14);
            this.chkBoxYear.TabIndex = 38;
            this.chkBoxYear.UseVisualStyleBackColor = true;
            this.chkBoxYear.CheckedChanged += new System.EventHandler(this.chkBoxYear_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(59, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(538, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePickerYearMax
            // 
            this.dateTimePickerYearMax.Location = new System.Drawing.Point(481, 141);
            this.dateTimePickerYearMax.Name = "dateTimePickerYearMax";
            this.dateTimePickerYearMax.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerYearMax.TabIndex = 36;
            this.dateTimePickerYearMax.TabStop = false;
            this.dateTimePickerYearMax.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYearMax.ValueChanged += new System.EventHandler(this.dateTimePickerYearMax_ValueChanged);
            // 
            // dateTimePickerYearMin
            // 
            this.dateTimePickerYearMin.CustomFormat = "";
            this.dateTimePickerYearMin.Location = new System.Drawing.Point(337, 141);
            this.dateTimePickerYearMin.Name = "dateTimePickerYearMin";
            this.dateTimePickerYearMin.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerYearMin.TabIndex = 35;
            this.dateTimePickerYearMin.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYearMin.ValueChanged += new System.EventHandler(this.dateTimePickerYearMin_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(460, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(334, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "Year";
            // 
            // cmbBoxPublisher
            // 
            this.cmbBoxPublisher.FormattingEnabled = true;
            this.cmbBoxPublisher.Location = new System.Drawing.Point(197, 140);
            this.cmbBoxPublisher.Name = "cmbBoxPublisher";
            this.cmbBoxPublisher.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxPublisher.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(194, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "Publisher";
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(59, 140);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAuthor.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(56, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Author";
            // 
            // txtBoxISBN
            // 
            this.txtBoxISBN.Location = new System.Drawing.Point(497, 84);
            this.txtBoxISBN.Mask = "000-0-00-000000-0";
            this.txtBoxISBN.Name = "txtBoxISBN";
            this.txtBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.txtBoxISBN.TabIndex = 28;
            // 
            // txtBoxPageMax
            // 
            this.txtBoxPageMax.Location = new System.Drawing.Point(399, 84);
            this.txtBoxPageMax.Name = "txtBoxPageMax";
            this.txtBoxPageMax.Size = new System.Drawing.Size(38, 20);
            this.txtBoxPageMax.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(379, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "-";
            // 
            // txtBoxPageMin
            // 
            this.txtBoxPageMin.Location = new System.Drawing.Point(337, 83);
            this.txtBoxPageMin.Name = "txtBoxPageMin";
            this.txtBoxPageMin.Size = new System.Drawing.Size(38, 20);
            this.txtBoxPageMin.TabIndex = 25;
            // 
            // cmbBoxLanguage
            // 
            this.cmbBoxLanguage.FormattingEnabled = true;
            this.cmbBoxLanguage.Location = new System.Drawing.Point(197, 83);
            this.cmbBoxLanguage.Name = "cmbBoxLanguage";
            this.cmbBoxLanguage.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxLanguage.TabIndex = 24;
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(59, 83);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTitle.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(494, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 42;
            this.label5.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(334, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Number of Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(194, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Language";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(56, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Title";
            // 
            // BOOK_ID
            // 
            this.BOOK_ID.DataPropertyName = "BOOK_ID";
            this.BOOK_ID.HeaderText = "Id";
            this.BOOK_ID.Name = "BOOK_ID";
            this.BOOK_ID.Width = 41;
            // 
            // BOOK_TITLE
            // 
            this.BOOK_TITLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOOK_TITLE.DataPropertyName = "BOOK_TITLE";
            this.BOOK_TITLE.HeaderText = "Title";
            this.BOOK_TITLE.Name = "BOOK_TITLE";
            // 
            // BOOK_ISBN
            // 
            this.BOOK_ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BOOK_ISBN.DataPropertyName = "BOOK_ISBN";
            this.BOOK_ISBN.HeaderText = "ISBN";
            this.BOOK_ISBN.Name = "BOOK_ISBN";
            this.BOOK_ISBN.Width = 120;
            // 
            // BOOK_YEAR
            // 
            this.BOOK_YEAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BOOK_YEAR.DataPropertyName = "BOOK_YEAR";
            this.BOOK_YEAR.HeaderText = "Year";
            this.BOOK_YEAR.Name = "BOOK_YEAR";
            this.BOOK_YEAR.Width = 75;
            // 
            // BOOK_STOCK
            // 
            this.BOOK_STOCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BOOK_STOCK.DataPropertyName = "BOOK_STOCK";
            this.BOOK_STOCK.FillWeight = 40F;
            this.BOOK_STOCK.HeaderText = "Stock";
            this.BOOK_STOCK.Name = "BOOK_STOCK";
            this.BOOK_STOCK.Width = 50;
            // 
            // btnMore
            // 
            this.btnMore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnMore.HeaderText = "";
            this.btnMore.MinimumWidth = 50;
            this.btnMore.Name = "btnMore";
            this.btnMore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnMore.Text = "More..";
            this.btnMore.UseColumnTextForButtonValue = true;
            // 
            // btnBorrow
            // 
            this.btnBorrow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnBorrow.HeaderText = "";
            this.btnBorrow.MinimumWidth = 50;
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnBorrow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnBorrow.Text = "Borrow..";
            this.btnBorrow.UseColumnTextForButtonValue = true;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkBoxYear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePickerYearMax);
            this.Controls.Add(this.dateTimePickerYearMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBoxPublisher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxISBN);
            this.Controls.Add(this.txtBoxPageMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPageMin);
            this.Controls.Add(this.cmbBoxLanguage);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "BorrowBook";
            this.Size = new System.Drawing.Size(655, 496);
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkBoxYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerYearMax;
        private System.Windows.Forms.DateTimePicker dateTimePickerYearMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBoxPublisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtBoxISBN;
        private System.Windows.Forms.TextBox txtBoxPageMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPageMin;
        private System.Windows.Forms.ComboBox cmbBoxLanguage;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_YEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_STOCK;
        private System.Windows.Forms.DataGridViewButtonColumn btnMore;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrow;
    }
}

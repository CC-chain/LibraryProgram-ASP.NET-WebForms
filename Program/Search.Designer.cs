
namespace LibraryProject
{
    partial class Search
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
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBoxLanguage = new System.Windows.Forms.ComboBox();
            this.txtBoxPageMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPageMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxISBN = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBoxPublisher = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerYearMin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerYearMax = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnMore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkBoxYear = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(49, 49);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(184, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Language";
            // 
            // cmbBoxLanguage
            // 
            this.cmbBoxLanguage.FormattingEnabled = true;
            this.cmbBoxLanguage.Location = new System.Drawing.Point(187, 49);
            this.cmbBoxLanguage.Name = "cmbBoxLanguage";
            this.cmbBoxLanguage.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxLanguage.TabIndex = 3;
            // 
            // txtBoxPageMin
            // 
            this.txtBoxPageMin.Location = new System.Drawing.Point(327, 49);
            this.txtBoxPageMin.Name = "txtBoxPageMin";
            this.txtBoxPageMin.Size = new System.Drawing.Size(38, 20);
            this.txtBoxPageMin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(324, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Page";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(369, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "-";
            // 
            // txtBoxPageMax
            // 
            this.txtBoxPageMax.Location = new System.Drawing.Point(389, 50);
            this.txtBoxPageMax.Name = "txtBoxPageMax";
            this.txtBoxPageMax.Size = new System.Drawing.Size(38, 20);
            this.txtBoxPageMax.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(484, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "ISBN";
            // 
            // txtBoxISBN
            // 
            this.txtBoxISBN.Location = new System.Drawing.Point(487, 50);
            this.txtBoxISBN.Mask = "000-0-00-000000-0";
            this.txtBoxISBN.Name = "txtBoxISBN";
            this.txtBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.txtBoxISBN.TabIndex = 9;
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(49, 106);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAuthor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(46, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Author";
            // 
            // cmbBoxPublisher
            // 
            this.cmbBoxPublisher.FormattingEnabled = true;
            this.cmbBoxPublisher.Location = new System.Drawing.Point(187, 106);
            this.cmbBoxPublisher.Name = "cmbBoxPublisher";
            this.cmbBoxPublisher.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxPublisher.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(184, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Publisher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(450, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(324, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Year";
            // 
            // dateTimePickerYearMin
            // 
            this.dateTimePickerYearMin.CustomFormat = "";
            this.dateTimePickerYearMin.Location = new System.Drawing.Point(327, 107);
            this.dateTimePickerYearMin.Name = "dateTimePickerYearMin";
            this.dateTimePickerYearMin.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerYearMin.TabIndex = 18;
            this.dateTimePickerYearMin.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYearMin.ValueChanged += new System.EventHandler(this.dateTimePickerYearMin_ValueChanged);
            // 
            // dateTimePickerYearMax
            // 
            this.dateTimePickerYearMax.Location = new System.Drawing.Point(471, 107);
            this.dateTimePickerYearMax.Name = "dateTimePickerYearMax";
            this.dateTimePickerYearMax.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerYearMax.TabIndex = 19;
            this.dateTimePickerYearMax.TabStop = false;
            this.dateTimePickerYearMax.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYearMax.ValueChanged += new System.EventHandler(this.dateTimePickerYearMax_ValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnMore});
            this.dataGridView.Location = new System.Drawing.Point(49, 192);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(538, 250);
            this.dataGridView.TabIndex = 20;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnMore
            // 
            this.btnMore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnMore.HeaderText = "";
            this.btnMore.Name = "btnMore";
            this.btnMore.Text = "More..";
            this.btnMore.UseColumnTextForButtonValue = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(49, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(538, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkBoxYear
            // 
            this.chkBoxYear.AutoSize = true;
            this.chkBoxYear.Location = new System.Drawing.Point(372, 88);
            this.chkBoxYear.Name = "chkBoxYear";
            this.chkBoxYear.Size = new System.Drawing.Size(15, 14);
            this.chkBoxYear.TabIndex = 22;
            this.chkBoxYear.UseVisualStyleBackColor = true;
            this.chkBoxYear.CheckedChanged += new System.EventHandler(this.chkBoxYear_CheckedChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBoxYear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.dateTimePickerYearMax);
            this.Controls.Add(this.dateTimePickerYearMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBoxPublisher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxPageMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPageMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBoxLanguage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(655, 465);
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBoxLanguage;
        private System.Windows.Forms.TextBox txtBoxPageMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPageMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtBoxISBN;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBoxPublisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerYearMin;
        private System.Windows.Forms.DateTimePicker dateTimePickerYearMax;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkBoxYear;
        private System.Windows.Forms.DataGridViewButtonColumn btnMore;
    }
}

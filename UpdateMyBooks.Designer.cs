
namespace Library
{
    partial class UpdateMyBooks
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
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxAbstract = new System.Windows.Forms.RichTextBox();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.txtBoxAuthorName = new System.Windows.Forms.TextBox();
            this.txtBoxAuthotLastName = new System.Windows.Forms.TextBox();
            this.listBoxTopics = new System.Windows.Forms.ListBox();
            this.btnAddTopics = new System.Windows.Forms.Button();
            this.listBoxSelectedTopics = new System.Windows.Forms.ListBox();
            this.btnRemoveTopics = new System.Windows.Forms.Button();
            this.txtBoxBookPage = new System.Windows.Forms.TextBox();
            this.txtBoxYear = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookPage = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxISBN = new System.Windows.Forms.MaskedTextBox();
            this.pctrBoxBook = new System.Windows.Forms.PictureBox();
            this.errorProviderTitle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderISBN = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPublisher = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAbstract = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSelectedTopics = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderImage = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPage = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLanguage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderISBN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAbstract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSelectedTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(235, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "ISBN";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(378, 303);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLanguage.TabIndex = 62;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelect.Location = new System.Drawing.Point(189, 94);
            this.lblSelect.MaximumSize = new System.Drawing.Size(121, 12);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(101, 12);
            this.lblSelect.TabIndex = 72;
            this.lblSelect.Text = "Please choose image...";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(191, 68);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 47;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(72, 205);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(259, 20);
            this.txtBoxTitle.TabIndex = 48;
            // 
            // txtBoxAbstract
            // 
            this.txtBoxAbstract.Location = new System.Drawing.Point(72, 260);
            this.txtBoxAbstract.Name = "txtBoxAbstract";
            this.txtBoxAbstract.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtBoxAbstract.Size = new System.Drawing.Size(259, 83);
            this.txtBoxAbstract.TabIndex = 50;
            this.txtBoxAbstract.Text = "";
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(72, 380);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPublisher.TabIndex = 51;
            // 
            // txtBoxAuthorName
            // 
            this.txtBoxAuthorName.Location = new System.Drawing.Point(378, 72);
            this.txtBoxAuthorName.Name = "txtBoxAuthorName";
            this.txtBoxAuthorName.Size = new System.Drawing.Size(259, 20);
            this.txtBoxAuthorName.TabIndex = 54;
            // 
            // txtBoxAuthotLastName
            // 
            this.txtBoxAuthotLastName.Location = new System.Drawing.Point(378, 125);
            this.txtBoxAuthotLastName.Name = "txtBoxAuthotLastName";
            this.txtBoxAuthotLastName.Size = new System.Drawing.Size(259, 20);
            this.txtBoxAuthotLastName.TabIndex = 55;
            // 
            // listBoxTopics
            // 
            this.listBoxTopics.DisplayMember = "SUBTOP_ID";
            this.listBoxTopics.FormattingEnabled = true;
            this.listBoxTopics.Location = new System.Drawing.Point(378, 171);
            this.listBoxTopics.Name = "listBoxTopics";
            this.listBoxTopics.Size = new System.Drawing.Size(120, 69);
            this.listBoxTopics.TabIndex = 57;
            this.listBoxTopics.ValueMember = "SUBTOP_ID";
            // 
            // btnAddTopics
            // 
            this.btnAddTopics.Location = new System.Drawing.Point(378, 246);
            this.btnAddTopics.Name = "btnAddTopics";
            this.btnAddTopics.Size = new System.Drawing.Size(75, 23);
            this.btnAddTopics.TabIndex = 58;
            this.btnAddTopics.Text = "Add";
            this.btnAddTopics.UseVisualStyleBackColor = true;
            this.btnAddTopics.Click += new System.EventHandler(this.btnAddTopics_Click);
            // 
            // listBoxSelectedTopics
            // 
            this.listBoxSelectedTopics.FormattingEnabled = true;
            this.listBoxSelectedTopics.Location = new System.Drawing.Point(517, 171);
            this.listBoxSelectedTopics.Name = "listBoxSelectedTopics";
            this.listBoxSelectedTopics.Size = new System.Drawing.Size(120, 69);
            this.listBoxSelectedTopics.TabIndex = 60;
            // 
            // btnRemoveTopics
            // 
            this.btnRemoveTopics.Location = new System.Drawing.Point(517, 246);
            this.btnRemoveTopics.Name = "btnRemoveTopics";
            this.btnRemoveTopics.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTopics.TabIndex = 61;
            this.btnRemoveTopics.Text = "Remove";
            this.btnRemoveTopics.UseVisualStyleBackColor = true;
            this.btnRemoveTopics.Click += new System.EventHandler(this.btnRemoveTopics_Click);
            // 
            // txtBoxBookPage
            // 
            this.txtBoxBookPage.Location = new System.Drawing.Point(378, 354);
            this.txtBoxBookPage.Name = "txtBoxBookPage";
            this.txtBoxBookPage.Size = new System.Drawing.Size(43, 20);
            this.txtBoxBookPage.TabIndex = 64;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.Location = new System.Drawing.Point(507, 355);
            this.txtBoxYear.Mask = "00/00/0000";
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(64, 20);
            this.txtBoxYear.TabIndex = 65;
            this.txtBoxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxYear.ValidatingType = typeof(System.DateTime);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(45, 418);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(635, 26);
            this.btnUpdateBook.TabIndex = 66;
            this.btnUpdateBook.Text = "Update The Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(375, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 70;
            this.label8.Text = "Author Lastname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(375, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "Author Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(69, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 68;
            this.label9.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(504, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Year";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(353, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 320);
            this.label2.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Book Abstract";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(375, 152);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(56, 16);
            this.lblCategory.TabIndex = 56;
            this.lblCategory.Text = "Topics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(375, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Language";
            // 
            // lblBookPage
            // 
            this.lblBookPage.AutoSize = true;
            this.lblBookPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookPage.Location = new System.Drawing.Point(375, 335);
            this.lblBookPage.Name = "lblBookPage";
            this.lblBookPage.Size = new System.Drawing.Size(97, 16);
            this.lblBookPage.TabIndex = 49;
            this.lblBookPage.Text = "Book\'s Page";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.Location = new System.Drawing.Point(69, 186);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(79, 16);
            this.lblBookTitle.TabIndex = 46;
            this.lblBookTitle.Text = "Book Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(243, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 42);
            this.label1.TabIndex = 45;
            this.label1.Text = "Update Book";
            // 
            // txtBoxISBN
            // 
            this.txtBoxISBN.Location = new System.Drawing.Point(238, 381);
            this.txtBoxISBN.Mask = "000-0-00-000000-0";
            this.txtBoxISBN.Name = "txtBoxISBN";
            this.txtBoxISBN.Size = new System.Drawing.Size(100, 20);
            this.txtBoxISBN.TabIndex = 74;
            this.txtBoxISBN.ValidatingType = typeof(System.DateTime);
            // 
            // pctrBoxBook
            // 
            this.pctrBoxBook.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pctrBoxBook.Location = new System.Drawing.Point(72, 53);
            this.pctrBoxBook.Name = "pctrBoxBook";
            this.pctrBoxBook.Size = new System.Drawing.Size(100, 115);
            this.pctrBoxBook.TabIndex = 71;
            this.pctrBoxBook.TabStop = false;
            // 
            // errorProviderTitle
            // 
            this.errorProviderTitle.ContainerControl = this;
            // 
            // errorProviderISBN
            // 
            this.errorProviderISBN.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderISBN.ContainerControl = this;
            // 
            // errorProviderPublisher
            // 
            this.errorProviderPublisher.ContainerControl = this;
            // 
            // errorProviderAbstract
            // 
            this.errorProviderAbstract.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderSelectedTopics
            // 
            this.errorProviderSelectedTopics.ContainerControl = this;
            // 
            // errorProviderImage
            // 
            this.errorProviderImage.ContainerControl = this;
            // 
            // errorProviderYear
            // 
            this.errorProviderYear.ContainerControl = this;
            // 
            // errorProviderPage
            // 
            this.errorProviderPage.ContainerControl = this;
            // 
            // errorProviderLanguage
            // 
            this.errorProviderLanguage.ContainerControl = this;
            // 
            // UpdateMyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.txtBoxISBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pctrBoxBook);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtBoxAbstract);
            this.Controls.Add(this.comboBoxPublisher);
            this.Controls.Add(this.txtBoxAuthorName);
            this.Controls.Add(this.txtBoxAuthotLastName);
            this.Controls.Add(this.listBoxTopics);
            this.Controls.Add(this.btnAddTopics);
            this.Controls.Add(this.listBoxSelectedTopics);
            this.Controls.Add(this.btnRemoveTopics);
            this.Controls.Add(this.txtBoxBookPage);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBookPage);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMyBooks";
            this.Text = "UpdateMyBooks";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderISBN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAbstract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSelectedTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLanguage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pctrBoxBook;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.RichTextBox txtBoxAbstract;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.TextBox txtBoxAuthorName;
        private System.Windows.Forms.TextBox txtBoxAuthotLastName;
        private System.Windows.Forms.ListBox listBoxTopics;
        private System.Windows.Forms.Button btnAddTopics;
        private System.Windows.Forms.ListBox listBoxSelectedTopics;
        private System.Windows.Forms.Button btnRemoveTopics;
        private System.Windows.Forms.TextBox txtBoxBookPage;
        private System.Windows.Forms.MaskedTextBox txtBoxYear;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBookPage;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxISBN;
        private System.Windows.Forms.ErrorProvider errorProviderTitle;
        private System.Windows.Forms.ErrorProvider errorProviderISBN;
        private System.Windows.Forms.ErrorProvider errorProviderPublisher;
        private System.Windows.Forms.ErrorProvider errorProviderAbstract;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderSelectedTopics;
        private System.Windows.Forms.ErrorProvider errorProviderImage;
        private System.Windows.Forms.ErrorProvider errorProviderYear;
        private System.Windows.Forms.ErrorProvider errorProviderPage;
        private System.Windows.Forms.ErrorProvider errorProviderLanguage;
    }
}
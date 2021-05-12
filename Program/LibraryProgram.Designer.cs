
using System;

namespace Library
{
    partial class LibraryProgram
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnMenuMyProfile = new System.Windows.Forms.Button();
            this.linklblLogout = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnMenuSearch = new System.Windows.Forms.Button();
            this.btnMenuMyBooks = new System.Windows.Forms.Button();
            this.btnMenuAddPublisher = new System.Windows.Forms.Button();
            this.btnMenuAddBook = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lblValidation = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.admin = new Library.Admin();
            this.Publisher = new Library.AddPublisher();
            this.addBook = new Library.AddBook();
            this.myProfile = new Library.MyProfile();
            this.myBooks = new Library.MyBooks();
            this.publısherTableAdapter1 = new Library.LibrarySystemDataSetTableAdapters.PUBLISHERTableAdapter();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuMyProfile
            // 
            this.btnMenuMyProfile.Location = new System.Drawing.Point(16, 356);
            this.btnMenuMyProfile.Name = "btnMenuMyProfile";
            this.btnMenuMyProfile.Size = new System.Drawing.Size(116, 51);
            this.btnMenuMyProfile.TabIndex = 8;
            this.btnMenuMyProfile.Text = "My Profile";
            this.btnMenuMyProfile.UseVisualStyleBackColor = true;
            this.btnMenuMyProfile.Click += new System.EventHandler(this.buttonMyProfile_Click);
            // 
            // linklblLogout
            // 
            this.linklblLogout.AutoSize = true;
            this.linklblLogout.Location = new System.Drawing.Point(105, 7);
            this.linklblLogout.Name = "linklblLogout";
            this.linklblLogout.Size = new System.Drawing.Size(40, 13);
            this.linklblLogout.TabIndex = 29;
            this.linklblLogout.TabStop = true;
            this.linklblLogout.Text = "Logout";
            this.linklblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLogout_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Id:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 2);
            this.label1.TabIndex = 26;
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(146, 97);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(2, 333);
            this.lblLine.TabIndex = 25;
            // 
            // btnMenuSearch
            // 
            this.btnMenuSearch.Location = new System.Drawing.Point(16, 89);
            this.btnMenuSearch.Name = "btnMenuSearch";
            this.btnMenuSearch.Size = new System.Drawing.Size(116, 51);
            this.btnMenuSearch.TabIndex = 4;
            this.btnMenuSearch.Text = "Search";
            this.btnMenuSearch.UseVisualStyleBackColor = true;
            // 
            // btnMenuMyBooks
            // 
            this.btnMenuMyBooks.Location = new System.Drawing.Point(16, 299);
            this.btnMenuMyBooks.Name = "btnMenuMyBooks";
            this.btnMenuMyBooks.Size = new System.Drawing.Size(116, 51);
            this.btnMenuMyBooks.TabIndex = 7;
            this.btnMenuMyBooks.Text = "My Books";
            this.btnMenuMyBooks.UseVisualStyleBackColor = true;
            this.btnMenuMyBooks.Click += new System.EventHandler(this.buttonMyBooks_Click);
            // 
            // btnMenuAddPublisher
            // 
            this.btnMenuAddPublisher.Location = new System.Drawing.Point(16, 242);
            this.btnMenuAddPublisher.Name = "btnMenuAddPublisher";
            this.btnMenuAddPublisher.Size = new System.Drawing.Size(116, 51);
            this.btnMenuAddPublisher.TabIndex = 6;
            this.btnMenuAddPublisher.Text = "Add Publisher";
            this.btnMenuAddPublisher.UseVisualStyleBackColor = true;
            this.btnMenuAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // btnMenuAddBook
            // 
            this.btnMenuAddBook.Location = new System.Drawing.Point(16, 185);
            this.btnMenuAddBook.Name = "btnMenuAddBook";
            this.btnMenuAddBook.Size = new System.Drawing.Size(116, 51);
            this.btnMenuAddBook.TabIndex = 5;
            this.btnMenuAddBook.Text = "Add Book";
            this.btnMenuAddBook.UseVisualStyleBackColor = true;
            this.btnMenuAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(28, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 31;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(59, 42);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(0, 13);
            this.lblAccount.TabIndex = 32;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.lblValidation);
            this.panel.Controls.Add(this.btnLogin);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.User);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtBoxUser);
            this.panel.Controls.Add(this.txtBoxPassword);
            this.panel.Controls.Add(this.lblLogin);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(803, 496);
            this.panel.TabIndex = 33;
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(310, 90);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(188, 16);
            this.lblValidation.TabIndex = 16;
            this.lblValidation.Text = "User or Password is incorrect!!";
            this.lblValidation.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(298, 351);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 25);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(275, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.User.Location = new System.Drawing.Point(275, 130);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(57, 25);
            this.User.TabIndex = 13;
            this.User.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(277, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 12;
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxUser.Location = new System.Drawing.Point(280, 169);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(250, 31);
            this.txtBoxUser.TabIndex = 1;
            this.txtBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxUser_KeyDown);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxPassword.Location = new System.Drawing.Point(280, 271);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(250, 31);
            this.txtBoxPassword.TabIndex = 2;
            this.txtBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPassword_KeyDown);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLogin.Location = new System.Drawing.Point(319, 8);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(161, 55);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login ";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(15, 416);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(116, 51);
            this.btnAdmin.TabIndex = 36;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 60);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(32, 13);
            this.lbl.TabIndex = 34;
            this.lbl.Text = "Role:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(41, 60);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(0, 13);
            this.lblRole.TabIndex = 35;
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(159, 16);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(632, 430);
            this.admin.TabIndex = 37;
            // 
            // Publisher
            // 
            this.Publisher.Location = new System.Drawing.Point(154, 12);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(645, 447);
            this.Publisher.TabIndex = 10;
            // 
            // addBook
            // 
            this.addBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addBook.Location = new System.Drawing.Point(151, 12);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(648, 447);
            this.addBook.TabIndex = 12;
            // 
            // myProfile
            // 
            this.myProfile.Location = new System.Drawing.Point(152, 13);
            this.myProfile.Name = "myProfile";
            this.myProfile.Size = new System.Drawing.Size(640, 433);
            this.myProfile.TabIndex = 17;
            // 
            // myBooks
            // 
            this.myBooks.Location = new System.Drawing.Point(154, 13);
            this.myBooks.Name = "myBooks";
            this.myBooks.Size = new System.Drawing.Size(638, 446);
            this.myBooks.TabIndex = 17;
            // 
            // publısherTableAdapter1
            // 
            this.publısherTableAdapter1.ClearBeforeFill = true;
            // 
            // LibraryProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnMenuSearch);
            this.Controls.Add(this.btnMenuAddBook);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnMenuMyProfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnMenuMyBooks);
            this.Controls.Add(this.btnMenuAddPublisher);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.myProfile);
            this.Controls.Add(this.myBooks);
            this.Controls.Add(this.linklblLogout);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LibraryProgram";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AddBook addBook;
        private System.Windows.Forms.Button btnMenuMyProfile;
        private System.Windows.Forms.LinkLabel linklblLogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnMenuSearch;
        private System.Windows.Forms.Button btnMenuMyBooks;
        private System.Windows.Forms.Button btnMenuAddPublisher;
        private System.Windows.Forms.Button btnMenuAddBook;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAccount;
        private LibrarySystemDataSetTableAdapters.PUBLISHERTableAdapter publısherTableAdapter1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lblLogin;
        private MyProfile myProfile;
        private MyBooks myBooks;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnAdmin;
        private AddPublisher Publisher;
        private Admin admin;
    }
}


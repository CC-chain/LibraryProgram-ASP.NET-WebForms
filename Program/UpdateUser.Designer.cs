
namespace LibraryProject
{
    partial class UpdateUser
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.cmbBoxUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(133, 103);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(122, 20);
            this.txtBoxName.TabIndex = 34;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(264, 103);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(122, 20);
            this.txtBoxLastName.TabIndex = 36;
            // 
            // dateTimeBirthday
            // 
            this.dateTimeBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBirthday.Location = new System.Drawing.Point(133, 155);
            this.dateTimeBirthday.Name = "dateTimeBirthday";
            this.dateTimeBirthday.Size = new System.Drawing.Size(96, 20);
            this.dateTimeBirthday.TabIndex = 38;
            this.dateTimeBirthday.Value = new System.DateTime(2021, 3, 4, 0, 0, 0, 0);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.comboBoxGender.Location = new System.Drawing.Point(133, 209);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(96, 21);
            this.comboBoxGender.TabIndex = 39;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(133, 262);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(155, 20);
            this.txtBoxEmail.TabIndex = 42;
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(133, 316);
            this.txtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(99, 20);
            this.txtBoxPhoneNumber.TabIndex = 44;
            this.txtBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(27, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(424, 28);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(130, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(130, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(130, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(130, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(261, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Last Name";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.Location = new System.Drawing.Point(130, 84);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(49, 16);
            this.lblBookTitle.TabIndex = 33;
            this.lblBookTitle.Text = "Name";
            // 
            // cmbBoxUser
            // 
            this.cmbBoxUser.FormattingEnabled = true;
            this.cmbBoxUser.Location = new System.Drawing.Point(184, 44);
            this.cmbBoxUser.Name = "cmbBoxUser";
            this.cmbBoxUser.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxUser.TabIndex = 68;
            this.cmbBoxUser.SelectedIndexChanged += new System.EventHandler(this.cmbBoxUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "User";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 396);
            this.Controls.Add(this.cmbBoxUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.dateTimeBirthday);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBookTitle);
            this.Name = "UpdateUser";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.DateTimePicker dateTimeBirthday;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.MaskedTextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.ComboBox cmbBoxUser;
        private System.Windows.Forms.Label label1;
    }
}
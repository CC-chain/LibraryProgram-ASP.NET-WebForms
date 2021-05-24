
namespace LibraryProject
{
    partial class UpdatePublisher
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
            this.cmbBoxPublisher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBoxEstablish = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBoxPublisher
            // 
            this.cmbBoxPublisher.FormattingEnabled = true;
            this.cmbBoxPublisher.Location = new System.Drawing.Point(110, 37);
            this.cmbBoxPublisher.Name = "cmbBoxPublisher";
            this.cmbBoxPublisher.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxPublisher.TabIndex = 46;
            this.cmbBoxPublisher.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPublisher_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(127, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Publisher";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(83, 259);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(177, 113);
            this.txtBoxAddress.TabIndex = 52;
            this.txtBoxAddress.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Address";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(83, 156);
            this.txtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(82, 20);
            this.txtBoxPhoneNumber.TabIndex = 50;
            this.txtBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Telephone Number";
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.Location = new System.Drawing.Point(83, 101);
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(177, 20);
            this.txtBoxPublisher.TabIndex = 48;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.Location = new System.Drawing.Point(80, 82);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(73, 16);
            this.lblBookTitle.TabIndex = 47;
            this.lblBookTitle.Text = "Publisher";
            // 
            // txtBoxEstablish
            // 
            this.txtBoxEstablish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxEstablish.Location = new System.Drawing.Point(84, 203);
            this.txtBoxEstablish.Mask = "00/00/0000";
            this.txtBoxEstablish.Name = "txtBoxEstablish";
            this.txtBoxEstablish.Size = new System.Drawing.Size(101, 24);
            this.txtBoxEstablish.TabIndex = 54;
            this.txtBoxEstablish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEstablish.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(81, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Establish";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(47, 388);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(241, 23);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdatePublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 423);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxEstablish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxPublisher);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.cmbBoxPublisher);
            this.Controls.Add(this.label2);
            this.Name = "UpdatePublisher";
            this.Text = "UpdatePublisher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdatePublisher_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtBoxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPublisher;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.MaskedTextBox txtBoxEstablish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
    }
}
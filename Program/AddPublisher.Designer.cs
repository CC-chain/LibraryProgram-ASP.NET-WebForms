
namespace LibraryProject
{
    partial class AddPublisher
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
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxEstablish = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(205, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Publisher";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.Location = new System.Drawing.Point(65, 81);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(73, 16);
            this.lblBookTitle.TabIndex = 2;
            this.lblBookTitle.Text = "Publisher";
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.Location = new System.Drawing.Point(68, 100);
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(177, 20);
            this.txtBoxPublisher.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telephone Number";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(68, 160);
            this.txtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(82, 20);
            this.txtBoxPhoneNumber.TabIndex = 6;
            this.txtBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(68, 220);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(177, 113);
            this.txtBoxAddress.TabIndex = 8;
            this.txtBoxAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(346, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Establish";
            // 
            // txtBoxEstablish
            // 
            this.txtBoxEstablish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxEstablish.Location = new System.Drawing.Point(349, 101);
            this.txtBoxEstablish.Mask = "00/00/0000";
            this.txtBoxEstablish.Name = "txtBoxEstablish";
            this.txtBoxEstablish.Size = new System.Drawing.Size(101, 24);
            this.txtBoxEstablish.TabIndex = 31;
            this.txtBoxEstablish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEstablish.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(312, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 280);
            this.label4.TabIndex = 14;
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Location = new System.Drawing.Point(10, 382);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(620, 26);
            this.btnAddPublisher.TabIndex = 32;
            this.btnAddPublisher.Text = "Add The Publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // AddPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.txtBoxEstablish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPublisher);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label1);
            this.Name = "AddPublisher";
            this.Size = new System.Drawing.Size(640, 408);
            this.Load += new System.EventHandler(this.AddPublisher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtBoxPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtBoxAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtBoxEstablish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddPublisher;
    }
}

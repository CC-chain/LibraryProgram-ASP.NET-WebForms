
namespace LibraryProject
{
    partial class ReturnBook
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
            this.txtBoxCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxCVV = new System.Windows.Forms.MaskedTextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.errorProviderCardNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCVV = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCardNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCVV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number";
            // 
            // txtBoxCardNumber
            // 
            this.txtBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxCardNumber.Location = new System.Drawing.Point(23, 114);
            this.txtBoxCardNumber.Mask = "0000-0000-0000-0000";
            this.txtBoxCardNumber.Name = "txtBoxCardNumber";
            this.txtBoxCardNumber.Size = new System.Drawing.Size(133, 22);
            this.txtBoxCardNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expiration Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "MM/yy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(23, 185);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.ShowUpDown = true;
            this.dateTimePickerDate.Size = new System.Drawing.Size(57, 20);
            this.dateTimePickerDate.TabIndex = 3;
            this.dateTimePickerDate.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CVV";
            // 
            // txtBoxCVV
            // 
            this.txtBoxCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxCVV.Location = new System.Drawing.Point(23, 251);
            this.txtBoxCVV.Mask = "000";
            this.txtBoxCVV.Name = "txtBoxCVV";
            this.txtBoxCVV.Size = new System.Drawing.Size(26, 22);
            this.txtBoxCVV.TabIndex = 5;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(12, 300);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(173, 23);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay the Fine";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fine";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFine.ForeColor = System.Drawing.Color.Red;
            this.lblFine.Location = new System.Drawing.Point(23, 47);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(51, 16);
            this.lblFine.TabIndex = 8;
            this.lblFine.Text = "label5";
            // 
            // errorProviderCardNumber
            // 
            this.errorProviderCardNumber.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderCVV
            // 
            this.errorProviderCVV.ContainerControl = this;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 335);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtBoxCVV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxCardNumber);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCardNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtBoxCVV;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.ErrorProvider errorProviderCardNumber;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
        private System.Windows.Forms.ErrorProvider errorProviderCVV;
    }
}
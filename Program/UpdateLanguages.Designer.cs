
namespace Library
{
    partial class UpdateLanguages
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
            this.cmbBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbBoxLanguage
            // 
            this.cmbBoxLanguage.FormattingEnabled = true;
            this.cmbBoxLanguage.Location = new System.Drawing.Point(110, 55);
            this.cmbBoxLanguage.Name = "cmbBoxLanguage";
            this.cmbBoxLanguage.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxLanguage.TabIndex = 44;
            this.cmbBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLanguage_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(127, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Languages";
            // 
            // txtBoxUpdate
            // 
            this.txtBoxUpdate.Location = new System.Drawing.Point(216, 111);
            this.txtBoxUpdate.Name = "txtBoxUpdate";
            this.txtBoxUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUpdate.TabIndex = 45;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(229, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxAdd
            // 
            this.txtBoxAdd.Location = new System.Drawing.Point(36, 111);
            this.txtBoxAdd.Name = "txtBoxAdd";
            this.txtBoxAdd.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAdd.TabIndex = 47;
            // 
            // UpdateLanguages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 204);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxUpdate);
            this.Controls.Add(this.cmbBoxLanguage);
            this.Controls.Add(this.label2);
            this.Name = "UpdateLanguages";
            this.Text = "UpdateLanguages";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UpdateLanguages_FormClosed);
            this.Load += new System.EventHandler(this.UpdateLanguages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxAdd;
    }
}

namespace LibraryProject
{
    partial class UpdateTopics
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
            this.cmbBoxTopics = new System.Windows.Forms.ComboBox();
            this.Topics = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxAdd = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxUpdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbBoxTopics
            // 
            this.cmbBoxTopics.FormattingEnabled = true;
            this.cmbBoxTopics.Location = new System.Drawing.Point(100, 47);
            this.cmbBoxTopics.Name = "cmbBoxTopics";
            this.cmbBoxTopics.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxTopics.TabIndex = 67;
            this.cmbBoxTopics.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTopics_SelectedIndexChanged);
            // 
            // Topics
            // 
            this.Topics.AutoSize = true;
            this.Topics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Topics.Location = new System.Drawing.Point(129, 29);
            this.Topics.Name = "Topics";
            this.Topics.Size = new System.Drawing.Size(56, 16);
            this.Topics.TabIndex = 66;
            this.Topics.Text = "Topics";
            this.Topics.Click += new System.EventHandler(this.Topics_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxAdd
            // 
            this.txtBoxAdd.Location = new System.Drawing.Point(21, 104);
            this.txtBoxAdd.Name = "txtBoxAdd";
            this.txtBoxAdd.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAdd.TabIndex = 70;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(214, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 69;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxUpdate
            // 
            this.txtBoxUpdate.Location = new System.Drawing.Point(201, 104);
            this.txtBoxUpdate.Name = "txtBoxUpdate";
            this.txtBoxUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUpdate.TabIndex = 68;
            // 
            // UpdateTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 199);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxUpdate);
            this.Controls.Add(this.cmbBoxTopics);
            this.Controls.Add(this.Topics);
            this.Name = "UpdateTopics";
            this.Text = "UpdateTopics";
            this.Load += new System.EventHandler(this.UpdateTopics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxTopics;
        private System.Windows.Forms.Label Topics;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxUpdate;
    }
}
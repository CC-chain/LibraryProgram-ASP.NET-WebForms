
namespace LibraryProject
{
    partial class MyBooks
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
            this.BOOK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_EXPIRED_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReturn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(207, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BOOK_ID,
            this.BOOK_TITLE,
            this.BOOK_ISBN,
            this.BOOK_EXPIRED_DATE,
            this.btnMore,
            this.btnReturn});
            this.dataGridView1.Location = new System.Drawing.Point(36, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(549, 300);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating_1);
            // 
            // BOOK_ID
            // 
            this.BOOK_ID.DataPropertyName = "BOOK_ID";
            this.BOOK_ID.FillWeight = 30F;
            this.BOOK_ID.HeaderText = "ID";
            this.BOOK_ID.MinimumWidth = 15;
            this.BOOK_ID.Name = "BOOK_ID";
            this.BOOK_ID.Width = 43;
            // 
            // BOOK_TITLE
            // 
            this.BOOK_TITLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOOK_TITLE.DataPropertyName = "BOOK_TITLE";
            this.BOOK_TITLE.FillWeight = 30F;
            this.BOOK_TITLE.HeaderText = "Title";
            this.BOOK_TITLE.Name = "BOOK_TITLE";
            // 
            // BOOK_ISBN
            // 
            this.BOOK_ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOOK_ISBN.DataPropertyName = "BOOK_ISBN";
            this.BOOK_ISBN.HeaderText = "ISBN";
            this.BOOK_ISBN.Name = "BOOK_ISBN";
            // 
            // BOOK_EXPIRED_DATE
            // 
            this.BOOK_EXPIRED_DATE.DataPropertyName = "BOOK_EXPIRED_DATE";
            this.BOOK_EXPIRED_DATE.FillWeight = 80F;
            this.BOOK_EXPIRED_DATE.HeaderText = "Expired Date";
            this.BOOK_EXPIRED_DATE.Name = "BOOK_EXPIRED_DATE";
            this.BOOK_EXPIRED_DATE.Width = 93;
            // 
            // btnMore
            // 
            this.btnMore.FillWeight = 80F;
            this.btnMore.HeaderText = "";
            this.btnMore.MinimumWidth = 60;
            this.btnMore.Name = "btnMore";
            this.btnMore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnMore.Text = "More..";
            this.btnMore.UseColumnTextForButtonValue = true;
            this.btnMore.Width = 60;
            // 
            // btnReturn
            // 
            this.btnReturn.FillWeight = 80F;
            this.btnReturn.HeaderText = "";
            this.btnReturn.MinimumWidth = 60;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnReturn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnReturn.Text = "Return..";
            this.btnReturn.UseColumnTextForButtonValue = true;
            this.btnReturn.Width = 60;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(510, 364);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MyBooks";
            this.Size = new System.Drawing.Size(620, 408);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_EXPIRED_DATE;
        private System.Windows.Forms.DataGridViewButtonColumn btnMore;
        private System.Windows.Forms.DataGridViewButtonColumn btnReturn;
    }
}

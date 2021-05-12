
namespace Library
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.BOOK_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LANGUAGE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_PAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOK_YEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUBLISHER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BOOK_ID,
            this.BOOK_TITLE,
            this.LANGUAGE_NAME,
            this.BOOK_PAGE,
            this.BOOK_YEAR,
            this.PUBLISHER_NAME,
            this.btnMore,
            this.btnUpdate});
            this.dataGridView1.Location = new System.Drawing.Point(36, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(549, 300);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // BOOK_ID
            // 
            this.BOOK_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOOK_ID.DataPropertyName = "BOOK_ID";
            this.BOOK_ID.HeaderText = "ID";
            this.BOOK_ID.MinimumWidth = 15;
            this.BOOK_ID.Name = "BOOK_ID";
            // 
            // BOOK_TITLE
            // 
            this.BOOK_TITLE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOOK_TITLE.DataPropertyName = "BOOK_TITLE";
            this.BOOK_TITLE.HeaderText = "Title";
            this.BOOK_TITLE.Name = "BOOK_TITLE";
            // 
            // LANGUAGE_NAME
            // 
            this.LANGUAGE_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LANGUAGE_NAME.DataPropertyName = "LANGUAGE_NAME";
            this.LANGUAGE_NAME.HeaderText = "Language";
            this.LANGUAGE_NAME.Name = "LANGUAGE_NAME";
            // 
            // BOOK_PAGE
            // 
            this.BOOK_PAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOOK_PAGE.DataPropertyName = "BOOK_PAGE";
            this.BOOK_PAGE.HeaderText = "Page";
            this.BOOK_PAGE.Name = "BOOK_PAGE";
            // 
            // BOOK_YEAR
            // 
            this.BOOK_YEAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOOK_YEAR.DataPropertyName = "BOOK_YEAR";
            this.BOOK_YEAR.HeaderText = "Year";
            this.BOOK_YEAR.Name = "BOOK_YEAR";
            // 
            // PUBLISHER_NAME
            // 
            this.PUBLISHER_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PUBLISHER_NAME.DataPropertyName = "PUBLISHER_NAME";
            this.PUBLISHER_NAME.HeaderText = "Publisher";
            this.PUBLISHER_NAME.Name = "PUBLISHER_NAME";
            // 
            // btnMore
            // 
            this.btnMore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnMore.HeaderText = "";
            this.btnMore.MinimumWidth = 75;
            this.btnMore.Name = "btnMore";
            this.btnMore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnMore.Text = "More..";
            this.btnMore.UseColumnTextForButtonValue = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnUpdate.HeaderText = "";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseColumnTextForButtonValue = true;
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
            this.Load += new System.EventHandler(this.MyBooks_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn LANGUAGE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_PAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOK_YEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUBLISHER_NAME;
        private System.Windows.Forms.DataGridViewButtonColumn btnMore;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
    }
}

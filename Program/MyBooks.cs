using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class MyBooks : UserControl
    {


        public MyBooks()
        {
            InitializeComponent();
            
        }


    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                var id = dataGridView1.CurrentRow.Cells["BOOK_ID"].Value.ToString();
                DetailedMyBooks detailed = new DetailedMyBooks();
                LibraryProgram user = (LibraryProgram)this.Parent;
                if (!String.IsNullOrEmpty(id)) { 
                detailed.fillDetailedData(id);
                detailed.ShowDialog();
                } 
            }

            if(dataGridView1.CurrentCell.ColumnIndex == 0)
            {

            }
        }

        public void refreshData()
        {
            string _ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LibrarySystem;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                LibraryProgram user = (LibraryProgram)this.Parent;
              
                if(user.User_Id != -1)
                {
                    using (SqlCommand cmd = new SqlCommand("GET_MYBOOKS"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@USER_ID", SqlDbType.Int).Value = user.User_Id;

                        try
                        {

                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            this.dataGridView1.DataSource = dt;
                            orderColumns();
                            
                            
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Exception is occured: " + ex.Message);
                        }

                    }
                }               
            }
        }
        private void orderColumns()
        {
            dataGridView1.Columns["BOOK_ID"].DisplayIndex = 0;
            dataGridView1.Columns["BOOK_TITLE"].DisplayIndex = 1;
            dataGridView1.Columns["BOOK_ISBN"].DisplayIndex = 2;
            dataGridView1.Columns["BOOK_EXPIRED_DATE"].DisplayIndex = 3;
            dataGridView1.Columns["btnMore"].DisplayIndex = 4;
            dataGridView1.Columns["btnReturn"].DisplayIndex = 5;
        }
        private void myBooksDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void MyBooks_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int row = dataGridView1.RowCount;
            while (row > 0)
            {
                if (Convert.ToDateTime(dataGridView1.Rows[row-1].Cells["BOOK_EXPIRED_DATE"].Value) < DateTime.Now)
                {
                    dataGridView1.Rows[row - 1].Cells["BOOK_EXPIRED_DATE"].ErrorText = "You delayed expired date to return book, You will be fined!!";
                }
                else
                {
                    dataGridView1.Rows[row - 1].Cells["BOOK_EXPIRED_DATE"].ErrorText = "";
                }
            }
        }
    }
}

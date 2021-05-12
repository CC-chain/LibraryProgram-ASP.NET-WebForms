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

namespace Library
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
                if (!String.IsNullOrEmpty(id) && user.Staff_Id != -1) { 
                detailed.fillDetailedData(id , user.Staff_Id);
                detailed.ShowDialog();
                } 
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                var id = dataGridView1.CurrentRow.Cells["BOOK_ID"].Value.ToString();
                UpdateMyBooks detailed = new UpdateMyBooks();
                LibraryProgram user = (LibraryProgram)this.Parent;
                if (!String.IsNullOrEmpty(id) && user.Staff_Id != -1)
                {
                    detailed.fillDetailedData(id, user.Staff_Id);
                    detailed.ShowDialog();
                }
            }
        }

        public void refreshData()
        {
            string _ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LibrarySystem;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                LibraryProgram user = (LibraryProgram)this.Parent;
              
                if(!String.IsNullOrEmpty(user.Role) && user.Staff_Id != -1)
                {
                    using (SqlCommand cmd = new SqlCommand("GET_STAFF_MYBOOKS"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@STAFF_ID", SqlDbType.Int).Value = user.Staff_Id;

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
            dataGridView1.Columns["BOOK_PAGE"].DisplayIndex = 2;
            dataGridView1.Columns["BOOK_YEAR"].DisplayIndex = 3;
            dataGridView1.Columns["LANGUAGE_NAME"].DisplayIndex = 4;
            dataGridView1.Columns["PUBLISHER_NAME"].DisplayIndex = 5;
            dataGridView1.Columns["btnUpdate"].DisplayIndex = 6;
            dataGridView1.Columns["btnMore"].DisplayIndex = 7;
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
    }
}

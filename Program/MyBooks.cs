using LibraryProgram;
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

        //private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; 
        //(object reference not set to an instance of an object in some class) is occured. Check this problem!!

        private string _ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LibrarySystem;Integrated Security=True";
        public MyBooks()
        {
            InitializeComponent();
            
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LibraryProgram user = (LibraryProgram)this.Parent;
            var bookId = dataGridView1.CurrentRow.Cells["BOOK_ID"].Value.ToString();
            if (!String.IsNullOrEmpty(bookId)){ 
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                
                DetailedMyBooks detailed = new DetailedMyBooks();
                detailed.fillDetailedData(bookId);
                detailed.ShowDialog();
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 1 && user.User_Id > 0)
            {
                if (String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["BOOK_EXPIRED_DATE"].ErrorText))
                {
                    if (returnBook(Convert.ToInt32(bookId), user.User_Id))
                    {
                        MessageBox.Show("Returned the book succesfully!!");
                        refreshData();
                    }
                }
                else
                {
                    ReturnBook returnBook = new ReturnBook();

                    returnBook.getFine(Convert.ToInt32(bookId), user.User_Id);
                    returnBook.ShowDialog();
                }
            }
            }
        }


        public bool returnBook(int bookID , int userID)
        {
            bool isOkay = true;
            using(SqlConnection con = new SqlConnection(_ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("RETURN_BOOK", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BOOK_ID", SqlDbType.Int).Value = bookID;
                    cmd.Parameters.Add("@USER_ID", SqlDbType.Int).Value = userID;
                    try { 
                    con.Open();
                    cmd.ExecuteNonQuery();
                    }catch(SqlException ex)
                    {
                        Console.WriteLine(ex.Number + " - " + ex.Message);
                        isOkay = false;
                    }

                }
                return isOkay;
            }
        }

        public void refreshData()
        {
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void dataGridView1_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {

            int row = dataGridView1.RowCount;
            while (row > 1)
            {
                if(!String.IsNullOrEmpty(dataGridView1.Rows[row - 2].Cells["BOOK_EXPIRED_DATE"].Value.ToString())){ 
                if (Convert.ToDateTime(dataGridView1.Rows[row - 2].Cells["BOOK_EXPIRED_DATE"].Value) < DateTime.Now)
                {
                    dataGridView1.Rows[row - 2].Cells["BOOK_EXPIRED_DATE"].ErrorText = "You delayed expired date to return book, You will be fined!!";
                }
                else 
                {
                    dataGridView1.Rows[row - 2].Cells["BOOK_EXPIRED_DATE"].ErrorText = "";
                }
                }

                row--;
            }
        }
    }
}

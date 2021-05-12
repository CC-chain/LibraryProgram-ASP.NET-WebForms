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
    public partial class DetailedMyBooks : Form
    {
        public DetailedMyBooks()
        {
            InitializeComponent();
        }

        public void fillDetailedData(string bookID , int staff_id)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GET_STAFF_DETAILED_MYBOOKS"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@BOOK_ID", SqlDbType.Int).Value = bookID;
                    cmd.Parameters.Add("@STAFF_ID", SqlDbType.Int).Value = staff_id;

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            var date = DateTime.Parse(sdr["BOOK_YEAR"].ToString());
                            lblID.Text = bookID;
                            lblTitle.Text = sdr["BOOK_TITLE"].ToString();
                            lblISBN.Text = sdr["BOOK_ISBN"].ToString();
                            lblYear.Text = date.ToString("dd/MM/yyyy");
                            lblPage.Text = sdr["BOOK_PAGE"].ToString();
                            lblLanguage.Text = sdr["LANGUAGE_NAME"].ToString();
                            lblPublisher.Text = sdr["PUBLISHER_NAME"].ToString();
                            txtBoxAbstract.Text = sdr["BOOK_ABSTRACT"].ToString();

                        }

                    }
                }
            }
        }
    }
}

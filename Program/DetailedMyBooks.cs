using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class DetailedMyBooks : Form
    {
        private string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\Contents";
        public DetailedMyBooks()
        {
            InitializeComponent();
        }

        public void fillDetailedData(string bookID , int staff_id)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            
            string image = "";
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
                            image = sdr["BOOK_FILE_NAME"].ToString() + sdr["BOOK_FILE_EXTENSION"].ToString();
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
                        string fullpath = Path.Combine(path + "\\" + image);
                        pictureBoxBook.Image = new Bitmap(fullpath);
                        pictureBoxBook.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }

        public void fillDetailedData(string bookID)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string image = "";
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GET_DETAILED_SEARCH_BOOK"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@BOOK_ID", SqlDbType.Int).Value = bookID;

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            image = sdr["BOOK_FILE_NAME"].ToString() + sdr["BOOK_FILE_EXTENSION"].ToString();
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
                        string fullpath = Path.Combine(path+ "\\"+ image);
                        pictureBoxBook.Image = new Bitmap(fullpath);
                        pictureBoxBook.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }


        }
    }
}

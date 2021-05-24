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

namespace LibraryProgram
{
    public partial class BorrowedBookForm : Form
    {

        private string path = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName + "\\Contents";
        private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private string bookID;
        private string userID;
        private bool isCorrect;
        public BorrowedBookForm()
        {
            InitializeComponent();
        }

        public string BookID
        {
            get { return this.bookID; }
            set { this.bookID = value; }
        }

        public string UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public bool IsCorrect
        {
            get { return this.isCorrect; }
            set { this.isCorrect = value; }
        }

        public void fillDetailedData(string bookID , string userID)
        {
           
            string image = "";
            if (String.IsNullOrEmpty(BookID) || String.IsNullOrEmpty(UserID))
            {
                BookID = bookID;
                UserID = userID;
            }
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
                            lblStock.Text = sdr["BOOK_STOCK"].ToString();

                        }
                        string fullpath = Path.Combine(path + "\\" + image);
                        pictureBoxBook.Image = new Bitmap(fullpath);
                        pictureBoxBook.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            IsCorrect = true;

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Now > dateTimePickerDate.Value)
            {
                errorProviderDate.SetError(dateTimePickerDate, "You can't set date, before now!!");
                errorProviderDate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                IsCorrect = false;
            }
            else if(dateTimePickerDate.Value > DateTime.Now.AddDays(10).Date)
            {
                errorProviderDate.SetError(dateTimePickerDate, "You can only borrow the book maximum for 10 days!!");
                errorProviderDate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                IsCorrect = false;
            }
            else
            {
                errorProviderDate.Clear();
                IsCorrect = true;
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (IsCorrect)
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("ADD_BORROWED_BOOK"))
                    {
                        DateTime date = dateTimePickerDate.Value;
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@BOOK_ID", SqlDbType.Int).Value = BookID;
                        cmd.Parameters.Add("@USER_ID", SqlDbType.Int).Value = UserID;
                        cmd.Parameters.Add("@BOOK_EXPIRED_DATE", SqlDbType.Date).Value = date.ToString("yyyy-MM-dd");

                        if (Convert.ToBoolean(cmd.ExecuteScalar()))
                        {
                            MessageBox.Show("Succesfully borrowed!!");
                            fillDetailedData(BookID, UserID);
                        }
                        else
                        {
                            MessageBox.Show("There is some problem occured!!");
                        }
                    }
                }
            }
        }

    }
}

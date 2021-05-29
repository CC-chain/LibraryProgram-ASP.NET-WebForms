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
    public partial class ReturnBook : Form
    {
        private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private int bookID;
        private int userID;
        public ReturnBook()
        {
            InitializeComponent();
        }

        private int BookID
        {
            get { return this.bookID; }
            set { this.bookID = value; }
        }

        private int UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public void getFine(int bookID , int userID)
        {
            BookID = bookID;
            UserID = userID;
            using(SqlConnection con = new SqlConnection(_ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("SELECT PENALTY_TICKET FROM PENALTY WHERE USER_ID = @USER_ID AND BORROWED_BOOK_ID = @BOOK_ID", con))
                {
                    cmd.Parameters.Add("@BOOK_ID", SqlDbType.Int).Value = BookID;
                    cmd.Parameters.Add("@USER_ID", SqlDbType.Int).Value = UserID;
                    try
                    {
                        con.Open();
                        using(SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                lblFine.Text = sdr["PENALTY_TICKET"].ToString() + "$";
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine(ex.Number + " - " + ex.Message);
                    }
                }
            }
        }

        private bool checkCreditCard()
        {
            bool isOkay = true;
            var txtCardNumber = txtBoxCardNumber;
            var txtCVV = txtBoxCVV;

            txtCardNumber.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCVV.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (String.IsNullOrEmpty(txtCardNumber.Text))
            {
                errorProviderCardNumber.SetError(txtBoxCardNumber,"Please enter your Credit Card Number!!!");
                errorProviderCardNumber.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isOkay = false;

            }
            else if (txtBoxCardNumber.Text.Length != 16)
            {
                errorProviderCardNumber.SetError(txtBoxCardNumber, "Credit Card number has to be 16 digits !!!");
                errorProviderCardNumber.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isOkay = false;
            }

            if (String.IsNullOrEmpty(txtCVV.Text))
            {
                errorProviderCVV.SetError(txtBoxCVV, "Please enter your CVV !!!");
                errorProviderCVV.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isOkay = false;
            }
            else if (txtBoxCVV.Text.Length != 3)
            {
                errorProviderCVV.SetError(txtBoxCVV, "CVV has to be 3 digits !!!");
                errorProviderCVV.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isOkay = false;
            }

            if(dateTimePickerDate.Value < DateTime.Now)
            {
                errorProviderDate.SetError(dateTimePickerDate, "You cannot use expired credit card !!!");
                errorProviderDate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isOkay = false;
            }

            return isOkay;
        }

        private void clearErrors()
        {
            errorProviderCardNumber.Clear();
            errorProviderCVV.Clear();
            errorProviderDate.Clear();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(BookID > 0 && UserID > 0 && checkCreditCard() ) { 
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("RETURN_BOOK_WITH_FINE", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BOOK_ID", SqlDbType.Int).Value = BookID;
                    cmd.Parameters.Add("@USER_ID", SqlDbType.Int).Value = UserID;

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("The book is sucessfully returned!!");
                            this.Close();
                            LibraryProgram admin = (LibraryProgram)Application.OpenForms["LibraryProgram"];
                            admin.MyBook.refreshData();
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex.Number + " - " + ex.Message);
                        }
                        clearErrors();
                    }
            }
            }
        }
    }
}

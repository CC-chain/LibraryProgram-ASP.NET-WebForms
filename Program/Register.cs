using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProgram
{
    public partial class Register : Form
    {
        private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Register()
        {
            InitializeComponent();
        }
        private bool? isUnique()
        {
            bool? isUnique = false;
           
            using(SqlConnection con = new SqlConnection(_ConnectionString))
            {
                using(SqlCommand cmd = new SqlCommand("CHECK_USER_UNIQUE", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@USER_EMAIL", SqlDbType.NVarChar).Value = txtBoxEmail.Text;
                    cmd.Parameters.Add("@USER_PHONENUMBER", SqlDbType.NVarChar).Value = txtBoxPhoneNumber.Text;

                    if (Convert.ToBoolean(cmd.ExecuteScalar()))
                    {
                        isUnique = true;
                    }
                    else 
                    {
                        isUnique = false;
                    }
                }
            }

            if (!isUnique.HasValue)
            {
                Console.WriteLine("There is some problem occured!!");
                isUnique = false;
            }
            return isUnique;   
        }

        private bool isValid()
        {
            bool isValid = true;
            if (String.IsNullOrEmpty(txtBoxName.Text))
            {
                errorProviderName.SetError(txtBoxName, "Name box is empty!!");
                errorProviderName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isValid = false;
            }
            if (String.IsNullOrEmpty(txtBoxLastName.Text))
            {
                errorProviderLastName.SetError(txtBoxLastName, "Last Name box is empty!!");
                errorProviderLastName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isValid = false;
            }
            if (String.IsNullOrEmpty(txtBoxEmail.Text))
            {
                errorProviderEmail.SetError(txtBoxEmail, "Last Name box is empty!!");
                errorProviderEmail.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isValid = false;
            }
            else
            {
                var emailValidation = new EmailAddressAttribute();
                if (!emailValidation.IsValid(txtBoxEmail.Text))
                {
                    errorProviderEmail.SetError(txtBoxEmail, "Email is not valid!!");
                    errorProviderEmail.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    isValid = false;
                }
                   
            }            
            if(cmbBoxGender.SelectedIndex == -1)
            {
                errorProviderGender.SetError(cmbBoxGender, "Gender is not selected!!");
                errorProviderGender.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isValid = false;
            }

            if (String.IsNullOrEmpty(txtBoxPhoneNumber.Text))
            {
                errorProviderPhone.SetError(txtBoxPhoneNumber, "Phone Number box is empty!!");
                errorProviderPhone.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isValid = false;
            }

            if (String.IsNullOrEmpty(txtBoxPassword.Text))
            {
                errorProviderPassword.SetError(txtBoxPassword, "Password box is empty!!");
                errorProviderPassword.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isValid = false;
            }
            if (String.IsNullOrEmpty(txtBoxConfirmedPassword.Text))
            {
                errorProviderConfirmedPassword.SetError(txtBoxConfirmedPassword, "Confirmed Password box is empty!!");
                errorProviderConfirmedPassword.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isValid = false;
            }
            if(txtBoxConfirmedPassword.Text != txtBoxPassword.Text)
            {
                errorProviderPassword.SetError(txtBoxPassword, "Password is not matched with Confirmed Password!!");
                errorProviderPassword.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                errorProviderConfirmedPassword.SetError(txtBoxConfirmedPassword, "Confirmed Password is not matched with Password!!");
                errorProviderPassword.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isValid = false;
            }

            return isValid;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (Convert.ToBoolean(isUnique()))
                {
                    using (SqlConnection con = new SqlConnection(_ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("ADD_USER", con))
                        {
                            con.Open();
                            DateTime date = DateTime.Parse(dateTimePickerBirthday.Value.ToString());
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@USER_NAME", SqlDbType.NVarChar).Value = txtBoxName.Text;
                            cmd.Parameters.Add("@USER_LASTNAME", SqlDbType.NVarChar).Value = txtBoxLastName.Text;
                            cmd.Parameters.Add("@USER_BIRTHDAY", SqlDbType.Date).Value = date.ToString("yyyy-MM-dd");
                            cmd.Parameters.Add("@USER_GENDER", SqlDbType.NVarChar).Value = cmbBoxGender.SelectedItem.ToString();
                            cmd.Parameters.Add("@USER_EMAIL", SqlDbType.NVarChar).Value = txtBoxEmail.Text;
                            cmd.Parameters.Add("@USER_PASSOWRD", SqlDbType.NVarChar).Value = txtBoxPassword.Text;
                            cmd.Parameters.Add("@USER_PHONENUMBER", SqlDbType.NVarChar).Value = txtBoxPhoneNumber.Text;

                            if(Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                            {
                                MessageBox.Show("Succesfully registered!!");
                                Clear();
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


        private void Clear()
        {
            txtBoxName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxEmail.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxPassword.Text = "";
            txtBoxConfirmedPassword.Text = "";
            cmbBoxGender.SelectedIndex = -1;
            dateTimePickerBirthday.Value = DateTime.Parse("22.05.2021");
        }
    }
}

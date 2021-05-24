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
    public partial class MyProfile : UserControl
    {
       
        public MyProfile()
        {
            InitializeComponent();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            comboBoxGender.Items.Add("MALE");
            comboBoxGender.Items.Add("FEMALE");
        }

        public void fillData(string User , string Password)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GET_LOGINNED_MEMBER_INFO ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@USER", SqlDbType.NVarChar).Value = User;
                cmd.Parameters.Add("@USER_PASSWORD", SqlDbType.NVarChar).Value = Password;
                con.Open();
                using (SqlDataReader ordr = cmd.ExecuteReader())
                {
                    while (ordr.Read()) { 
                    txtBoxName.Text = ordr["USER_NAME"].ToString();
                    txtBoxLastName.Text = ordr["USER_LASTNAME"].ToString();
                    txtBoxPhoneNumber.Text = ordr["USER_PHONENUMBER"].ToString();
                    txtBoxEmail.Text = ordr["USER_EMAIL"].ToString();
                    dateTimeBirthday.Value = DateTime.Parse(ordr["USER_BIRTHDAY"].ToString());
                    if (ordr["USER_GENDER"].ToString() == "MALE")
                        comboBoxGender.SelectedIndex = 0;
                    else if (ordr["USER_GENDER"].ToString() == "FEMALE")
                        comboBoxGender.SelectedIndex = 1;
                    }
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LibraryProgram parent = (LibraryProgram)this.Parent;
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
             
                if(!String.IsNullOrEmpty(txtBoxPassword.Text) && !String.IsNullOrEmpty(txtBoxNewPassword.Text) && !String.IsNullOrEmpty(txtBoxConfirmPassword.Text))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT USER_PASSWORD FROM USERS WHERE USER_ID = @USER_ID", con))
                    {
                        cmd.Parameters.Add("USER_ID", SqlDbType.NVarChar).Value = parent.User_Id;

                        var password = Convert.ToString(cmd.ExecuteScalar());
                        if (txtBoxPassword.Text != password)
                        {
                            MessageBox.Show("Password is not true!!");
                            return;
                        }
                    }

                   

                    if (txtBoxNewPassword.Text == txtBoxConfirmPassword.Text)
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE USERS SET USER_PASSWORD = @USER_PASSWORD", con))
                        {
                            cmd.Parameters.Add("USER_PASSWORD", SqlDbType.NVarChar).Value = txtBoxConfirmPassword.Text;

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password is changed!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords are not equal!!");
                    }
                }
                using (SqlCommand cmd = new SqlCommand("UPDATE_PROFILE"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;


                    var date = DateTime.Parse(dateTimeBirthday.Text);

                    cmd.Parameters.Add("@USER_ID", SqlDbType.Int).Value = parent.User_Id;
                    cmd.Parameters.Add("@USER_NAME", SqlDbType.NVarChar).Value = txtBoxName.Text;
                    cmd.Parameters.Add("@USER_LASTNAME", SqlDbType.NVarChar).Value = txtBoxLastName.Text;
                    cmd.Parameters.Add("@USER_GENDER", SqlDbType.NVarChar).Value = comboBoxGender.SelectedItem.ToString();
                    cmd.Parameters.Add("@USER_BIRTHDAY", SqlDbType.Date).Value = date.ToString("yyyy-MM-dd");
                    cmd.Parameters.Add("@USER_PHONENUMBER", SqlDbType.NVarChar).Value = txtBoxPhoneNumber.Text;
                    cmd.Parameters.Add("@USER_EMAIL", SqlDbType.NVarChar).Value = txtBoxEmail.Text;

                    using (SqlDataReader ordr = cmd.ExecuteReader())
                    {
                        while (ordr.Read())
                        {
                            txtBoxName.Text = ordr["USER_NAME"].ToString();
                            txtBoxLastName.Text = ordr["USER_LASTNAME"].ToString();
                            parent.userName = ordr["USER_NAME"].ToString() + " " + ordr["USER_LASTNAME"].ToString();
                            txtBoxPhoneNumber.Text = ordr["USER_PHONENUMBER"].ToString();
                            txtBoxEmail.Text = ordr["USER_EMAIL"].ToString();
                            dateTimeBirthday.Value = DateTime.Parse(ordr["USER_BIRTHDAY"].ToString());
                            if (ordr["USER_GENDER"].ToString() == "MALE")
                                comboBoxGender.SelectedIndex = 0;
                            else if (ordr["USER_GENDER"].ToString() == "FEMALE")
                                comboBoxGender.SelectedIndex = 1;
                        }
                    }
                    MessageBox.Show("Update is Succesfull!!");
                }
            }
        }
    }
}

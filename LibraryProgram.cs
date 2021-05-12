using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Library
{
    public partial class LibraryProgram : Form
    {

        private int _logined;
        private string role;
        private int staff_id;
        private int user_id;

        public LibraryProgram()
        {
            InitializeComponent();
            _logined = 0;
        }


        public string Role
        {
            get { return this.role; }
            set { this.role = value; }
        }

        public int Staff_Id
        {
            get { return this.staff_id; }
            set { this.staff_id = value; }
        }

        public int User_Id
        {
            get { return this.user_id; }
            set { this.user_id = value; }
        }



        public MyBooks MyBook
        {
            get { return this.myBooks; }
        }

        public AddBook AddBook
        {
            get { return this.addBook; }
        }

        public Admin Admin
        {
            get { return this.admin; }
        }
        private void Library_Load(object sender, EventArgs e)
        {
            myBooks.Hide();
            myProfile.Hide();
            Publisher.Hide();
            Admin.Hide();
            addBook.Hide();
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (!String.IsNullOrEmpty(txtBoxUser.Text) && !String.IsNullOrEmpty(txtBoxPassword.Text))
            {
                Console.WriteLine(_ConnectionString);
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "CHECK_LOGIN";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@USER", SqlDbType.NVarChar).Value = txtBoxUser.Text;
                        cmd.Parameters.Add("@USER_PASSWORD", SqlDbType.NVarChar).Value = txtBoxPassword.Text;

                        try
                        {
                            con.Open();
                            _logined = Convert.ToInt32(cmd.ExecuteScalar());

                            if (_logined == 0)
                            {
                                lblValidation.Visible = true;
                            }
                            else if (_logined == 1)
                            {
                                lblValidation.Visible = false;
                                getMemberInfo(txtBoxUser.Text,txtBoxPassword.Text);
                                myProfile.fillData(txtBoxUser.Text, txtBoxPassword.Text);
                                txtBoxUser.Text = "";
                                txtBoxPassword.Text = "";
                                panel.Hide();
                                
                            }
                            else if (_logined == 2)
                            {
                                lblValidation.Visible = false;
                                getStaffInfo(txtBoxUser.Text, txtBoxPassword.Text);
                                myProfile.fillData(txtBoxUser.Text, txtBoxPassword.Text);
                                txtBoxUser.Text = "";
                                txtBoxPassword.Text = "";
                                panel.Hide();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Textboxes are empty!!");
            }
        }

        private void getMemberInfo(string User , string Password)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using(SqlConnection con = new SqlConnection(_ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GET_LOGINNED_MEMBER_INFO ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@USER", SqlDbType.NVarChar).Value = User;
                cmd.Parameters.Add("@USER_PASSWORD", SqlDbType.NVarChar).Value = Password;
                con.Open();
                using(SqlDataReader ordr = cmd.ExecuteReader())
                {
                    while (ordr.Read())
                    {
                        lblID.Text = ordr["USER_ID"].ToString();
                        lblAccount.Text = ordr["USER_NAME"].ToString() +" "+ordr["USER_LASTNAME"].ToString();
                        lblRole.Text = "Member";
                    }
                }
            }
        }

        private void getStaffInfo(string User, string Password)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("GET_LOGINNED_STAFF_INFO ", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@USER", SqlDbType.NVarChar).Value = User;
                cmd.Parameters.Add("@USER_PASSWORD", SqlDbType.NVarChar).Value = Password;
                con.Open();
                using (SqlDataReader ordr = cmd.ExecuteReader())
                {
                    while (ordr.Read())
                    {
                        lblID.Text = ordr["USER_ID"].ToString() + "   Staff Id:" + ordr["STAFF_ID"].ToString();
                        lblAccount.Text = ordr["USER_NAME"].ToString() + " " + ordr["USER_LASTNAME"].ToString();
                        lblRole.Text = ordr["STAFF_JOB"].ToString();
                        Staff_Id = Convert.ToInt32(ordr["STAFF_ID"].ToString());
                        Role = ordr["STAFF_JOB"].ToString();
                        User_Id = Convert.ToInt32(ordr["USER_ID"].ToString());
                    }
                }
            }
        }

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_logined == 1 || _logined == 2)
            {
                logout();
            }
        }

        private void logout()
        {
            lblID.Text = "";
            lblAccount.Text = "";
            lblRole.Text = "";
            Publisher.Hide();
            myProfile.Hide();
            addBook.Hide();
            myBooks.Hide();
            Admin.Hide();
            panel.Show();
        }


        public string userName
        {
            get
            {
                return this.lblAccount.Text;
            }

            set
            {
                this.lblAccount.Text = value;
            }
        }

        private void txtBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Publisher.Hide();
            myBooks.Hide();
            addBook.Hide();
            myProfile.Hide();

            Admin.fillData();
            Admin.Show();
            Admin.BringToFront();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            myBooks.Hide();
            myProfile.Hide();
            Publisher.Hide();
            Admin.Hide();

            addBook.getData();
            addBook.Show();
            addBook.BringToFront();
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            myBooks.Hide();
            myProfile.Hide();
            addBook.Hide();
            Admin.Hide();

            Publisher.Show();
            Publisher.BringToFront();
        }

        private void buttonMyBooks_Click(object sender, EventArgs e)
        {
            Publisher.Hide();
            myProfile.Hide();
            addBook.Hide();
            Admin.Hide();

            myBooks.refreshData();
            myBooks.Show();
            myBooks.BringToFront();
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            Publisher.Hide();
            myBooks.Hide();
            addBook.Hide();

            
            myProfile.Show();
            myProfile.BringToFront();
        }
    }
}

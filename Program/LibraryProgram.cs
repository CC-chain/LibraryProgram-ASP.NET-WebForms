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
using LibraryProgram;

namespace LibraryProject
{
    public partial class LibraryProgram : Form
    {

        //private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString; 
        //(object reference not set to an instance of an object in some class) is occured. Check this problem!!
        private string _ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LibrarySystem;Integrated Security=True";
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


        public BorrowBook BorrowBook
        {
            get { return this.borrowBook; }
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
            borrowBook.Hide();
            addBook.Hide();
            add.Hide();
            btnAdmin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
                                if(lblRole.Text != "Admin")
                                {
                                    btnAdmin.Enabled = false;
                                }
                                else
                                {
                                    btnAdmin.Enabled = true;
                                }
                            }
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    if(User_Id > 0) { 
                    using(SqlCommand cmdCheck = new SqlCommand())
                    {
                        con.Open();
                        cmdCheck.CommandText = "ADD_LOGGINED_USERS";
                        cmdCheck.CommandType = CommandType.StoredProcedure;
                        cmdCheck.Connection = con;
                        cmdCheck.Parameters.Add("@USER_ID", SqlDbType.Int).Value = User_Id;

                        cmdCheck.ExecuteNonQuery();
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
                        User_Id = Convert.ToInt32(ordr["USER_ID"].ToString());
                    }
                }
                btnMenuAdd.Hide();
                btnMenuAdd.Enabled = false;
                btnAdmin.Hide();
                btnAdmin.Enabled = false;
                moveButtonsforMember();

            }
        }


        private void getStaffInfo(string User, string Password)
        {

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

                btnMenuAdd.Show();
                btnMenuAdd.Enabled = true;
                btnAdmin.Show();
                btnAdmin.Enabled = true;
                moveButtonsforStaff();

            }
            
        }

        private void moveButtonsforStaff()
        {
            btnMenuAdd.Location = new Point(15, 118);
            btnMenuBorrow.Location = new Point(15, 175);
            btnMenuMyBooks.Location = new Point(15, 232);
            btnMenuMyProfile.Location = new Point(15, 289);
            btnAdmin.Location = new Point(15, 346);
        }

        private void moveButtonsforMember()
        {
            btnMenuBorrow.Location = new Point(15, 120);
            btnMenuMyBooks.Location = new Point(15, 177);
            btnMenuMyProfile.Location = new Point(15, 234);
        }

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_logined == 1 || _logined == 2)
            {
                logout();
                if (User_Id > 0)
                {
                   using(SqlConnection con = new SqlConnection(_ConnectionString)) { 
                        using (SqlCommand cmdCheck = new SqlCommand())
                        {
                        cmdCheck.CommandText = "DROP_LOGGINED_USERS";
                        cmdCheck.CommandType = CommandType.StoredProcedure;
                        cmdCheck.Connection = con;
                        cmdCheck.Parameters.Add("@USER_ID", SqlDbType.Int).Value = User_Id;

                        con.Open();
                        cmdCheck.ExecuteNonQuery();
                        }
                   }
                }
            }
        }

        private void logout()
        {
            lblID.Text = "";
            lblAccount.Text = "";
            lblRole.Text = "";
            borrowBook.Hide();
            Publisher.Hide();
            myProfile.Hide();
            addBook.Hide();
            myBooks.Hide();
            Admin.Hide();
            add.Hide();
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
            add.Hide();
            borrowBook.Hide();

            Admin.fillData();
            Admin.Show();
            Admin.BringToFront();
        }

    

        private void buttonMyBooks_Click(object sender, EventArgs e)
        {
            Publisher.Hide();
            myProfile.Hide();
            addBook.Hide();
            Admin.Hide();
            add.Hide();
            borrowBook.Hide();

            myBooks.refreshData();
            myBooks.Show();
            myBooks.BringToFront();
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            Publisher.Hide();
            myBooks.Hide();
            addBook.Hide();
            Admin.Hide();
            add.Hide();
            borrowBook.Hide();

            myProfile.Show();
            myProfile.BringToFront();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            register.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myBooks.Hide();
            myProfile.Hide();
            Publisher.Hide();
            Admin.Hide();
            add.Hide();
            borrowBook.Hide();

            addBook.getData();
            addBook.Show();
            addBook.BringToFront();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            myBooks.Hide();
            myProfile.Hide();
            addBook.Hide();
            Admin.Hide();
            add.Hide();
            borrowBook.Hide();

            Publisher.Show();
            Publisher.BringToFront();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            register.Show();
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            myBooks.Hide();
            myProfile.Hide();
            addBook.Hide();
            Admin.Hide();
            borrowBook.Hide();


            add.Show();
            add.BringToFront();
        }

        private void btnMenuBorrow_Click(object sender, EventArgs e)
        {
            myBooks.Hide();
            myProfile.Hide();
            addBook.Hide();
            Admin.Hide();
            add.Hide();

            borrowBook.refreshData();
            borrowBook.Show();
            borrowBook.BringToFront();
        }
    }
}

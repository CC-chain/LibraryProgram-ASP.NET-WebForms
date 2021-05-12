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
    public partial class Login : UserControl
    {
        private Boolean _logined;
        public Login()
        {
            InitializeComponent();
        }
        public Boolean Logined
        {
            get
            {
                return _logined;
            }
            set
            {
                _logined = value;
             
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (!String.IsNullOrEmpty(txtBoxUser.Text) && !String.IsNullOrEmpty(txtBoxPassword.Text))
            {
                Console.WriteLine(_ConnectionString);
                using(SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "CHECK_LOGIN";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@USER", SqlDbType.NVarChar).Value = txtBoxUser.Text;
                        cmd.Parameters.Add("@USER_PASSWORD", SqlDbType.NVarChar).Value = txtBoxPassword.Text;

                        try { 
                            con.Open();
                            Logined = Convert.ToBoolean(cmd.ExecuteScalar());

                            if(Logined == false)
                            {
                                lblValidation.Visible = true;
                            }
                            else
                            {
                                lblValidation.Visible = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            _logined = false;
        }
    }
}

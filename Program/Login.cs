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


     

        private void Login_Load(object sender, EventArgs e)
        {
            _logined = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            register.Show();
        }
    }
}

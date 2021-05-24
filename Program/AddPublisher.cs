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
    public partial class AddPublisher : UserControl
    {
        public AddPublisher()
        {
            InitializeComponent();
        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (!String.IsNullOrEmpty(txtBoxAddress.Text) && !String.IsNullOrEmpty(txtBoxEstablish.Text) && !String.IsNullOrEmpty(txtBoxPhoneNumber.Text) &&
                !String.IsNullOrEmpty(txtBoxPublisher.Text))
            {
                using(SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    using(SqlCommand cmd = new SqlCommand("ADD_PUBLISHER",con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@PUBLISHER_NAME", SqlDbType.NVarChar).Value = txtBoxPublisher.Text;
                        cmd.Parameters.Add("@PUBLISHER_PHONENUMBER", SqlDbType.NVarChar).Value = txtBoxPhoneNumber.Text;
                        cmd.Parameters.Add("@PUBLISHER_ADDRESS", SqlDbType.NVarChar).Value = txtBoxAddress.Text;
                        cmd.Parameters.Add("@PUBLISHER_ESTABLISH", SqlDbType.Date).Value = txtBoxEstablish.Text;

                        int success = Convert.ToInt32(cmd.ExecuteScalar());
                        if(success > 0)
                        {
                            MessageBox.Show("Adding is successfull !!");
                            LibraryProgram parent = (LibraryProgram)this.Parent;
                            parent.AddBook.getData();
                            txtBoxAddress.Text = "";
                            txtBoxEstablish.Text = "";
                            txtBoxPhoneNumber.Text = "";
                            txtBoxPublisher.Text = "";
                        }

                    }
                }
            }
        }
    }
}

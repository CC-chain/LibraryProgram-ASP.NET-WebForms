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
    public partial class UpdateUser : Form
    {
        private DataTable data = new DataTable();
        private int userID;
        public UpdateUser()
        {
            InitializeComponent();
        }


        private DataTable Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        private int UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public void selectItem(string user)
        {
            cmbBoxUser.SelectedIndex = cmbBoxUser.Items.IndexOf(user);
        }
        public void fillData()
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM USERS"))
                {
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(Data);
                    }
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            cmbBoxUser.Items.Add(sdr["USER_ID"].ToString() + "-" + sdr["USER_NAME"].ToString() + " " + sdr["USER_LASTNAME"].ToString());
                        }
                    }
                }
               
            }
        }

        private void cmbBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxUser.SelectedIndex != -1 && Data != null)
            {
                txtBoxName.Text = Data.Rows[cmbBoxUser.SelectedIndex]["USER_NAME"].ToString();
                txtBoxLastName.Text = Data.Rows[cmbBoxUser.SelectedIndex]["USER_LASTNAME"].ToString();
                dateTimeBirthday.Text = Data.Rows[cmbBoxUser.SelectedIndex]["USER_BIRTHDAY"].ToString();
                txtBoxPhoneNumber.Text = Data.Rows[cmbBoxUser.SelectedIndex]["USER_PHONENUMBER"].ToString();
                txtBoxEmail.Text = Data.Rows[cmbBoxUser.SelectedIndex]["USER_EMAIL"].ToString();
                if (Data.Rows[cmbBoxUser.SelectedIndex]["USER_GENDER"].ToString() == "MALE")
                {
                    comboBoxGender.SelectedIndex = 0;
                }
                else if (Data.Rows[cmbBoxUser.SelectedIndex]["USER_GENDER"].ToString() == "FEMALE")
                {
                    cmbBoxUser.SelectedIndex = 1;
                }
                UserID = Convert.ToInt32(Data.Rows[cmbBoxUser.SelectedIndex]["USER_ID"]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (!String.IsNullOrEmpty(txtBoxEmail.Text) && !String.IsNullOrEmpty(txtBoxName.Text) && !String.IsNullOrEmpty(txtBoxLastName.Text)
               && !String.IsNullOrEmpty(txtBoxPhoneNumber.Text) && comboBoxGender.SelectedIndex != -1 && !String.IsNullOrEmpty(dateTimeBirthday.Text))
            {
                DateTime date = DateTime.Parse(dateTimeBirthday.Text);

                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE_USER"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@USER_ID", SqlDbType.Int).Value = UserID;
                        cmd.Parameters.Add("@USER_NAME", SqlDbType.NVarChar).Value = txtBoxName.Text;
                        cmd.Parameters.Add("@USER_LASTNAME ", SqlDbType.NVarChar).Value = txtBoxLastName.Text;
                        cmd.Parameters.Add("@USER_BIRTHDAY", SqlDbType.Date).Value = date.ToString("dd-MM-yyyy");
                        cmd.Parameters.Add("@USER_GENDER ", SqlDbType.NVarChar).Value = comboBoxGender.SelectedItem.ToString();
                        cmd.Parameters.Add("@USER_PHONENUMBER ", SqlDbType.NVarChar).Value = txtBoxPhoneNumber.Text;
                        cmd.Parameters.Add("@USER_EMAIL", SqlDbType.NVarChar).Value = txtBoxEmail.Text;

                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Update is successfull!!!");
                            fillData();
                            selectItem(UserID + "-" + txtBoxName.Text + " " + txtBoxLastName.Text);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("There is some problem occured!!!");
                            Console.WriteLine(ex.Message + "\n" + ex.Number);
                        }
                    }
                }
            }
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            fillData();
        }
    }
}

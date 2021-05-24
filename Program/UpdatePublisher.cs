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
    public partial class UpdatePublisher : Form
    {
        private DataTable data= new DataTable();
        private int publisherID;
        public UpdatePublisher()
        {
            InitializeComponent();
        }

        private DataTable Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        private int PublisherID
        {
            get { return this.publisherID; }
            set { this.publisherID = value; }
        }

        public void selectItem(string publisher)
        {
            cmbBoxPublisher.SelectedIndex = cmbBoxPublisher.Items.IndexOf(publisher);
        }

        public void fillData()
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM PUBLISHER"))
                {
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        if(Data.Rows.Count > 0)
                        {
                            Data.Clear();
                        }
                        sda.Fill(Data);
                    }
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if(cmbBoxPublisher.Items.Count > 0)
                        {
                            cmbBoxPublisher.Items.Clear();
                        }
                        while (sdr.Read())
                        {
                            cmbBoxPublisher.Items.Add(sdr["PUBLISHER_ID"].ToString() + "-" + sdr["PUBLISHER_NAME"].ToString());

                        }
                    }
                }
            }
        }

        private void cmbBoxPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxPublisher.SelectedIndex > -1 && Data != null)
            {
                txtBoxAddress.Text = Data.Rows[cmbBoxPublisher.SelectedIndex]["PUBLISHER_ADDRESS"].ToString();
                txtBoxEstablish.Text = Data.Rows[cmbBoxPublisher.SelectedIndex]["PUBLISHER_ESTABLISH"].ToString();
                txtBoxPhoneNumber.Text = Data.Rows[cmbBoxPublisher.SelectedIndex]["PUBLISHER_PHONENUMBER"].ToString();
                txtBoxPublisher.Text = Data.Rows[cmbBoxPublisher.SelectedIndex]["PUBLISHER_NAME"].ToString();
                PublisherID = Convert.ToInt32(Data.Rows[cmbBoxPublisher.SelectedIndex]["PUBLISHER_ID"]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (!String.IsNullOrEmpty(txtBoxAddress.Text) && !String.IsNullOrEmpty(txtBoxEstablish.Text) && !String.IsNullOrEmpty(txtBoxPhoneNumber.Text)
                && !String.IsNullOrEmpty(txtBoxPublisher.Text))
            {
                DateTime date = DateTime.Parse(txtBoxEstablish.Text);

                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE_PUBLISHER"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@PUBLISHER_NAME", SqlDbType.NVarChar).Value = txtBoxPublisher.Text;
                        cmd.Parameters.Add("@PUBLISHER_PHONENUMBER", SqlDbType.NVarChar).Value = txtBoxPhoneNumber.Text;
                        cmd.Parameters.Add("@PUBLISHER_ADDRESS", SqlDbType.NVarChar).Value = txtBoxAddress.Text;
                        cmd.Parameters.Add("@PUBLISHER_ESTABLISH", SqlDbType.Date).Value = date.ToString("dd-MM-yyyy");
                        cmd.Parameters.Add("@PUBLISHER_ID", SqlDbType.Int).Value = PublisherID;

                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Update is successfull!!!");
                            fillData();
                            selectItem(PublisherID + "-" + txtBoxPublisher.Text);
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

        private void UpdatePublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            LibraryProgram admin = (LibraryProgram)Application.OpenForms["LibraryProgram"];
            admin.Admin.fillData();
        }
    }
}

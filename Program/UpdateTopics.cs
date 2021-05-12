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
    public partial class UpdateTopics : Form
    {
        private DataTable data = new DataTable();
        private int topicID;
        public UpdateTopics()
        {
            InitializeComponent();
        }

        private DataTable Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        private int TopicID
        {
            get { return this.topicID; }
            set { this.topicID = value; }
        }

        private void Topics_Click(object sender, EventArgs e)
        {

        }
        public void selectItem(string topic)
        {
            if (cmbBoxTopics.Items.IndexOf(topic) != null)
            {
                cmbBoxTopics.SelectedIndex = cmbBoxTopics.Items.IndexOf(topic);
            }
        }

        private void cmbBoxTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxTopics.SelectedIndex > -1)
            {
                txtBoxUpdate.Text = cmbBoxTopics.SelectedItem.ToString();
            }
        }

        public void fillData()
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SUBJECT_TOPICS"))
                {
                    cmd.Connection = con;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if(cmbBoxTopics.Items.Count > 0)
                        {
                            cmbBoxTopics.Items.Clear();
                        }
                        while (sdr.Read())
                        {
                            cmbBoxTopics.Items.Add(sdr["SUBTOP_ID"].ToString() + "-" + sdr["SUBTOP_NAME"].ToString());
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxAdd.Text))
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("ADD_TOPIC"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@SUBTOP_NAME", SqlDbType.NVarChar).Value = txtBoxAdd.Text;

                        if (Convert.ToBoolean(cmd.ExecuteScalar()) == true)
                        {
                            MessageBox.Show("Adding is succeded!!!");
                            fillData();
                        }
                        else
                        {
                            MessageBox.Show("There is already have this topic!!!");
                        }
                    }
                }
            }
        }

        private void UpdateTopics_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxUpdate.Text))
            {

                using (SqlConnection con = new SqlConnection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE_TOPIC"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@SUBTOP_NAME", SqlDbType.NVarChar).Value = txtBoxUpdate.Text;
                        cmd.Parameters.Add("@SUBTOP_ID", SqlDbType.Int).Value = TopicID;
                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Update is successfull!!!");
                            fillData();
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
    }
}

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
    public partial class UpdateAuthor : Form
    {
        private DataTable data=new DataTable();
        private int authorID;

        public UpdateAuthor()
        {
            InitializeComponent();
        }
        private DataTable Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        private int AuthorID
        {
            get { return this.authorID; }
            set { this.authorID = value; }
        }


        public void selectItem(string author)
        {
            cmbBoxAuthor.SelectedIndex = cmbBoxAuthor.Items.IndexOf(author);
        }

        public void fillData()
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM AUTHOR"))
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
                        if(cmbBoxAuthor.Items.Count > 0)
                        {
                            cmbBoxAuthor.Items.Clear();
                        }
                        while (sdr.Read())
                        {
                            cmbBoxAuthor.Items.Add(sdr["AUTHOR_ID"].ToString() + "-" + sdr["AUTHOR_NAME"].ToString() + " " + sdr["AUTHOR_LASTNAME"].ToString());

                        }
                    }
                }
            }
        }

        private void cmbBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBoxAuthor.SelectedIndex != -1 && Data != null )
            {
                txtBoxName.Text = Data.Rows[cmbBoxAuthor.SelectedIndex]["AUTHOR_NAME"].ToString();
                txtBoxLastName.Text = Data.Rows[cmbBoxAuthor.SelectedIndex]["AUTHOR_LASTNAME"].ToString();
                AuthorID = Convert.ToInt32(Data.Rows[cmbBoxAuthor.SelectedIndex]["AUTHOR_ID"]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (!String.IsNullOrEmpty(txtBoxName.Text) && !String.IsNullOrEmpty(txtBoxLastName.Text))
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE_AUTHOR"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@AUTHOR_NAME", SqlDbType.NVarChar).Value = txtBoxName.Text;
                        cmd.Parameters.Add("@AUTHOR_LASTNAME", SqlDbType.NVarChar).Value = txtBoxLastName.Text;
                        cmd.Parameters.Add("@AUTHOR_ID", SqlDbType.Int).Value = AuthorID;
                    
                        try
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Update is successfull!!!");

                            fillData();
                            selectItem(AuthorID + "-" + txtBoxName.Text + " " + txtBoxLastName.Text);
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

        private void UpdateAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            LibraryProgram admin = (LibraryProgram)Application.OpenForms["LibraryProgram"];
            admin.Admin.fillData();
        }
    }
}

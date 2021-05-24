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
    public partial class UpdateLanguages : Form
    {
        private string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private DataTable data = new DataTable();
        private int languageID;
        public UpdateLanguages()
        {
            InitializeComponent();
        }
        private DataTable Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        private int LanguageID
        {
            get { return this.languageID; }
            set { this.languageID = value; }
        }

        public void selectItem(string language)
        {
            cmbBoxLanguage.SelectedIndex = cmbBoxLanguage.Items.IndexOf(language);
        }
        public void fillData()
        {
         
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM LANGUAGES"))
                {
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        if (Data.Rows.Count > 0)
                        {
                            Data.Clear();
                        }
                        sda.Fill(Data);
                    }
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if(cmbBoxLanguage.Items.Count > 0)
                        {
                            cmbBoxLanguage.Items.Clear();
                        }
                        while (sdr.Read())
                        {
                            cmbBoxLanguage.Items.Add(sdr["LANGUAGE_ID"].ToString() + "-" + sdr["LANGUAGE_NAME"].ToString());
                        }
                    }
                }
               
            }
        }

        private void cmbBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBoxLanguage.SelectedIndex > -1)
            {
                txtBoxUpdate.Text = Data.Rows[cmbBoxLanguage.SelectedIndex]["LANGUAGE_NAME"].ToString();
                LanguageID = Convert.ToInt32(Data.Rows[cmbBoxLanguage.SelectedIndex]["LANGUAGE_ID"]);
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxAdd.Text))
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("ADD_LANGUAGE"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@LANGUAGE_NAME", SqlDbType.NVarChar).Value = txtBoxAdd.Text;

                        if(Convert.ToBoolean(cmd.ExecuteScalar()) == true)
                        {
                            MessageBox.Show("Adding is succeded!!!");
                            fillData();
                        }
                        else
                        {
                            MessageBox.Show("There is already have this language!!!");
                        }
                    }
                }
            }
        }

        private void UpdateLanguages_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxUpdate.Text) && LanguageID != 0)
            {

                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE_LANGUAGE"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@LANGUAGE_NAME", SqlDbType.NVarChar).Value = txtBoxUpdate.Text;
                        cmd.Parameters.Add("@LANGUAGE_ID", SqlDbType.Int).Value = LanguageID;

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Update is successfull!!!");
                            fillData();
                            selectItem(LanguageID + "-" + txtBoxUpdate.Text);
                        }catch(SqlException ex)
                        {
                            MessageBox.Show("There is some problem occured!!!");
                            Console.WriteLine(ex.Message + "\n" + ex.Number);
                        }
                    }
                }
            }
        }

        private void UpdateLanguages_FormClosed(object sender, FormClosedEventArgs e)
        {
            LibraryProgram admin = (LibraryProgram)Application.OpenForms["LibraryProgram"];
            admin.Admin.fillData();
        }
    }
}

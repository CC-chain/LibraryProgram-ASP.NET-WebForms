using LibraryProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LibraryProject
{
    public partial class Search : UserControl
    {
        private DateTime dateMin = new DateTime();
        private DateTime dateMax = new DateTime();
        private string _ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LibrarySystem;Integrated Security=True";
        public Search()
        {
            InitializeComponent();
        }

        public DateTime DateMin
        {
            get { return dateMin; }
            set { this.dateMin = value; }
        }

        public DateTime DateMax
        {
            get { return dateMax; }
            set { this.dateMax = value; }
        }
        
        public void fillData()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using (SqlCommand cmdPublisher = new SqlCommand("SELECT * FROM PUBLISHER", con))
                {
                    try
                    {
                        using (SqlDataReader sdr = cmdPublisher.ExecuteReader())
                        {
                            if (cmbBoxPublisher.Items.Count > 0)
                            {
                                cmbBoxPublisher.Items.Clear();
                            }
                            while (sdr.Read())
                            {
                                cmbBoxPublisher.Items.Add(sdr["PUBLISHER_NAME"].ToString());
                            }
                        }
                    }
                    catch (SqlException exPublisher)
                    {
                        MessageBox.Show("There is some problem occured: " + exPublisher.Number + "-" + exPublisher.Message);
                    }
                }
                using (SqlCommand cmdLanguage = new SqlCommand("SELECT * FROM LANGUAGES", con))
                {
                    try
                    {
                        using (SqlDataReader sdr = cmdLanguage.ExecuteReader())
                        {
                            if (cmbBoxLanguage.Items.Count > 0)
                            {
                                cmbBoxLanguage.Items.Clear();
                            }
                            while (sdr.Read())
                            {
                                cmbBoxLanguage.Items.Add(sdr["LANGUAGE_NAME"].ToString());
                            }
                        }
                    }
                    catch (SqlException exLangauge)
                    {
                        MessageBox.Show("There is some problem occured: " + exLangauge.Number + "-" + exLangauge.Message);
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerYearMin_ValueChanged(object sender, EventArgs e)
        {
            DateMin = dateTimePickerYearMin.Value;

        }

        private void dateTimePickerYearMax_ValueChanged(object sender, EventArgs e)
        {
            DateMax = dateTimePickerYearMax.Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using(SqlConnection con = new SqlConnection(_ConnectionString))
            {
                string query = "SELECT * FROM BOOK";
                using (SqlCommand cmd = new SqlCommand(query,con))
                {
                    if (chkBoxYear.Checked)
                    {
                        Filter filter = new Filter(txtBoxTitle.Text, cmbBoxLanguage.SelectedItem, cmbBoxPublisher.Text, DateMin, DateMax, txtBoxPageMin.Text, txtBoxPageMax.Text, txtBoxISBN.Text,
                            txtBoxAuthor.Text);
                        query = filter.filterQuery(cmd);
                    }
                    else
                    {
                        Filter filter = new Filter(txtBoxTitle.Text, cmbBoxLanguage.SelectedItem, cmbBoxPublisher.SelectedItem, DateTime.Parse("1753-01-01"), DateTime.Parse("9998-12-01"), txtBoxPageMin.Text, txtBoxPageMax.Text, txtBoxISBN.Text,
                            txtBoxAuthor.Text);
                        query = filter.filterQuery(cmd);
                    }

                    cmd.Connection = con;
                    cmd.CommandText = query;
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                       
                        dataGridView.DataSource = dt;
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        orderColumns();
                    }catch(SqlException ex)
                    {
                        Console.WriteLine("Exception is occured: " + ex.Message);
                    }
                }
            }
        }

        private void chkBoxYear_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxYear.Checked)
            {
                dateTimePickerYearMax.Enabled = true;
                dateTimePickerYearMin.Enabled = true;
            }
            else
            {
                dateTimePickerYearMax.Enabled = false;
                dateTimePickerYearMin.Enabled = false;
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            fillData();
            chkBoxYear.Checked = false;
            dateTimePickerYearMax.Enabled = false;
            dateTimePickerYearMin.Enabled = false;
            DateMin = dateTimePickerYearMin.Value;
            DateMax = dateTimePickerYearMax.Value;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.ColumnIndex == 0)
            {
                var id = dataGridView.CurrentRow.Cells["BOOK_ID"].Value.ToString();
                DetailedMyBooks detailed = new DetailedMyBooks();
                LibraryProgram user = (LibraryProgram)this.Parent;
                if (!String.IsNullOrEmpty(id))
                {
                    detailed.fillDetailedData(id);
                    detailed.ShowDialog();
                }
            }
        }

        private void orderColumns()
        {
            dataGridView.Columns["BOOK_ID"].DisplayIndex = 0;
            dataGridView.Columns["BOOK_TITLE"].DisplayIndex = 1;
            dataGridView.Columns["BOOK_YEAR"].DisplayIndex = 2;
            dataGridView.Columns["BOOK_ISBN"].DisplayIndex = 3;
            dataGridView.Columns["LANGUAGE_NAME"].DisplayIndex = 4;
            dataGridView.Columns["PUBLISHER_NAME"].DisplayIndex = 5;
            dataGridView.Columns["btnMore"].DisplayIndex = 6;

        }
    }
}

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
    public partial class Admin : UserControl
    {
        private string _ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LibrarySystem;Integrated Security=True";
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            fillData();
        }

        public void fillData()
        {
            using(SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using(SqlCommand cmdBook = new SqlCommand("SELECT * FROM BOOK", con))
                {
                    try
                    {
                        using(SqlDataReader sdr = cmdBook.ExecuteReader())
                        {
                            if(cmbBoxBook.Items.Count > 0)
                            {
                                cmbBoxBook.Items.Clear();
                            }
                            while (sdr.Read())
                            {
                                cmbBoxBook.Items.Add(sdr["BOOK_ID"].ToString() + "-" + sdr["BOOK_TITLE"].ToString());
                            }
                        }
                    }catch(SqlException exBook)
                    {
                        MessageBox.Show("There is some problem occured: "+ exBook.Number + "-" + exBook.Message);
                    }
                }
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
                                cmbBoxPublisher.Items.Add(sdr["PUBLISHER_ID"].ToString() + "-" + sdr["PUBLISHER_NAME"].ToString());
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
                                cmbBoxLanguage.Items.Add(sdr["LANGUAGE_ID"].ToString() + "-" + sdr["LANGUAGE_NAME"].ToString());
                            }
                        }
                    }
                    catch (SqlException exLangauge)
                    {
                        MessageBox.Show("There is some problem occured: " + exLangauge.Number + "-" + exLangauge.Message);
                    }
                }
                using (SqlCommand cmdTopics = new SqlCommand("SELECT * FROM SUBJECT_TOPICS", con))
                {
                    try
                    {
                        using (SqlDataReader sdr = cmdTopics.ExecuteReader())
                        {
                            if (cmbBoxTopics.Items.Count > 0)
                            {
                                cmbBoxTopics.Items.Clear();
                            }
                            while (sdr.Read())
                            {
                                cmbBoxTopics.Items.Add(sdr["SUBTOP_ID"].ToString() + "-" + sdr["SUBTOP_NAME"].ToString());
                            }
                        }
                    }
                    catch (SqlException exTopic)
                    {
                        MessageBox.Show("There is some problem occured: " + exTopic.Number + "-" + exTopic.Message);
                    }
                }
                using (SqlCommand cmdUser = new SqlCommand("SELECT * FROM USERS", con))
                {
                    try
                    {

                        using (SqlDataReader sdr = cmdUser.ExecuteReader())
                        {
                            if (cmbBoxUser.Items.Count > 0)
                            {
                                cmbBoxUser.Items.Clear();
                            }
                            while (sdr.Read())
                            {
                                cmbBoxUser.Items.Add(sdr["USER_ID"].ToString() + "-" + sdr["USER_NAME"].ToString() +" "+sdr["USER_LASTNAME"].ToString());
                            }
                        }
                    }
                    catch (SqlException exUser)
                    {
                        MessageBox.Show("There is some problem occured: " + exUser.Number + "-" + exUser.Message);
                    }
                }
                using (SqlCommand cmdAuthor = new SqlCommand("SELECT * FROM AUTHOR", con))
                {
                    try
                    {
                        using (SqlDataReader sdr = cmdAuthor.ExecuteReader())
                        {
                            if (cmbBoxAuthor.Items.Count > 0)
                            {
                                cmbBoxAuthor.Items.Clear();
                            }
                            while (sdr.Read())
                            {
                                cmbBoxAuthor.Items.Add(sdr["AUTHOR_ID"].ToString() + "-" + sdr["AUTHOR_NAME"].ToString() + " " + sdr["AUTHOR_LASTNAME"].ToString());
                            }
                        }
                    }
                    catch (SqlException exAuthor)
                    {
                        MessageBox.Show("There is some problem occured: " + exAuthor.Number + "-" + exAuthor.Message);
                    }
                }
            }

        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            int staffID = -1;

            if (cmbBoxBook.SelectedIndex != -1)
            {
                UpdateMyBooks updateBook = new UpdateMyBooks();
                using(SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using(SqlCommand cmd= new SqlCommand("GET_STAFF_ID_FROM_BOOKS", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        string bookID = new string(cmbBoxBook.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray());
                        cmd.Parameters.Add("@BOOK_ID", SqlDbType.Int).Value = bookID;
                        try
                        {
                            staffID = Convert.ToInt32(cmd.ExecuteScalar());
                        }catch(SqlException ex)
                        {
                            MessageBox.Show("There is some problem occured: " + ex.Number + "-" + ex.Message);
                        }
                    }
                }
                if(staffID != -1)
                {
                    updateBook.fillDetailedData(cmbBoxBook.SelectedItem.ToString(), staffID);
                    updateBook.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There is some problem occured!!!");
                }
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            if (cmbBoxBook.SelectedIndex != -1)
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("DELETE_BOOK"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        string bookID = new string(cmbBoxBook.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray());
                        cmd.Parameters.Add("@BOOK_ID", SqlDbType.Int).Value =bookID;

                        if(Convert.ToBoolean(cmd.ExecuteScalar()) == true)
                        {
                            MessageBox.Show("Delete is successful!!");
                        }
                        else
                        {
                            MessageBox.Show("Book is not exists");
                        }
                    }
                }   
            }
        }

        private void btnLanguageUpdate_Click(object sender, EventArgs e)
        {

            if (cmbBoxLanguage.SelectedIndex != -1)
            {
                UpdateLanguages updateLanguages = new UpdateLanguages();
                updateLanguages.fillData();
                updateLanguages.selectItem(cmbBoxLanguage.SelectedItem.ToString());
                updateLanguages.ShowDialog();
            }
        }

        private void btnDeleteLanguage_Click(object sender, EventArgs e)
        {
            if (cmbBoxLanguage.SelectedIndex != -1)
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE_LANGUAGE"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        string langaugeID = new string(cmbBoxLanguage.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray());
                        cmd.Parameters.Add("@LANGUAGE_ID", SqlDbType.Int).Value = langaugeID;

                        if (Convert.ToBoolean(cmd.ExecuteScalar()) == true)
                        {
                            MessageBox.Show("Delete is successful!!");
                            fillData();
                        }
                        else
                        {
                            MessageBox.Show("You can't delete language because it is exists in book table!!!");
                        }
                    }
                }
            }
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBoxUser.SelectedIndex != -1)
            {
                UpdateUser updateUser = new UpdateUser();
                updateUser.fillData();
                updateUser.selectItem(cmbBoxUser.SelectedItem.ToString());
                updateUser.ShowDialog();
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (cmbBoxUser.SelectedIndex != -1)
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE_USER"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        string userID = new string(cmbBoxUser.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray());
                        cmd.Parameters.Add("@USER_ID", SqlDbType.Int).Value = userID;

                        if (Convert.ToBoolean(cmd.ExecuteScalar()) == true)
                        {
                            MessageBox.Show("Delete is successful!!");
                            fillData();
                        }
                        else
                        {
                            MessageBox.Show("You can't delete language because it is exists in book table!!!");
                        }
                    }
                }
            }
        }

        private void btnPublisherUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBoxPublisher.SelectedIndex != -1)
            {
                UpdatePublisher updatePublisher = new UpdatePublisher();
                updatePublisher.fillData();
                updatePublisher.selectItem(cmbBoxPublisher.SelectedItem.ToString());
                updatePublisher.ShowDialog();
            }
        }

        private void btnPublisherDelete_Click(object sender, EventArgs e)
        {
            if (cmbBoxPublisher.SelectedIndex != -1)
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE_PUBLISHER"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        string publisherID = new string(cmbBoxPublisher.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray());
                        cmd.Parameters.Add("@PUBLISHER_ID", SqlDbType.Int).Value = publisherID;

                        if (Convert.ToBoolean(cmd.ExecuteScalar()) == true)
                        {
                            MessageBox.Show("Delete is successful!!");
                            fillData();
                        }
                        else
                        {
                            MessageBox.Show("You can't delete language because it is exists in book table!!!");
                        }
                    }
                }
            }
        }

        private void btnTopicsUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBoxTopics.SelectedIndex != -1)
            {
                UpdateTopics updateTopics = new UpdateTopics();
                updateTopics.fillData();
                updateTopics.selectItem(cmbBoxPublisher.SelectedItem.ToString());
                updateTopics.ShowDialog();
            }
        }

        private void btnTopicsDelete_Click(object sender, EventArgs e)
        {
            if (cmbBoxTopics.SelectedIndex != -1)
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE_TOPIC"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        string topicID = new string(cmbBoxTopics.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray());
                        cmd.Parameters.Add("@TOPIC_ID", SqlDbType.Int).Value = topicID;

                        if (Convert.ToBoolean(cmd.ExecuteScalar()) == true)
                        {
                            MessageBox.Show("Delete is successful!!");
                            fillData();
                        }
                        else
                        {
                            MessageBox.Show("You can't delete language because it is exists in book table!!!");
                        }
                    }
                }
            }
        }

        private void btnAuthorUpdate_Click(object sender, EventArgs e)
        {
            if (cmbBoxAuthor.SelectedIndex != -1)
            {
                UpdateAuthor updateAuthor = new UpdateAuthor();
                updateAuthor.fillData();
                updateAuthor.selectItem(cmbBoxAuthor.SelectedItem.ToString());
                updateAuthor.ShowDialog();
            }
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            if (cmbBoxAuthor.SelectedIndex != -1)
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE_AUTHOR"))
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        string topicID = new string(cmbBoxAuthor.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray());
                        cmd.Parameters.Add("@AUTHOR_ID", SqlDbType.Int).Value = topicID;

                        if (Convert.ToBoolean(cmd.ExecuteScalar()) == true)
                        {
                            MessageBox.Show("Delete is successful!!");
                            fillData();
                        }
                        else
                        {
                            MessageBox.Show("You can't delete language because it is exists in book table!!!");
                        }
                    }
                }
            }
        }
    }
}

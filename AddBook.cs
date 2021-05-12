using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBook : UserControl
    {
        private string picture;
        public AddBook()
        {
            InitializeComponent();
        }


        public void getData()
        {
            string _ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=LibrarySystem;Integrated Security=True";
            try
            {
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmdPublisher = new SqlCommand("SELECT PUBLISHER_ID , PUBLISHER_NAME FROM PUBLISHER", con))
                    {
                        using (SqlDataReader sdrPublisher = cmdPublisher.ExecuteReader())
                        {
                            if(comboBoxPublisher.Items.Count > 0)
                            {
                                comboBoxPublisher.Items.Clear();
                            }
                            while (sdrPublisher.Read())
                            {
                                comboBoxPublisher.Items.Add(sdrPublisher["PUBLISHER_NAME"].ToString());
                                comboBoxPublisher.ValueMember = sdrPublisher["PUBLISHER_ID"].ToString();
                                comboBoxPublisher.DisplayMember = sdrPublisher["PUBLISHER_NAME"].ToString();
                            }
                        }

                    }
                    using (SqlCommand cmdTopics = new SqlCommand("SELECT SUBTOP_ID , SUBTOP_NAME FROM SUBJECT_TOPICS", con))
                    {
                        using (SqlDataReader sdrTopics = cmdTopics.ExecuteReader())
                        {
                            while (sdrTopics.Read())
                            {
                                listBoxTopics.Items.Add(sdrTopics["SUBTOP_NAME"]);

                            }
                        }

                    }
                    using (SqlCommand cmdLanguages = new SqlCommand("SELECT LANGUAGE_ID, LANGUAGE_NAME FROM LANGUAGES ", con))
                    {
                        using (SqlDataReader sdrLanguages = cmdLanguages.ExecuteReader())
                        {
                            if(comboBoxLanguage.Items.Count > 0)
                            {
                                comboBoxLanguage.Items.Clear();
                            }
                            while (sdrLanguages.Read())
                            {
                                comboBoxLanguage.Items.Add(sdrLanguages["LANGUAGE_NAME"].ToString());
                                comboBoxLanguage.ValueMember = sdrLanguages["LANGUAGE_ID"].ToString();
                                comboBoxLanguage.DisplayMember = sdrLanguages["LANGUAGE_NAME"].ToString();
                            }
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Sql hatası!!");
            }
        }


        private void AddBook_Load(object sender, EventArgs e)
        {
            lblSelect.AutoEllipsis = true;
            getData();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if(open.ShowDialog() == DialogResult.OK)
            {
                lblSelect.Text = open.SafeFileName;
                Picture = open.SafeFileName;
                pctrBoxBook.Image = new Bitmap(open.FileName);
                pctrBoxBook.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            int bookID = -1;
            Boolean isExists = false;

            clearError();
            if (isCorrect(sender,e))
            {
                var date = DateTime.Parse(txtBoxYear.Text);
                using (SqlConnection con = new SqlConnection(_ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("CHECK_BOOK", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@BOOK_ISBN", SqlDbType.NVarChar).Value = txtBoxISBN.Text;

                        isExists = Convert.ToBoolean(cmd.ExecuteScalar());
                    }

                    LibraryProgram user = (LibraryProgram)this.Parent;
                    if (!isExists && user.Staff_Id != -1) { 
                        using (SqlCommand cmd = new SqlCommand("ADD_BOOK", con))
                    {
                     
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@BOOK_ABSTRACT", SqlDbType.NVarChar).Value = txtBoxAbstract.Text;
                        cmd.Parameters.Add("@LANGUAGE_NAME", SqlDbType.NVarChar).Value = comboBoxLanguage.SelectedItem.ToString();
                        cmd.Parameters.Add("@BOOK_PAGE", SqlDbType.Int).Value = txtBoxBookPage.Text;
                        cmd.Parameters.Add("@BOOK_YEAR", SqlDbType.Date).Value = date.ToString("yyyy-MM-dd");
                        cmd.Parameters.Add("@PUBLISHER_NAME", SqlDbType.NVarChar).Value = comboBoxPublisher.SelectedItem.ToString();
                        cmd.Parameters.Add("@BOOK_FILE_NAME", SqlDbType.NVarChar).Value = Path.GetFileNameWithoutExtension(lblSelect.Text);
                        cmd.Parameters.Add("@BOOK_FILE_EXTENSION", SqlDbType.NVarChar).Value = Path.GetExtension(lblSelect.Text);
                        cmd.Parameters.Add("@AUTHOR_NAME", SqlDbType.NVarChar).Value = txtBoxAuthorName.Text;
                        cmd.Parameters.Add("@AUTHOR_LASTNAME", SqlDbType.NVarChar).Value = txtBoxAuthotLastName.Text;
                        cmd.Parameters.Add("@BOOK_ISBN", SqlDbType.NVarChar).Value = txtBoxISBN.Text;
                        cmd.Parameters.Add("@BOOK_TITLE", SqlDbType.NVarChar).Value = txtBoxTitle.Text;
                        cmd.Parameters.Add("@BOOK_ADDED_BY_STAFF", SqlDbType.Int).Value =user.Staff_Id;

                        var result = cmd.ExecuteScalar();
                        if(result != null)
                        {
                            bookID = (Int32)result;
                            MessageBox.Show("Adding is succeseded!!");
                            insertStatıcImage();
                        }
                        else
                        {
                            MessageBox.Show("Some problem is occurred!!");
                        }


                    }
                    int[] arr=createArrayWithSelectedTopics(con);
                    insertTopics(bookID, arr);
                    clearAllText();
                   
                    }
                    else
                    {
                        MessageBox.Show("This book is already exists!!");
                    }

                }
            }
        }

        private void clearAllText()
        {
            txtBoxAuthorName.Text = "";
            txtBoxAuthotLastName.Text = "";
            txtBoxAbstract.Text = "";
            txtBoxBookPage.Text = "";
            txtBoxTitle.Text = "";
            txtBoxYear.Text = "";
            txtBoxISBN.Text = "";
            comboBoxLanguage.SelectedIndex = -1;
            comboBoxPublisher.SelectedIndex = -1;
            listBoxSelectedTopics.Items.Clear();
            lblSelect.Text = "Please choose image...";
            pctrBoxBook.Image = null;

        }

    

        private void btnAddTopics_Click(object sender, EventArgs e)
        {
            if (listBoxTopics.SelectedItem != null) { 
                if (listBoxSelectedTopics.FindString(listBoxTopics.SelectedItem.ToString()) == -1)
                {
                        listBoxSelectedTopics.Items.Add(listBoxTopics.SelectedItem.ToString());
                }
            }   
        }

        private void btnRemoveTopics_Click(object sender, EventArgs e)
        {
            if(listBoxSelectedTopics.SelectedItem != null)
            listBoxSelectedTopics.Items.RemoveAt(listBoxSelectedTopics.SelectedIndex);
        }

        private int[] createArrayWithSelectedTopics(SqlConnection con)
        {
            int[] arr = new int[listBoxSelectedTopics.Items.Count];
            int counter = 0;

            using (SqlCommand cmdSubject = new SqlCommand("SELECT SUBTOP_ID FROM SUBJECT_TOPICS WHERE SUBTOP_NAME = @SUBTOP_NAME", con))
            {
                cmdSubject.Parameters.Add("SUBTOP_NAME", SqlDbType.NVarChar);
                foreach (var item in listBoxSelectedTopics.Items)
                {
                    cmdSubject.Parameters[0].Value= item.ToString();

                    arr[counter] = Convert.ToInt32(cmdSubject.ExecuteScalar());
                    counter++;
                   
                }

            }

            return arr;
        }

        private void insertTopics(int bookID,int[] subTop)
        {
            string _ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(_ConnectionString))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "ADD_SELECTED_TOPICS";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BOOK_ID", SqlDbType.Int);
                    cmd.Parameters.Add("@SUBTOP_ID", SqlDbType.Int);

                    for (int i = 0; i < subTop.Length ; i++)
                    {
                        cmd.Parameters[0].Value = bookID;
                        cmd.Parameters[1].Value = subTop[i];
                        cmd.ExecuteNonQuery();
                    }
                   
                }
            }
        }

        private void insertStatıcImage()
        {
            if(pctrBoxBook.Image != null && !String.IsNullOrEmpty(Picture) )
            {
                string location = "C:\\Users\\st\\source\\repos\\Library";
                string image = Picture;
                string path = Path.Combine(location + "\\Contents\\" + image);
                Console.WriteLine(path);
                Image i = pctrBoxBook.Image;
                if (!File.Exists(path))
                {
                    i.Save(path);
                }
                
            }

        }

        private string Picture
        {
            get { return this.picture; }
            set { this.picture = value; }
        }

        private bool isCorrect (object sender , EventArgs e)
        {
            bool isCorrect = true;
            if (String.IsNullOrEmpty(txtBoxAbstract.Text))
            {
                errorProviderAbstract.SetError(txtBoxAbstract, "Abstract text is empty!!!");
                errorProviderAbstract.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            if (String.IsNullOrEmpty(txtBoxTitle.Text))
            {
                errorProviderTitle.SetError(txtBoxTitle, "Title text is empty!!!");
                errorProviderTitle.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            if (String.IsNullOrEmpty(txtBoxAuthorName.Text))
            {
                errorProviderName.SetError(txtBoxAuthorName, "Author name text is empty!!!");
                errorProviderName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            if (String.IsNullOrEmpty(txtBoxAuthotLastName.Text))
            {
                errorProviderLastName.SetError(txtBoxAuthotLastName, "Author lastname text is empty!!!");
                errorProviderLastName.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            if (String.IsNullOrEmpty(txtBoxBookPage.Text))
            {
                errorProviderPage.SetError(txtBoxBookPage, "Page text is empty!!!");
                errorProviderPage.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            if (String.IsNullOrEmpty(txtBoxISBN.Text))
            {
                errorProviderISBN.SetError(txtBoxISBN, "ISBN text is empty!!!");
                errorProviderISBN.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            else if (txtBoxISBN.Text.Length != 17)
            {
                errorProviderISBN.SetError(txtBoxISBN, "ISBN number has to be 13 digits!!!");
                errorProviderISBN.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            if(pctrBoxBook.Image == null)
            {
                errorProviderImage.SetError(btnSelect, "Image is not selected!!!");
                errorProviderImage.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            DateTime value;
            if (String.IsNullOrEmpty(txtBoxYear.Text))
            {
                errorProviderYear.SetError(txtBoxYear, "Year text is empty!!!");
                errorProviderYear.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            else if(!DateTime.TryParse(txtBoxYear.Text, out value))
            {
                errorProviderYear.SetError(txtBoxYear, "Year text is not written properly!!!");
                errorProviderYear.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            if (comboBoxPublisher.SelectedIndex == -1)
            {
                errorProviderPublisher.SetError(comboBoxPublisher, "Publisher is not selected!!!");
                errorProviderPublisher.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            if (comboBoxLanguage.SelectedIndex == -1)
            {
                errorProviderLanguage.SetError(comboBoxLanguage, "Language is not selected!!!");
                errorProviderLanguage.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }
            if(listBoxSelectedTopics.Items.Count == 0)
            {
                errorProviderSelectedTopics.SetError(listBoxSelectedTopics, "Topics are not selected!!!");
                errorProviderSelectedTopics.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                isCorrect = false;
            }

            return isCorrect;
        }

        private void clearError()
        {
            errorProviderAbstract.Clear();
            errorProviderTitle.Clear();
            errorProviderName.Clear();
            errorProviderLastName.Clear();
            errorProviderPage.Clear();
            errorProviderISBN.Clear();
            errorProviderImage.Clear();
            errorProviderYear.Clear();
            errorProviderLanguage.Clear();
            errorProviderSelectedTopics.Clear();
            errorProviderPublisher.Clear();
        }

        private void comboBoxPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

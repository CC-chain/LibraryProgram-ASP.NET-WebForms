using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgram
{
    class Filter
    {
        private string _bookTitle;
        private object _language;
        private object _publisher;
        private DateTime _yearMin;
        private DateTime _yearMax;
        private string _pageMin;
        private string _pageMax;
        private string _isbn;
        private string _author;

        public Filter (string bookTitle, object language, object publisher, DateTime yearMin , DateTime yearMax, string pageMin, string pageMax, 
                       string isbn, string author)
        {
            _bookTitle = bookTitle;
            _language = language;
            _publisher = publisher;
            _yearMin = yearMin;
            _yearMax = yearMax;
            _pageMin = pageMin;
            _pageMax = pageMax;
            _isbn = isbn;
            _author = author;
        }


        public string filterQuery(SqlCommand cmd , int userID)
        {
            bool additonalQuery = false;

            string query = "SELECT B.BOOK_ID,B.BOOK_TITLE,B.BOOK_STOCK,B.BOOK_ISBN,B.BOOK_YEAR FROM BOOK AS B " +
                "INNER JOIN AUTHOR AS A ON A.AUTHOR_ID = B.AUTHOR_ID " +
                "INNER JOIN LANGUAGES AS L ON L.LANGUAGE_ID = B.LANGUAGE_ID " +
                "INNER JOIN PUBLISHER AS P ON P.PUBLISHER_ID = B.PUBLISHER_ID WHERE ";

            if (!String.IsNullOrEmpty(_bookTitle))
            {
                query += " B.BOOK_TITLE LIKE '%'+ @BOOK_TITLE +'%' ";
                cmd.Parameters.Add("@BOOK_TITLE", System.Data.SqlDbType.NVarChar).Value = _bookTitle;
                additonalQuery = true;
            }

            if (_language != null)
            {
                if (!String.IsNullOrEmpty(_language.ToString())) { 
                if (additonalQuery)
                    query += " AND ";
                query += " L.LANGUAGE_NAME = @LANGUAGE_NAME ";
                cmd.Parameters.Add("@LANGUAGE_NAME", System.Data.SqlDbType.NVarChar).Value = _language.ToString();
                additonalQuery = true;
                }
            }

            if (_publisher != null)
            {
                if (!String.IsNullOrEmpty(_publisher.ToString())) { 
                if (additonalQuery)
                    query += " AND ";
                query += " P.PUBLISHER_NAME = @PUBLISHER_NAME ";
                cmd.Parameters.Add("@PUBLISHER_NAME", System.Data.SqlDbType.NVarChar).Value = _publisher.ToString();
                additonalQuery = true;
                }
            }

            if(!String.IsNullOrEmpty(_isbn.Trim()) && _isbn != "   - -  -      -")
            {
                if (additonalQuery)
                    query += " AND ";
                query += " B.BOOK_ISBN = @BOOK_ISBN ";
                cmd.Parameters.Add("@BOOK_ISBN", System.Data.SqlDbType.NVarChar).Value = _isbn.Trim();
                additonalQuery = true;
            }

            if (!String.IsNullOrEmpty(_author))
            {
                if (additonalQuery)
                    query += " AND ";
                query += " A.AUTHOR_NAME LIKE '%'+ @AUTHOR_NAME +'%' ";
                cmd.Parameters.Add("@AUTHOR_NAME", System.Data.SqlDbType.NVarChar).Value = _author;
                additonalQuery = true;
            }

            if((_yearMin != null && _yearMax == null) || (_yearMax != null && _yearMin == null))
            {
                if(_yearMin != null)
                {
                    if (additonalQuery)
                        query += " AND ";
                    query += " B.BOOK_YEAR = @BOOK_YEAR ";
                    cmd.Parameters.Add("@BOOK_YEAR", System.Data.SqlDbType.Date).Value = _yearMin;
                    additonalQuery = true;
                }
                else if(_yearMax != null)
                {
                    if (additonalQuery)
                        query += " AND ";
                    query += " B.BOOK_YEAR = @BOOK_YEAR ";
                    cmd.Parameters.Add("@BOOK_YEAR", System.Data.SqlDbType.Date).Value = _yearMax;
                    additonalQuery = true;
                }
            }

            if(_yearMax != null && _yearMin != null)
            {
                if (additonalQuery)
                    query += " AND ";
                query += " (B.BOOK_YEAR BETWEEN @BOOK_YEAR_MIN AND @BOOK_YEAR_MAX ) ";
                cmd.Parameters.Add("@BOOK_YEAR_MIN", System.Data.SqlDbType.Date).Value = _yearMin;
                cmd.Parameters.Add("@BOOK_YEAR_MAX", System.Data.SqlDbType.Date).Value = _yearMin;
                additonalQuery = true;
            }

            if((!String.IsNullOrEmpty(_pageMin) && String.IsNullOrEmpty(_pageMax)) || (!String.IsNullOrEmpty(_pageMax) && String.IsNullOrEmpty(_pageMin)))
            {
                if (additonalQuery)
                    query += " AND ";
                if(!String.IsNullOrEmpty(_pageMin))
                {
                    query += " B.BOOK_PAGE = @BOOK_PAGE ";
                    cmd.Parameters.Add("@BOOK_PAGE", System.Data.SqlDbType.Int).Value = _pageMin;
                    additonalQuery = true;
                }
                else if (!String.IsNullOrEmpty(_pageMax))
                {
                    query += " B.BOOK_PAGE = @BOOK_PAGE ";
                    cmd.Parameters.Add("@BOOK_PAGE", System.Data.SqlDbType.Int).Value = _pageMax;
                    additonalQuery = true;
                }
            }

            if(!String.IsNullOrEmpty(_pageMin) && !String.IsNullOrEmpty(_pageMax))
            {
                if (additonalQuery)
                    query += " AND ";
                query += "  (B.BOOK_PAGE BETWEEN @BOOK_PAGE_MIN AND @BOOK_PAGE_MAX ) ";
                cmd.Parameters.Add("@BOOK_PAGE_MIN", System.Data.SqlDbType.Int).Value = _pageMin;
                cmd.Parameters.Add("@BOOK_PAGE_MAX", System.Data.SqlDbType.Int).Value = _pageMax;
                additonalQuery = true;
            }

            if (query == "SELECT B.BOOK_ID,B.BOOK_TITLE,B.BOOK_STOCK,B.BOOK_ISBN,B.BOOK_YEAR FROM BOOK AS B " +
                "INNER JOIN AUTHOR AS A ON A.AUTHOR_ID = B.AUTHOR_ID " +
                "INNER JOIN LANGUAGES AS L ON L.LANGUAGE_ID = B.LANGUAGE_ID " +
                "INNER JOIN PUBLISHER AS P ON P.PUBLISHER_ID = B.PUBLISHER_ID WHERE ")
            {
                query = "SELECT B.BOOK_ID,B.BOOK_TITLE,B.BOOK_STOCK,B.BOOK_ISBN,B.BOOK_YEAR FROM BOOK AS B " +
                "INNER JOIN AUTHOR AS A ON A.AUTHOR_ID = B.AUTHOR_ID " +
                "INNER JOIN LANGUAGES AS L ON L.LANGUAGE_ID = B.LANGUAGE_ID " +
                "INNER JOIN PUBLISHER AS P ON P.PUBLISHER_ID = B.PUBLISHER_ID WHERE NOT EXISTS " +
                "(SELECT * FROM BORROWED_BOOK AS BO WHERE BO.BOOK_ID = B.BOOK_ID AND BO.USER_ID = @USER_ID ) AND BOOK_STOCK > 0";
            }
            else
            {
                if (additonalQuery)
                    query += " AND ";
                query += " NOT EXISTS " +
                "(SELECT * FROM BORROWED_BOOK AS BO WHERE BO.BOOK_ID = B.BOOK_ID AND BO.USER_ID = @USER_ID) AND BOOK_STOCK > 0";
            }

            cmd.Parameters.Add("USER_ID", System.Data.SqlDbType.Int).Value = userID;
            return query;
        }

        public string filterQuery(SqlCommand cmd)
        {
            bool additonalQuery = false;

            string query = "SELECT B.BOOK_ID,B.BOOK_TITLE,B.BOOK_STOCK,B.BOOK_ISBN,B.BOOK_YEAR FROM BOOK AS B " +
                "INNER JOIN AUTHOR AS A ON A.AUTHOR_ID = B.AUTHOR_ID " +
                "INNER JOIN LANGUAGES AS L ON L.LANGUAGE_ID = B.LANGUAGE_ID " +
                "INNER JOIN PUBLISHER AS P ON P.PUBLISHER_ID = B.PUBLISHER_ID WHERE ";

            if (!String.IsNullOrEmpty(_bookTitle))
            {
                query += " B.BOOK_TITLE LIKE '%'+ @BOOK_TITLE +'%' ";
                cmd.Parameters.Add("@BOOK_TITLE", System.Data.SqlDbType.NVarChar).Value = _bookTitle;
                additonalQuery = true;
            }

            if (_language != null)
            {
                if (!String.IsNullOrEmpty(_language.ToString()))
                {
                    if (additonalQuery)
                        query += " AND ";
                    query += " L.LANGUAGE_NAME = @LANGUAGE_NAME ";
                    cmd.Parameters.Add("@LANGUAGE_NAME", System.Data.SqlDbType.NVarChar).Value = _language.ToString();
                    additonalQuery = true;
                }
            }

            if (_publisher != null)
            {
                if (!String.IsNullOrEmpty(_publisher.ToString()))
                {
                    if (additonalQuery)
                        query += " AND ";
                    query += " P.PUBLISHER_NAME = @PUBLISHER_NAME ";
                    cmd.Parameters.Add("@PUBLISHER_NAME", System.Data.SqlDbType.NVarChar).Value = _publisher.ToString();
                    additonalQuery = true;
                }
            }

            if (!String.IsNullOrEmpty(_isbn.Trim()) && _isbn != "   - -  -      -")
            {
                if (additonalQuery)
                    query += " AND ";
                query += " B.BOOK_ISBN = @BOOK_ISBN ";
                cmd.Parameters.Add("@BOOK_ISBN", System.Data.SqlDbType.NVarChar).Value = _isbn.Trim();
                additonalQuery = true;
            }

            if (!String.IsNullOrEmpty(_author))
            {
                if (additonalQuery)
                    query += " AND ";
                query += " A.AUTHOR_NAME LIKE '%'+ @AUTHOR_NAME +'%' ";
                cmd.Parameters.Add("@AUTHOR_NAME", System.Data.SqlDbType.NVarChar).Value = _author;
                additonalQuery = true;
            }

            if ((_yearMin != null && _yearMax == null) || (_yearMax != null && _yearMin == null))
            {
                if (_yearMin != null)
                {
                    if (additonalQuery)
                        query += " AND ";
                    query += " B.BOOK_YEAR = @BOOK_YEAR ";
                    cmd.Parameters.Add("@BOOK_YEAR", System.Data.SqlDbType.Date).Value = _yearMin;
                    additonalQuery = true;
                }
                else if (_yearMax != null)
                {
                    if (additonalQuery)
                        query += " AND ";
                    query += " B.BOOK_YEAR = @BOOK_YEAR ";
                    cmd.Parameters.Add("@BOOK_YEAR", System.Data.SqlDbType.Date).Value = _yearMax;
                    additonalQuery = true;
                }
            }

            if (_yearMax != null && _yearMin != null)
            {
                if (additonalQuery)
                    query += " AND ";
                query += " (B.BOOK_YEAR BETWEEN @BOOK_YEAR_MIN AND @BOOK_YEAR_MAX ) ";
                cmd.Parameters.Add("@BOOK_YEAR_MIN", System.Data.SqlDbType.Date).Value = _yearMin;
                cmd.Parameters.Add("@BOOK_YEAR_MAX", System.Data.SqlDbType.Date).Value = _yearMin;
                additonalQuery = true;
            }

            if ((!String.IsNullOrEmpty(_pageMin) && String.IsNullOrEmpty(_pageMax)) || (!String.IsNullOrEmpty(_pageMax) && String.IsNullOrEmpty(_pageMin)))
            {
                if (additonalQuery)
                    query += " AND ";
                if (!String.IsNullOrEmpty(_pageMin))
                {
                    query += " B.BOOK_PAGE = @BOOK_PAGE ";
                    cmd.Parameters.Add("@BOOK_PAGE", System.Data.SqlDbType.Int).Value = _pageMin;
                    additonalQuery = true;
                }
                else if (!String.IsNullOrEmpty(_pageMax))
                {
                    query += " B.BOOK_PAGE = @BOOK_PAGE ";
                    cmd.Parameters.Add("@BOOK_PAGE", System.Data.SqlDbType.Int).Value = _pageMax;
                    additonalQuery = true;
                }
            }

            if (!String.IsNullOrEmpty(_pageMin) && !String.IsNullOrEmpty(_pageMax))
            {
                if (additonalQuery)
                    query += " AND ";
                query += "  (B.BOOK_PAGE BETWEEN @BOOK_PAGE_MIN AND @BOOK_PAGE_MAX ) ";
                cmd.Parameters.Add("@BOOK_PAGE_MIN", System.Data.SqlDbType.Int).Value = _pageMin;
                cmd.Parameters.Add("@BOOK_PAGE_MAX", System.Data.SqlDbType.Int).Value = _pageMax;
                additonalQuery = true;
            }

            if (query == "SELECT B.BOOK_ID,B.BOOK_TITLE,B.BOOK_STOCK,B.BOOK_ISBN,B.BOOK_YEAR FROM BOOK AS B " +
                "INNER JOIN AUTHOR AS A ON A.AUTHOR_ID = B.AUTHOR_ID " +
                "INNER JOIN LANGUAGES AS L ON L.LANGUAGE_ID = B.LANGUAGE_ID " +
                "INNER JOIN PUBLISHER AS P ON P.PUBLISHER_ID = B.PUBLISHER_ID WHERE ")
            {
                query = "SELECT B.BOOK_ID,B.BOOK_TITLE,B.BOOK_STOCK,B.BOOK_ISBN,B.BOOK_YEAR FROM BOOK AS B " +
                "INNER JOIN AUTHOR AS A ON A.AUTHOR_ID = B.AUTHOR_ID " +
                "INNER JOIN LANGUAGES AS L ON L.LANGUAGE_ID = B.LANGUAGE_ID " +
                "INNER JOIN PUBLISHER AS P ON P.PUBLISHER_ID = B.PUBLISHER_ID WHERE NOT EXISTS " +
                "(SELECT * FROM BORROWED_BOOK AS BO WHERE BO.BOOK_ID = B.BOOK_ID AND BO.USER_ID = @USER_ID ) AND BOOK_STOCK > 0";
            }
            else
            {
                if (additonalQuery)
                    query += " AND ";
                query += " NOT EXISTS " +
                "(SELECT * FROM BORROWED_BOOK AS BO WHERE BO.BOOK_ID = B.BOOK_ID AND BO.USER_ID = @USER_ID) AND BOOK_STOCK > 0";
            }

            return query;
        }

    }
}

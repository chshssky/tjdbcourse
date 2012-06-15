using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReaderTerminal
{
    public partial class frmBook : Form
    {
        String isbn;

        public frmBook()
        {
            InitializeComponent();
        }

        public frmBook(String isbn)
        {
            this.isbn = isbn;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime nowtime = System.DateTime.Now;

            int readerId = frmLogin.readerId;
            string sql3 =
                "INSERT INTO reserve(reader_id, book_isbn, reserve_time, available) " +
                "VALUES	(@readerId, @ISBN, @nowtime, 1)";

            SqlCommand cmd = new SqlCommand(sql3, Library.Connection.Instance());
            cmd = new SqlCommand(sql3, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@readerid", readerId);
            cmd.Parameters.AddWithValue("@ISBN", isbn);
            cmd.Parameters.AddWithValue("@nowtime", nowtime);
            //cmd.Parameters.AddWithValue("@1", 1);
            cmd.ExecuteNonQuery();
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            string sql = "select title, author, publisher, description " +
                "from readable_book where isbn = @isbn";

            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@isbn", isbn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBookName.Text = reader.GetString(0);
                txtAuthor.Text = reader.GetString(1);
                txtPublisher.Text = reader.GetString(2);
                txtDescription.Text = reader.GetString(3);
            }
            reader.Close();
        }
    }
}

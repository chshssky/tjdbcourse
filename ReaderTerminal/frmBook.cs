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
        String ISBN;
        public frmBook()
        {
            InitializeComponent();
        }

        public frmBook(String bookName, String publisher,
            String author, String discription, String isbn, String[] information)
        {
            InitializeComponent();
            textBox1.Text = bookName;
            textBox2.Text = publisher;
            textBox3.Text = author;
            textBox4.Text = discription;
            ISBN = isbn;
            for (int i = 0; information[i] != null; ++i)
            {
                textBox5.Text = textBox5.Text + information[i] + System.Environment.NewLine;
            }
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
            cmd.Parameters.AddWithValue("@ISBN", ISBN);
            cmd.Parameters.AddWithValue("@nowtime", nowtime);
            //cmd.Parameters.AddWithValue("@1", 1);
            cmd.ExecuteNonQuery();
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            
         
        }
    }
}

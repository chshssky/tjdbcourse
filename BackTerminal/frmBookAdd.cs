using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BackTerminal
{
    public partial class frmBookAdd : Form
    {
        public frmBookAdd()
        {
            InitializeComponent();
            InitializeComboBoxLibrary();
        }
        private string ISBN = null;
        public void setISBN(string ISBN)
        {
            this.ISBN = ISBN;
        }

        private void InitializeComboBoxLibrary()
        {
            SqlConnection connection = Library.Connection.Instance();
            string queryString = "SELECT name FROM dbo.library;";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader[0];
                comboBoxLibrary.Items.Add(name);
            }
            comboBoxLibrary.SelectedIndex = 0;
            reader.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown.Value;
            string libraryName = (string)comboBoxLibrary.SelectedItem;
            SqlConnection connection = Library.Connection.Instance();

            // 获取 category id
            string queryString = "SELECT id FROM dbo.library where name='" + libraryName + "';";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            int libraryId = 1;
            while (reader.Read())
            {
                libraryId = (int)reader[0];
                Console.Out.WriteLine(libraryId);
            }
            reader.Close();

            // INSERT INTO dbo.particular_book
            for (int i = 0; i < quantity; i++)
            {
                string sql = "INSERT INTO dbo.particular_book (book_isbn, library_id)" +
                    "VALUES(@book_isbn, @library_id);";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@book_isbn", ISBN);
                command.Parameters.AddWithValue("@library_id", libraryId);
                command.ExecuteNonQuery();
            }
        }
    }
}

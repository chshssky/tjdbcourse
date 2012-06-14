using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BackTerminal
{
    public partial class frmBookStatus : Form
    {
        public frmBookStatus()
        {
            InitializeComponent();
        }

        private void frmBookStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.book_library_damaged' table. You can move, or remove it, as needed.
            this.book_library_damagedTableAdapter.Fill(this.dataSet.book_library_damaged);
        }

        public void Reload(string ISBN)
        {
            // testing...
            this.dataSet.particular_book.Clear();

            string sql = "select * from book_library_damaged where isbn=@ISBN";
            //sql = "select * from particular_book";
            this.book_library_damagedTableAdapter.Fill(this.dataSet.book_library_damaged);
            this.book_library_damagedTableAdapter.Adapter.SelectCommand.CommandText = sql;
            this.book_library_damagedTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            this.book_library_damagedTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@ISBN", ISBN);
            this.book_library_damagedTableAdapter.Adapter.Fill(this.dataSet.book_library_damaged);
        }
    }
}

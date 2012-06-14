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
            // TODO: This line of code loads data into the 'dataSet.particular_book' table. You can move, or remove it, as needed.
            //this.particular_bookTableAdapter.Fill(this.dataSet.particular_book);

            // testing...
            string ISBN = "aa";
            //this.dataSet.particular_book.Clear();

            string sql = "select * from particular_book where book_isbn = @ISBN;";
            sql = "select * from particular_book;";
            this.particular_bookTableAdapter.Adapter.SelectCommand
                .CommandText = sql;
            //this.particular_bookTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            //this.particular_bookTableAdapter.Adapter.SelectCommand.Parameters
                   // .AddWithValue("@ISBN", ISBN);
            this.particular_bookTableAdapter.Fill(this.dataSet.particular_book);
        }
    }
}

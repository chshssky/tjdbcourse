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
            // TODO: 这行代码将数据加载到表“dataSet.library”中。您可以根据需要移动或删除它。
            this.libraryTableAdapter.Fill(this.dataSet.library);
            // TODO: 这行代码将数据加载到表“dataSet.library”中。您可以根据需要移动或删除它。
            this.libraryTableAdapter.Fill(this.dataSet.library);
            // TODO: This line of code loads data into the 'dataSet.book_library_damaged' table. You can move, or remove it, as needed.
            this.bookLibraryDamagedTableAdapter.Fill(this.dataSet.book_library_damaged);
        }

        public void Reload(string ISBN)
        {
            // testing...
            this.dataSet.particular_book.Clear();

            string sql = "select * from book_library_damaged where isbn=@ISBN";
            //sql = "select * from particular_book";
            this.bookLibraryDamagedTableAdapter.Fill(this.dataSet.book_library_damaged);
            this.bookLibraryDamagedTableAdapter.Adapter.SelectCommand.CommandText = sql;
            this.bookLibraryDamagedTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            this.bookLibraryDamagedTableAdapter.Adapter.SelectCommand.Parameters.AddWithValue("@ISBN", ISBN);
            this.bookLibraryDamagedTableAdapter.Adapter.Fill(this.dataSet.book_library_damaged);
        }
    }
}

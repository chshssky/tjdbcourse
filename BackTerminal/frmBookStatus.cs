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

        private void ToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvStatus.SelectedRows[0].Cells[0].Value;
            string message = "你确定要删除id为" + id + "的实例吗？";
            const string caption = "删除一本书";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            string str;
            str = "DELETE FROM dbo.particular_book WHERE id=@id";

            SqlConnection connection = Library.Connection.Instance();
            SqlCommand command = new SqlCommand(str, connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}

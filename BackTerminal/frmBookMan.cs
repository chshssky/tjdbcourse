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
    public partial class frmBookMan : Form
    {
        public frmBookMan()
        {
            InitializeComponent();
        }

        private void ShowBookStatus()
        {
            frmBookStatus form = new frmBookStatus();
            form.Reload((string)dgvBook.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();
            refreshDGV();
        }

        private void ShowBookAdd()
        {
            frmBookAdd form = new frmBookAdd();
            form.setISBN((string)dgvBook.SelectedRows[0].Cells[0].Value);
            form.ShowDialog();
            refreshDGV();
        }

        private void frmBookMan_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet.readable_book”中。您可以根据需要移动或删除它。
            this.readablebookTableAdapter.Fill(this.dataSet.readable_book);

        }

        private void mnuToolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCategoryManage_Click(object sender, EventArgs e)
        {
            new frmCatMan().ShowDialog();
            refreshDGV();
        }

        private void mnuBookBuy_Click(object sender, EventArgs e)
        {
            new frmBookNew().ShowDialog();
            refreshDGV();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            this.dataSet.readable_book.Clear();

            string sql;
            if (searchText.Length > 0)
                sql = "select * from readable_book where title like @title";
            else
                sql = "select * from readable_book";

            this.readablebookTableAdapter.Adapter.SelectCommand.CommandText = sql;

            this.readablebookTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            if (searchText.Length > 0)
                this.readablebookTableAdapter.Adapter.SelectCommand.Parameters
                    .AddWithValue("@title", "%" + searchText + "%");

            this.readablebookTableAdapter.Fill(dataSet.readable_book);
        }

        private void mnuToolRefresh_Click(object sender, EventArgs e)
        {
            this.readablebookTableAdapter.Fill(this.dataSet.readable_book);
        }

        private void dgvBook_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Library.Util.TrimGridCell((DataGridView)sender, e.RowIndex, e.ColumnIndex);
        }

        private void dgvBook_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            DataGridViewColumn column = view.Columns[e.ColumnIndex];
            if (column.DataPropertyName.Equals("category") ||
                column.DataPropertyName.Equals("count"))
            {
                return;
            }

            Library.Util.UpdateGridCellForBook(
                (DataGridView)sender, "book", e.RowIndex, e.ColumnIndex);
        }

        private void toolStripMenuItemStatus_Click(object sender, EventArgs e)
        {
            ShowBookStatus();
        }

        private void toolStripMenuItemNewBook_Click(object sender, EventArgs e)
        {
            new frmBookNew().ShowDialog();
            refreshDGV();
        }

        private void dgvBook_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            if (e.Button != MouseButtons.Right || e.RowIndex < 0) return;
            view.ClearSelection();
            view.Rows[e.RowIndex].Selected = true;
        }

        private void toolStripMenuItemAddBook_Click(object sender, EventArgs e)
        {
            ShowBookAdd();
        }

        private void mnuBookStatus_Click(object sender, EventArgs e)
        {
            ShowBookStatus();
        }

        private void mnuBookAdd_Click(object sender, EventArgs e)
        {
            ShowBookAdd();
        }

        private void mnuBookDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void DeleteBook()
        {
            string ISBN = (string)dgvBook.SelectedRows[0].Cells[0].Value;
            string bookName = (string)dgvBook.SelectedRows[0].Cells[1].Value;
            string message = "你确定要删除“" + bookName + "”吗？";
            const string caption = "删除书目";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            string str;
            str = "DELETE FROM dbo.book WHERE isbn=@ISBN";

            SqlConnection connection = Library.Connection.Instance();
            SqlCommand command = new SqlCommand(str, connection);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.ExecuteNonQuery();
            command.Dispose();
            refreshDGV();
        }

        private void refreshDGV()
        {
            this.readablebookTableAdapter.Fill(this.dataSet.readable_book);
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ShowBookAdd();
        }

        private void tsbStatus_Click(object sender, EventArgs e)
        {
            ShowBookStatus();
        }
    }
}

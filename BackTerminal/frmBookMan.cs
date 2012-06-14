﻿using System;
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
        }

        private void mnuBookBuy_Click(object sender, EventArgs e)
        {
            new frmBookNew().ShowDialog();
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

            this.readablebookTableAdapter.Adapter.SelectCommand
                .CommandText = sql;

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
    }
}

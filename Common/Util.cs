using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Library
{
    class Util
    {
        public static string MD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            byte[] result = md5.ComputeHash(data);
            String ret = "";
            for (int i = 0; i < result.Length; i++)
                ret += result[i].ToString("x").PadLeft(2, '0');
            return ret;
        }

        public static string GetTableName(DataGridView view)
        {
            BindingSource bs = (BindingSource)view.DataSource;
            string tableName = bs.DataMember;
            return tableName;
        }

        public static void UpdateGridCell(DataGridView view, int row, int col)
        {
            DataGridViewRow theRow = view.Rows[row];
            if (theRow.IsNewRow)
                return;

            object idObj = theRow.Cells[0].Value;
            if (idObj == null || idObj is DBNull)
                return;

            int id = (int)idObj;
            object value = view.Rows[row].Cells[col].Value;

            string column = view.Columns[col].DataPropertyName;
            string tableName = GetTableName(view);
            string sql = "update [" + tableName + "] " +
                "set [" + column + "] = @value " +
                "where id = @id";
            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@id", idObj);
            if (value is string)
                cmd.Parameters.AddWithValue("@value", (string)value);
            else if (value is bool)
                cmd.Parameters.AddWithValue("@value", (bool)value);
            else if (value is int)
                cmd.Parameters.AddWithValue("@value", (int)value);
            else throw new Exception("类型不支持");
            cmd.ExecuteNonQuery();
        }

        public static void UpdateGridCellForBook(
            DataGridView view, string tableName, int row, int col)
        {
            DataGridViewRow theRow = view.Rows[row];
            if (theRow.IsNewRow)
                return;

            object idObj = theRow.Cells[0].Value;
            if (idObj == null || idObj is DBNull)
                return;

            string id = (string)idObj;
            object value = view.Rows[row].Cells[col].Value;

            string column = view.Columns[col].DataPropertyName;
            string sql = "update [" + tableName + "] " +
                "set [" + column + "] = @value " +
                "where isbn = @id";
            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@id", idObj);
            if (value is string)
                cmd.Parameters.AddWithValue("@value", (string)value);
            else if (value is bool)
                cmd.Parameters.AddWithValue("@value", (bool)value);
            else if (value is int)
                cmd.Parameters.AddWithValue("@value", (int)value);
            else throw new Exception("类型不支持");
            cmd.ExecuteNonQuery();
        }

        public static void TrimGridCell(DataGridView view, int row, int col)
        {
            DataGridViewCell cell = view.Rows[row].Cells[col];
            if (cell.Value is string)
                cell.Value = ((string)cell.Value).Trim();
        }

        public static void TrimAllGridCells(DataGridView view)
        {
            for (int i = 0; i < view.RowCount; ++i)
                for (int j = 0; j < view.ColumnCount; ++j)
                    TrimGridCell(view, i, j);
        }

        public static bool RemoveGridRow(DataGridView view, DataGridViewRowCancelEventArgs e)
        {
            string tableName = Library.Util.GetTableName(view);
            if (MessageBox.Show("你真的要删除么？", "确认删除",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                int id = (int)e.Row.Cells[0].Value;
                string sql = "delete from [" + tableName + "] where id = @id";
                SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
                cmd.Parameters.AddWithValue("@id", id);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                else
                    e.Cancel = true;
            }
            return false;
        }
    }
}

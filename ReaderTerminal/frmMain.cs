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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuTerminalExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuReaderLogin_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
        }

        private void txtSearchContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader book = null;
            if (cmbSearchType.SelectedItem.ToString().Equals("题名"))
            {
                lstBookResult.Clear();
                String bookName = txtSearchContent.Text;
                string sql =
                    "select * " +
                    "from book " +
                    "where title like '%'+@bookName+'%'";
                cmd = new SqlCommand(sql, Library.Connection.Instance());
                cmd.Parameters.AddWithValue("@bookName", bookName);
                book = cmd.ExecuteReader();
            }
            if (cmbSearchType.SelectedItem.ToString().Equals("责任者"))
            {
                lstBookResult.Clear();
                String author = txtSearchContent.Text;
                string sql =
                    "select * " +
                    "from book " +
                    "where author like '%'+@author+'%'";
                cmd = new SqlCommand(sql, Library.Connection.Instance());
                cmd.Parameters.AddWithValue("@author", author);
                book = cmd.ExecuteReader();
            }
            if (cmbSearchType.SelectedItem.ToString().Equals("ISBN"))
            {
                lstBookResult.Clear();
                String isbn = txtSearchContent.Text;
                string sql =
                    "select * " +
                    "from book " +
                    "where isbn = @isbn";
                cmd = new SqlCommand(sql, Library.Connection.Instance());
                cmd.Parameters.AddWithValue("@isbn", isbn);
                book = cmd.ExecuteReader();
            }
            if (cmbSearchType.SelectedItem.ToString().Equals("分类"))
            {
                lstBookResult.Clear();
                String title = txtSearchContent.Text;
                string sql =
                    "SELECT b.* " +
                    "FROM  book AS b, category AS c " +
                    "WHERE c.title LIKE '%'+@title+'%' AND " +
                    "c.id = b.category_id";
                cmd = new SqlCommand(sql, Library.Connection.Instance());
                cmd.Parameters.AddWithValue("@title", title);
                book = cmd.ExecuteReader();
            }
            if (cmbSearchType.SelectedItem.ToString().Equals("出版社"))
            {
                lstBookResult.Clear();
                String publisher = txtSearchContent.Text;
                string sql =
                    "select * " +
                    "from book " +
                    "where publisher = @publisher";
                cmd = new SqlCommand(sql, Library.Connection.Instance());
                cmd.Parameters.AddWithValue("@publisher", publisher);
                book = cmd.ExecuteReader();
            }
            while (book != null && book.Read())
            {
                String[] str = new String[3];
                str[0] = book[0].ToString();
                str[1] = book[1].ToString();
                str[2] = book[2].ToString();
                lstBookResult.View = View.List;
                ListViewItem item = new ListViewItem(str[0] + str[1] + "   " + str[2]);
                lstBookResult.Items.Add(item);
            }
            book.Close();
        }

        private void lstBookResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBookResult_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader book = null;
            String isbn = lstBookResult.SelectedItems[0].Text.ToString();
            isbn = isbn.Substring(0, isbn.IndexOf(" ") + 1);
            String sql =
                "select * " +
                "from book " +
                "where isbn = @isbn";
            cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@isbn", isbn);
            book = cmd.ExecuteReader();
            String[] str = new String[4];
            if (book != null && book.Read())
            {

                str[0] = book[1].ToString();
                str[1] = book[2].ToString();
                str[2] = book[3].ToString();
                str[3] = book[4].ToString();

            }
            else
            {
                MessageBox.Show("错误");

            }
            book.Close();

            SqlCommand cmd2;
            SqlDataReader book2 = null;
            String sql2 =
                "SELECT " +
                "pb.[id] AS particular_id, " +
                "lib.[name] AS library_name, " +
                "rt.[due_time] AS due_time " +
                "FROM " +
                "particular_book AS pb " +
                "INNER JOIN library AS lib " +
                "ON pb.[library_id] = lib.[id] " +
                "LEFT JOIN rental AS rt " +
                "ON pb.[id] = rt.[particular_book_id] " +
                "WHERE pb.[book_isbn] = @isbn ";
            cmd2 = new SqlCommand(sql2, Library.Connection.Instance());
            cmd2.Parameters.AddWithValue("@isbn", isbn);
            book2 = cmd2.ExecuteReader();
            String[] str2 = new String[3];
            String[] coinfo = new String[100];
            for (int i = 0; book2 != null && book2.Read(); ++i)
            {
                str2[0] = book2[0].ToString();
                str2[1] = book2[1].ToString();
                str2[2] = book2[2].ToString();
                if (str2[2] == "")
                    str2[2] = "未借出";
                String info = str2[0] + '\t' + str2[1] + '\t' + str2[2];
                coinfo[i] = info;
            }
            book2.Close();

            frmBook frmbook = new frmBook(str[0], str[3], str[1], str[2], coinfo);
            this.Hide();
            frmbook.ShowDialog();
            this.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet.borrowing”中。您可以根据需要移动或删除它。
            this.borrowingTableAdapter.Fill(this.dataSet.borrowing);
            cmbSearchType.SelectedIndex = 0;
            this.Size = new System.Drawing.Size(640, 480);
        }

        private void tpgReaderInfo_Click(object sender, EventArgs e)
        {
            btnReaderCancel_Click(sender, e);
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPassword frm = new frmPassword();
            frm.ShowDialog();
            this.Show();
        }

        private void mnuReaderChangePassword_Click(object sender, EventArgs e)
        {
            new frmPassword().ShowDialog();
        }

        private void btnReaderCancel_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            int readerId = frmLogin.readerId;
            string sql =
                "select * " +
                "from readable_reader " +
                "where id = @readerid";
            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@readerid", readerId);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtReaderName.Text = reader["name"].ToString().Trim();
                txtReaderRealName.Text = reader["real_name"].ToString().Trim();

                Boolean? gender = null;
                if (!(reader["gender"] is DBNull))
                    gender = (Boolean)reader["gender"];
                if (gender == null)
                    cmbReaderGender.SelectedIndex = 2;
                else if (gender == false)
                    cmbReaderGender.SelectedIndex = 1;
                else
                    cmbReaderGender.SelectedIndex = 0;

                int credType = (int)reader["credential_type"];
                cmbReaderCredType.SelectedIndex = credType - 1;
                txtReaderCredNumber.Text = ((string)reader["credential_number"]).Trim();

                txtPhone.Text = reader["telephone"].ToString().Trim();
                txtRegTime.Text = reader["register_time"].ToString().Trim();
                txtExpTime.Text = reader["expire_time"].ToString().Trim();
                bool available = (bool)reader["available"];
                if (available)
                    txtAvailable.Text = "是";
                else
                    txtAvailable.Text = "否";

                txtGroupName.Text = reader["group"].ToString().Trim();

                reader.Close();
            }
        }

        private void btnReaderSubmit_Click(object sender, EventArgs e)
        {
            string sql = "update reader set " +
                "   real_name = @real_name, " +
                "   gender = @gender, " +
                "   credential_type = @credential_type, " +
                "   credential_number = @credential_number, " +
                "   telephone = @telephone " +
                "where id = @id";

            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());

            cmd.Parameters.AddWithValue("@id", frmLogin.readerId);

            cmd.Parameters.AddWithValue("@real_name", txtReaderRealName.Text);

            Boolean? gender = null;
            if (cmbReaderGender.SelectedIndex == 1)
                gender = false;
            else if (cmbReaderGender.SelectedIndex == 0)
                gender = true;

            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@credential_type", cmbReaderCredType.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@credential_number", txtReaderCredNumber.Text);
            cmd.Parameters.AddWithValue("@telephone", txtPhone.Text);

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("成功更改读者信息。", "更改成功",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("无法更改读者信息。", "无法更改",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tpgBookRental_Enter(object sender, EventArgs e)
        {
            this.dataSet.borrowing.Clear();

            string sql = "select * from borrowing where reader_id = @reader_id";

            this.borrowingTableAdapter.Adapter.SelectCommand
                .CommandText = sql;

            this.borrowingTableAdapter.Adapter.SelectCommand.Parameters.Clear();
            this.borrowingTableAdapter.Adapter.SelectCommand.Parameters
                .AddWithValue("@reader_id", frmLogin.readerId);

            this.borrowingTableAdapter.Fill(dataSet.borrowing);
        }
    }
}

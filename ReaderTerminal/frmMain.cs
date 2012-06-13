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
            cmbSearchType.SelectedIndex = 0;
            this.Size = new System.Drawing.Size(640, 480);
            showreaderinfo();
            showrentinfo();
        }

        private void tpgReaderInfo_Click(object sender, EventArgs e)
        {



        }
        public void showreaderinfo()
        {
            SqlDataReader book2 = null;
            int readerId = frmLogin.readerId;
            string sql =
                "select * " +
                "from reader " +
                "where id = @readerid";
            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@readerid", readerId);
            book2 = cmd.ExecuteReader();
            String[] str = new String[11];
            if (book2.Read())
            {
                str[0] = "用户账号是：" + book2[0].ToString() + System.Environment.NewLine;
                str[1] = "用户姓名是：" + book2[1].ToString() + System.Environment.NewLine;
                str[2] = "用户密码是：" + book2[2].ToString() + System.Environment.NewLine;
                str[3] = "用户性别是：" + book2[3].ToString() + System.Environment.NewLine;
                str[4] = "用户性别是：" + book2[4].ToString() + System.Environment.NewLine;
                str[5] = "用户注册号类型是：" + book2[5].ToString() + System.Environment.NewLine;
                str[6] = "用户注册号是：" + book2[6].ToString() + System.Environment.NewLine;
                str[7] = "用户电话是：" + book2[7].ToString() + System.Environment.NewLine;
                str[8] = "用户注册时间是：" + book2[8].ToString() + System.Environment.NewLine;
                str[9] = "用户到期时间是：" + book2[9].ToString() + System.Environment.NewLine;
                book2.Close();
                for (int i = 0; i < 9; i++)
                {
                    readerInfo.Text += str[i];
                }
            }
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            changepsw frm = new changepsw();
            frm.ShowDialog();
            this.Show();
        }

        private void mnuReaderLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("退出成功！！！");
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        public void showrentinfo()
        {
            SqlDataReader book3 = null;
            int readerId = frmLogin.readerId;
            string sql3 =
                "SELECT b.isbn, b.title " +
                "FROM book AS b, particular_book AS p, rental AS r " +
                "WHERE r.reader_id = @readerId AND " +
                "r.particular_book_id = p.id AND " +
                "b.isbn = p.book_isbn";
            SqlCommand cmd = new SqlCommand(sql3, Library.Connection.Instance());
            cmd = new SqlCommand(sql3, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@readerid", readerId);
            book3 = cmd.ExecuteReader();
            String[] strb = new String[2];
            while (book3.Read())
            {
                strb[0] = book3[0].ToString();
                strb[1] = book3[1].ToString();
                listView1.View = View.List;
                ListViewItem item = new ListViewItem(strb[0] + strb[1]);
                listView1.Items.Add(item);
            }
            book3.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand cmd;
            SqlDataReader book = null;
            String isbn = listView1.SelectedItems[0].Text.ToString();
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
                for (int i = 0; i < 4; ++i)
                    textBox1.Text = textBox1.Text + str[i] + System.Environment.NewLine;

            }
            
            book.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

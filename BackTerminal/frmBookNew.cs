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
    public partial class frmBookNew : Form
    {
        const string root = "全部分类";
        struct Category
        {
            public int id;
            public String title;
            public int parent_id;
        }
        public frmBookNew()
        {
            InitializeComponent();
            InitializeTreeViewCategory();
            InitializeComboBoxLibrary();
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

        private TreeNode NodeFromKey(string key)
        {
            return tvCategory.Nodes.Find(key, true)[0];
        }

        private void InitializeTreeViewCategory()
        {
            SqlConnection connection = Library.Connection.Instance();
            string queryString = "SELECT * FROM dbo.category ORDER BY parent_id, title;";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();

            tvCategory.Nodes.Add(root);

            while (reader.Read())
            {
                Category cat;
                cat.id = (int)reader["id"];
                cat.title = (String)reader["title"];
                cat.parent_id = 0;
                if (!(reader["parent_id"] is DBNull))
                    cat.parent_id = (int)reader["parent_id"];
                if (cat.parent_id == 0)
                {
                    tvCategory.Nodes[0].Nodes.Add(cat.id.ToString(), cat.title);
                }
                else
                {
                    NodeFromKey(cat.parent_id.ToString()).Nodes.Add(cat.id.ToString(), cat.title);
                }
                Console.Out.WriteLine(cat.title);
            }
            reader.Close();
            tvCategory.ExpandAll();
        }

        // 判断用户是否选中 TreeView 中的一项
        private bool TreeViewSelected()
        {
            if (tvCategory.SelectedNode == null)
            {
                MessageBox.Show("请选择一个分类！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        private void ErrorMessage(string str)
        {
            MessageBox.Show(str, "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        // 检查字符串是否小于 length，并且长度大于0
        private bool CheckString(string str, int length = int.MaxValue)
        {
            if (string.IsNullOrEmpty(str)) return false;
            if (str.Length > length) return false;
            return true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!TreeViewSelected()) return;
            string categoryTitle = tvCategory.SelectedNode.Text;

            // 获取各控件的值
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            string publisher = textBoxPublisher.Text;
            string ISBN = textBoxISBN.Text;
            int quantity = (int)numericUpDown.Value;
            string libraryName = (string)comboBoxLibrary.SelectedItem;
            string description = textBoxDescription.Text;

            // 检查各控件的值
            if (!(CheckString(title, 20) && CheckString(author, 50) && CheckString(publisher, 50)
                && (CheckString(description, 100) || description.Length == 0)))
            {
                ErrorMessage("您输入的字符车过长或为空");
                return;
            }

            if (categoryTitle == root)
            {
                MessageBox.Show("不能选择“全部分类”。请重新选择一个分类！",
                    "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            

            // 检查 dbo.book 中是否存在这个 ISBN
            SqlConnection connection = Library.Connection.Instance();
            string queryString = "SELECT COUNT(*) FROM dbo.book where isbn=@ISBN;";
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = int.Parse(reader[0].ToString());
            }
            reader.Close();
            if (count > 0)
            {
                ErrorMessage("ISBN已存在");
                return;
            }

            // 获取 category id            
            queryString = "SELECT id FROM dbo.category where title=@title";
            command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@title", categoryTitle);
            reader = command.ExecuteReader();
            int categoryId = 1;
            while (reader.Read())
            {
                categoryId = (int)reader[0];
            }
            reader.Close();

            // 获取 library id
            queryString = "SELECT id FROM dbo.library where name=@libraryName";
            command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@libraryName", libraryName);
            reader = command.ExecuteReader();
            int libraryId = 1;
            while (reader.Read())
            {
                libraryId = (int)reader[0];
                Console.Out.WriteLine(libraryId);
            }
            reader.Close();

            // INSERT INTO dbo.book
            string sql = "INSERT INTO dbo.book (isbn, title, author, publisher, description, category_id)" +
                "VALUES(@ISBN, @title, @author, @publisher, @description, @category_id);";
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@publisher", publisher);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@category_id", categoryId);
            command.ExecuteNonQuery();

            // INSERT INTO dbo.particular_book
            for (int i = 0; i < quantity; i++)
            {
                sql = "INSERT INTO dbo.particular_book (book_isbn, library_id)" +
                    "VALUES(@book_isbn, @library_id);";
                command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@book_isbn", ISBN);
                command.Parameters.AddWithValue("@library_id", libraryId);
                command.ExecuteNonQuery();
            }
            this.Dispose();
        }
    }
}

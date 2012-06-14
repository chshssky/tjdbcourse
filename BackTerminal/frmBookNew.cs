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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!TreeViewSelected()) return;
            string categoryTitle = tvCategory.SelectedNode.Text;

            // 获取 category id
            SqlConnection connection = Library.Connection.Instance();
            string queryString = "SELECT id FROM dbo.category where title='" + categoryTitle + "';";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            int categoryId = 1;
            while (reader.Read())
            {
                categoryId = (int)reader[0];
                Console.Out.WriteLine(categoryId);
            }
            reader.Close();


            // 获取各控件的值
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            string publisher = textBoxPublisher.Text;
            string ISBN = textBoxISBN.Text;
            int quantity = (int)numericUpDown.Value;
            string libraryName = (string)comboBoxLibrary.SelectedItem;
            string description = textBoxDescription.Text;
            
            
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
        }
    }
}

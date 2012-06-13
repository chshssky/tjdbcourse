using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Library;

namespace FrontTerminal
{
    public partial class frmLogin : Form
    {
        public static int readerId;

        public const int FRONT_TERMINAL_PERMISSION = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strName = txtName.Text;
            string strPasw = txtPassword.Text;
            string strPwMd5 = Library.Util.MD5(strPasw);

            string sql = "select permission " +
                "from manager " +
                "where [name] = @strName and " +
                "   password = @strPasw";

            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());

            cmd.Parameters.AddWithValue("@strName", strName);
            cmd.Parameters.AddWithValue("@strPasw", strPwMd5);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                reader.Close();
                if ((id & FRONT_TERMINAL_PERMISSION) != 1)
                {
                    this.Hide();
                    new frmMain().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("抱歉，您的权限不够。", "无法登录",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                reader.Close();
                MessageBox.Show("你的账号或密码错误。", "无法登录",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

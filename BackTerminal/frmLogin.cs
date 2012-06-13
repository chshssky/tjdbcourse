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
    public partial class frmLogin : Form
    {
        public static int readerId;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strName = txtName.Text;
            string strPasw = txtPassword.Text;
            string sql =
                "select permission " +
                "from dbo.manager " +
                "where name = @strName and password = @strPasw";
            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@strName", strName);
            cmd.Parameters.AddWithValue("@strPasw", strPasw);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                reader.Close();
                if (id == 1)
                {
                    frmBookMan main = new frmBookMan();
                    this.Hide();
                    main.ShowDialog();                    
                }
                else
                {
                    MessageBox.Show("抱歉，您的权限不够。");
                }
            }
            else
            {
                reader.Close();
                MessageBox.Show("你的账号或密码错误。");                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

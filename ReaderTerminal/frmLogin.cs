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
                "select id " +
                "from reader " +
                "where name = @strName and password = @strPasw";
            SqlCommand cmd = new SqlCommand(sql, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@strName", strName);
            cmd.Parameters.AddWithValue("@strPasw", strPasw);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                readerId = reader.GetInt32(0);
                reader.Close();
                this.Hide();
                new frmMain().ShowDialog();
                this.Show();
            }
            else
            {
                reader.Close();
                MessageBox.Show("你的账号或密码错误。");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRegister().ShowDialog();
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

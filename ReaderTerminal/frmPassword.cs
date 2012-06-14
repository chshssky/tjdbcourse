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
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string newpsw = txtNewPassword.Text;
            string newpswcfm = txtPasswordConfirm.Text;
            if (!newpsw.Equals(newpswcfm))
            {
                MessageBox.Show("两次输入的密码不相同，请重新输入。", "无法更改密码",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string npwmd5 = Library.Util.MD5(newpsw);
            string oldpsw = txtOldPassword.Text;
            string opwmd5 = Library.Util.MD5(oldpsw);

            string sql1 = 
                "update reader " +
                "set password = @password " +
                "where id = @id and password = @oldpassword";

            SqlCommand cmd = new SqlCommand(sql1, Library.Connection.Instance());
            cmd.Parameters.AddWithValue("@id", frmLogin.readerId);
            cmd.Parameters.AddWithValue("@oldpassword", opwmd5);
            cmd.Parameters.AddWithValue("@password", npwmd5);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("密码修改成功。", "修改成功",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("密码修改失败，请重新检查是否填写了正确的旧密码。", "修改失败",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
